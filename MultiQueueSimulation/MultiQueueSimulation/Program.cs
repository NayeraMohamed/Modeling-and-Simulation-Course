using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueTesting;
using MultiQueueModels;

namespace MultiQueueSimulation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SimulationSystem system = new SimulationSystem();
            system.ReadFromFiles();
            Random r = new Random();
            //filling time distribution of Interarrival time and server time
            system.RangesCalcualtion(system.InterarrivalDistribution);
            //Console.WriteLine(system.InterarrivalDistribution[2].CummProbability);
            for (int i = 0; i < system.Servers.Count; ++i)
            {
                system.RangesCalcualtion(system.Servers[i].TimeDistribution);
                system.Servers[i].FinishTime = 0;
                system.Servers[i].TotalWorkingTime = 0;
                system.Servers[i].NumberOfCustomers = 0;
                //Console.WriteLine(system.Servers[i].TimeDistribution[1].CummProbability);
            }

            int randArrival = 0, time, randService, index = 0, customerIndex = 0, CustomerInQueue=0, TimeInQueue=0;
            while (true)
            {
                SimulationCase customer = new SimulationCase();
                if (system.StoppingCriteria == Enums.StoppingCriteria.NumberOfCustomers)
                {
                    if (customerIndex  >= system.StoppingNumber)
                    {
                        break;
                    }
                }
                else //time
                {
                    int Time = 0; //largest service time for all servers
                    for (int x = 0; x < system.Servers.Count; ++x)
                    {
                        if (system.Servers[x].FinishTime > Time)
                        {
                            Time = system.Servers[x].FinishTime;
                        }
                    }
                    if (Time >= system.StoppingNumber)
                    {
                        break;
                    }
                }

                //creating simulation table
                customer.CustomerNumber = customerIndex + 1;
                if (customerIndex == 0)
                {
                    customer.RandomInterArrival = 1;
                    customer.InterArrival = 0;
                    customer.ArrivalTime = 0;
                }
                else
                {
                    randArrival = r.Next(1, 100);
                    customer.RandomInterArrival = randArrival;
                    time = system.MapRanges(system.InterarrivalDistribution, randArrival);
                    customer.InterArrival = time;
                    customer.ArrivalTime = system.SimulationTable[customerIndex - 1].ArrivalTime + time;
                }

                //server selection 
                bool serverFound = false;
                if (system.SelectionMethod == Enums.SelectionMethod.Random)
                {
                    HashSet<int> busyServers = new HashSet<int>();
                    while (busyServers.Count < system.Servers.Count)
                    {
                        index = r.Next(1, system.Servers.Count);
                        if (!busyServers.Contains(index))
                        {
                            if (system.Servers[index].FinishTime <= customer.ArrivalTime) //available server
                            {
                                serverFound = true;
                                break;
                            }
                            busyServers.Add(index);
                        }
                    }
                }
                else if (system.SelectionMethod == Enums.SelectionMethod.HighestPriority)
                {
                    for (int j = 0; j < system.Servers.Count; ++j)
                    {
                        if (system.Servers[j].FinishTime <= customer.ArrivalTime) //available server
                        {
                            index = j;
                            serverFound = true;
                            break;
                        }
                    }
                }

                if (serverFound)
                {
                    customer.StartTime = customer.ArrivalTime;
                }
                else
                {
                    CustomerInQueue++;
                    //loop on servers and check which server has smallest finish time
                    int finishTime = Int32.MaxValue;
                    for (int x = 0; x < system.Servers.Count; ++x)
                    {
                        if (system.Servers[x].FinishTime < finishTime)
                        {
                            finishTime = system.Servers[x].FinishTime;
                            index = x;
                            customer.StartTime = finishTime;
                        }
                    }
                }
                
                system.Servers[index].NumberOfCustomers += 1;
                customer.TimeInQueue = system.Servers[index].FinishTime - customer.ArrivalTime;
                customer.TimeInQueue = (customer.TimeInQueue <= 0) ? 0 : customer.TimeInQueue;
                TimeInQueue += customer.TimeInQueue;
                randService = r.Next(1, 100);
                customer.RandomService = randService;
                time = system.MapRanges(system.Servers[index].TimeDistribution, randService);
                customer.ServiceTime = time;
                system.Servers[index].TotalWorkingTime += customer.ServiceTime;
                customer.EndTime = time + customer.StartTime;
                system.Servers[index].FinishTime = customer.EndTime;
                
                customer.AssignedServer = system.Servers[index];
                customerIndex++; //increment customer number
                system.SimulationTable.Add(customer);
            }

            //performance measures
            system.PerformanceMeasures.AverageWaitingTime = (decimal)TimeInQueue / system.SimulationTable.Count;
            system.PerformanceMeasures.WaitingProbability = ((decimal)CustomerInQueue / system.SimulationTable.Count) * 100;
            system.PerformanceMeasures.MaxQueueLength = CustomerInQueue;
            

            //performance measures per server
            int TotalrunTime =0;
            for (int i = 0; i < system.Servers.Count; ++i )
            {
                if (system.Servers[i].FinishTime > TotalrunTime)
                    TotalrunTime = system.Servers[i].FinishTime;
            }
            for (int i = 0; i < system.Servers.Count; ++i)
            {
                
                 system.Servers[i].IdleProbability = ((decimal)(TotalrunTime - system.Servers[i].TotalWorkingTime) / TotalrunTime) * 100;
                if (system.Servers[i].NumberOfCustomers == 0)
                    system.Servers[i].AverageServiceTime = 0;
                else
                    system.Servers[i].AverageServiceTime = (decimal)system.Servers[i].TotalWorkingTime / system.Servers[i].NumberOfCustomers;
                system.Servers[i].Utilization = (decimal)system.Servers[i].TotalWorkingTime / TotalrunTime;
                    
            }
            //check if we need extra server
            system.PerformanceMeasures.ExtraServerNeeded = false;
            if (system.PerformanceMeasures.WaitingProbability >= (decimal)0.5)
            {
                system.PerformanceMeasures.ExtraServerNeeded = true;
            }

            string result = TestingManager.Test(system, Constants.FileNames.TestCase1);
            MessageBox.Show(result);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());       
        }
    }
}
