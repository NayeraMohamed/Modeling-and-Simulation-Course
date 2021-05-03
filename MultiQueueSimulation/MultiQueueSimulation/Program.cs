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
            
            System.Random random = new System.Random();
            //filling time distribution of Interarrival time and server time
            system.RangesCalcualtion(system.InterarrivalDistribution);
            //Console.WriteLine(system.InterarrivalDistribution[2].CummProbability);
            for (int i = 0; i < system.Servers.Count; ++i)
            {
                system.RangesCalcualtion(system.Servers[i].TimeDistribution);
                system.Servers[i].FinishTime = 0;
                Console.WriteLine(system.Servers[i].TimeDistribution[1].CummProbability);
            }

            int randArrival = 0, time, randService, index = 0, customerIndex = 0;
            while (true)
            {
                if (system.StoppingCriteria.Equals("NumberOfCustomers"))
                {
                    if (customerIndex + 1 >= system.StoppingNumber)
                    {
                        break;
                    }
                }
                else //time
                {
                    int Time = 0; //largest serveice time for all servers
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
                system.SimulationTable[customerIndex].CustomerNumber = customerIndex + 1;
                if (customerIndex == 0)
                {
                    system.SimulationTable[customerIndex].RandomInterArrival = 0;
                    system.SimulationTable[customerIndex].InterArrival = 0;
                    system.SimulationTable[customerIndex].ArrivalTime = 0;
                }
                else
                {
                    randArrival = random.Next(1, 100);
                    system.SimulationTable[customerIndex].RandomInterArrival = randArrival;
                    time = system.MapRanges(system.InterarrivalDistribution, randArrival);
                    system.SimulationTable[customerIndex].InterArrival = time;
                    system.SimulationTable[customerIndex].ArrivalTime = system.SimulationTable[customerIndex - 1].ArrivalTime + time;
                }

                //server selection 
                bool serverFound = false;
                if (system.SelectionMethod.Equals("Random"))
                {
                    HashSet<int> busyServers = new HashSet<int>();
                    while (busyServers.Count < system.Servers.Count)
                    {
                        index = random.Next(1, system.Servers.Count);
                        if (!busyServers.Contains(index))
                        {
                            if (system.Servers[index].FinishTime <= system.SimulationTable[customerIndex].ArrivalTime) //available server
                            {
                                serverFound = true;
                                break;
                            }
                            busyServers.Add(index);
                        }
                    }
                }
                else if (system.SelectionMethod.Equals("HighestPriority"))
                {
                    for (int j = 0; j < system.Servers.Count; ++j)
                    {
                        if (system.Servers[j].FinishTime <= system.SimulationTable[customerIndex].ArrivalTime) //available server
                        {
                            index = j;
                            serverFound = true;
                            break;
                        }
                    }
                }

                if (serverFound)
                {
                    system.SimulationTable[customerIndex].StartTime = system.SimulationTable[customerIndex].ArrivalTime;
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
                            system.SimulationTable[customerIndex].StartTime = finishTime;
                        }
                    }
                }
                randService = random.Next(1, 100);
                time = system.MapRanges(system.Servers[index].TimeDistribution, randArrival);
                system.SimulationTable[customerIndex].ServiceTime = time;
                system.Servers[index].FinishTime = system.SimulationTable[customerIndex].EndTime = time + system.SimulationTable[customerIndex].StartTime;
                system.SimulationTable[customerIndex].TimeInQueue = system.Servers[index].FinishTime - system.SimulationTable[customerIndex].ArrivalTime;
                system.SimulationTable[customerIndex].TimeInQueue = (system.SimulationTable[customerIndex].TimeInQueue <= 0) ? 0 : system.SimulationTable[customerIndex].TimeInQueue;

                customerIndex++; //increment customer number
            }
            
            string result = TestingManager.Test(system, Constants.FileNames.TestCase1);
            MessageBox.Show(result);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }
    }
}
