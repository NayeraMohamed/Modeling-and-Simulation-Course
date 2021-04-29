using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MultiQueueModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            this.Servers = new List<Server>();
            this.InterarrivalDistribution = new List<TimeDistribution>();
            this.PerformanceMeasures = new PerformanceMeasures();
            this.SimulationTable = new List<SimulationCase>();

            /*Reading Files...........
            case(1) = "TestCase1.txt"
            case(2) = "TestCase2.txt"
            case(3) = "TestCase3.txt*/

            FileStream TestCase1 = new FileStream("TestCase3.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(TestCase1);
            String line;
            sr.ReadLine();
            line = sr.ReadLine();
            this.NumberOfServers = Int32.Parse(line);
            sr.ReadLine();
            sr.ReadLine();
            line = sr.ReadLine();
            this.StoppingNumber = Int32.Parse(line);
            sr.ReadLine();
            sr.ReadLine();
            line = sr.ReadLine();
            int stop = Int32.Parse(line);
            if (stop == 1)
                this.StoppingCriteria = Enums.StoppingCriteria.NumberOfCustomers;
            else if (stop == 2)
                this.StoppingCriteria = Enums.StoppingCriteria.SimulationEndTime;
            sr.ReadLine();
            sr.ReadLine();
            line = sr.ReadLine();
            int select= Int32.Parse(line);
            if (select == 1)
                this.SelectionMethod = Enums.SelectionMethod.HighestPriority;
            else if (select == 2)
                this.SelectionMethod = Enums.SelectionMethod.Random;
            else if (select == 3)
                this.SelectionMethod = Enums.SelectionMethod.LeastUtilization;
            //this.SelectionMethod
            sr.ReadLine();
            sr.ReadLine();
            line = sr.ReadLine();
            while (line != "")
            {
                string [] interarrival = line.Split(new string[] { ", " }, System.StringSplitOptions.None);
                TimeDistribution interarrivalTemp = new TimeDistribution();
                interarrivalTemp.Time = Int32.Parse(interarrival[0]);
                interarrivalTemp.Probability = Decimal.Parse(interarrival[1]);
                this.InterarrivalDistribution.Add(interarrivalTemp);
                line = sr.ReadLine();
            }
            for(int j=0; j < this.NumberOfServers; j++)
            {
                sr.ReadLine();
                bool end = false;
                Server currentServer = new Server();
                List<TimeDistribution> serviceDistributionTemp = new List<TimeDistribution>();                
                currentServer.ID = j + 1;
                line = sr.ReadLine();
                while (line != "")
                {
                    string [] serviceDist = line.Split(new string[] { ", " },System.StringSplitOptions.None);
                    TimeDistribution currentTimeDist = new TimeDistribution();
                    currentTimeDist.Time = Int32.Parse(serviceDist[0]);
                    currentTimeDist.Probability = Decimal.Parse(serviceDist[1]);
                    serviceDistributionTemp.Add(currentTimeDist);
                    if(sr.Peek() == -1)
                    {
                        end = true;
                        break;
                    }
                    line = sr.ReadLine();
                }                
                currentServer.TimeDistribution = serviceDistributionTemp;
                this.Servers.Add(currentServer);
                if (end == true)
                {
                    break;
                }
            }
            sr.Close();
            TestCase1.Close();
        }
        ///////////// INPUTS ///////////// 
        public int NumberOfServers { get; set; }
        public int StoppingNumber { get; set; }
        public List<Server> Servers { get; set; }
        public List<TimeDistribution> InterarrivalDistribution { get; set; }
        public Enums.StoppingCriteria StoppingCriteria { get; set; }
        public Enums.SelectionMethod SelectionMethod { get; set; }


        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

        //Function to calculate time ranges
        public void RangesCalcualtion(List<TimeDistribution> list)
        {
            decimal com = 1;
            for (int i = 0; i < list.Count; i++)
            {
                decimal probability = list[i].Probability;
               
                if (i == 0)
                {
                    list[i].CummProbability = probability;
                    com = list[i].CummProbability;
                    list[i].MinRange = 1;
                    list[i].MaxRange = (int)(com * 100);
                }
                
                else
                {
                    list[i].MinRange = (int)((com * 100) + 1);
                    list[i].CummProbability = com + probability;
                    com = list[i].CummProbability;
                    list[i].MaxRange = (int)(com * 100);
                }
                if (probability == 0)
                {
                    list[i].MinRange = 0;
                    list[i].MaxRange = 0;
                }
            }

        }

        //Function to map time ranges
        public int MapRanges(List<TimeDistribution> list, int num)
        {

            for (int i = 0; i < list.Count(); i++)
            {
                if (num >= list[i].MinRange && num <= list[i].MaxRange)
                {
                    //SimulationTable[index].InterArrival = list[i].Time;
                    // SimulationTable[index].ArrivalTime = SimulationTable[index - 1].ArrivalTime + SimulationTable[index].InterArrival;
                    return list[i].Time;
                }
            }
            return -1;
        }

        

    }
}
