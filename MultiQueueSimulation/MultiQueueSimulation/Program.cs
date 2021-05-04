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
            Random r = new Random();
            //filling time distribution of Interarrival time and server time
            system.RangesCalcualtion(system.InterarrivalDistribution);
            for (int i = 0; i < system.Servers.Count; ++i)
            {
                system.RangesCalcualtion(system.Servers[i].TimeDistribution);
                system.Servers[i].FinishTime = 0;
            }

            int randArrival = 0, time, randService, index = 0, customerIndex = 0;
            while (true)
            {
                SimulationCase customer = new SimulationCase();
                if (system.StoppingCriteria == Enums.StoppingCriteria.NumberOfCustomers)
                {
                    if (customerIndex >= system.StoppingNumber)
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
                randService = r.Next(1, 100);
                customer.RandomService = randService;
                time = system.MapRanges(system.Servers[index].TimeDistribution, randService);
                customer.ServiceTime = time;
                customer.EndTime = time + customer.StartTime;
                system.Servers[index].FinishTime = customer.EndTime;
                customer.TimeInQueue = system.Servers[index].FinishTime - customer.ArrivalTime;
                customer.TimeInQueue = (customer.TimeInQueue <= 0) ? 0 : customer.TimeInQueue;

                customerIndex++; //increment customer number
                system.SimulationTable.Add(customer);
            }
            
            string result = TestingManager.Test(system, Constants.FileNames.TestCase1);
            MessageBox.Show(result);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());       
        }
    }
}
