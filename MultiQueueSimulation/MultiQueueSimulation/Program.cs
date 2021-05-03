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

            //creating simulation table
            int randArrival, time, randService, index;
            if (system.StoppingCriteria.Equals( "NumberOfCustomers"))
            {
                for (int i = 0; i < system.StoppingNumber; ++i)
                {
                    system.SimulationTable[i].CustomerNumber = i + 1;
                    if(i == 0)
                    {
                        system.SimulationTable[i].RandomInterArrival = 0;
                        system.SimulationTable[i].InterArrival = 0;
                        system.SimulationTable[i].ArrivalTime = 0;
                    }
                    else
                    {
                        randArrival = random.Next(1, 100);
                        system.SimulationTable[i].RandomInterArrival = randArrival;
                        time = system.MapRanges(system.InterarrivalDistribution, randArrival);
                        system.SimulationTable[i].InterArrival = time;
                        system.SimulationTable[i].ArrivalTime = system.SimulationTable[i - 1].ArrivalTime + time;
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
                                if (system.Servers[index].FinishTime <= system.SimulationTable[i].ArrivalTime) //available server
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
                            if (system.Servers[j].FinishTime <= system.SimulationTable[i].ArrivalTime) //available server
                            {
                                index = j;
                                serverFound = true;
                                break;
                            }
                        }
                    }

                    if (serverFound)
                    {
                        system.SimulationTable[i].StartTime = system.SimulationTable[i].ArrivalTime;
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
                                system.SimulationTable[i].StartTime = finishTime;
                            }
                        }
                    }  
                    randService = random.Next(1, 100);
                    time = system.MapRanges(system.Servers[index].TimeDistribution, randArrival);
                    system.SimulationTable[i].ServiceTime = time;
                    system.Servers[index].FinishTime = system.SimulationTable[i].EndTime = time + system.SimulationTable[i].StartTime;
                    system.SimulationTable[i].TimeInQueue = system.Servers[index].FinishTime - system.SimulationTable[i].ArrivalTime;
                    system.SimulationTable[i].TimeInQueue = (system.SimulationTable[i].TimeInQueue <= 0) ? 0 : system.SimulationTable[i].TimeInQueue;
                }
            }
            else //time
            //b akbr runtime 3nd kol el servers lw mwlsnash ll time da
            {
                int customerIndex = 0, Time = 0;
                while(Time <= system.StoppingNumber)
                {
                    system.SimulationTable[customerIndex].CustomerNumber = customerIndex + 1;
                    randArrival = random.Next(1, 100);
                    system.SimulationTable[i].RandomInterArrival = randArrival;
                    time = system.MapRanges(system.InterarrivalDistribution, randArrival);
                    system.SimulationTable[customerIndex].InterArrival = time;
                    system.SimulationTable[customerIndex].ArrivalTime = system.SimulationTable[customerIndex - 1].ArrivalTime + time;
                    //server selection fet index
                    randService = random.Next(1, 100);
                    time = system.MapRanges(system.Servers[index].TimeDistribution, randArrival);
                    //begin time
                    system.SimulationTable[customerIndex].ServiceTime = time;
                    system.SimulationTable[customerIndex].EndTime = time + system.SimulationTable[customerIndex].StartTime;
                    
                    Time += system.SimulationTable[customerIndex].EndTime;
                    customerIndex += 1;
                }
            }
            
            string result = TestingManager.Test(system, Constants.FileNames.TestCase1);
            MessageBox.Show(result);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }
    }
}
