using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NewspaperSellerModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions = new List<DemandDistribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }
        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }
        public int NumOfRecords { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ScrapPrice { get; set; }
        public decimal UnitProfit { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public List<DemandDistribution> DemandDistributions { get; set; }

        #region Reading File
        public void ReadFile()
        {
            FileStream TestCase = new FileStream("TestCase3.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(TestCase);
            string line;
            sr.ReadLine();
            line = sr.ReadLine();
            this.NumOfNewspapers = Int32.Parse(line);
            sr.ReadLine();
            sr.ReadLine();
            line = sr.ReadLine();
            this.NumOfRecords = Int32.Parse(line);
            sr.ReadLine();
            sr.ReadLine();
            line = sr.ReadLine();
            this.PurchasePrice = Decimal.Parse(line);
            sr.ReadLine();
            sr.ReadLine();
            line = sr.ReadLine();
            this.ScrapPrice = Decimal.Parse(line);
            sr.ReadLine();
            sr.ReadLine();
            line = sr.ReadLine();
            this.SellingPrice = Decimal.Parse(line);
            sr.ReadLine();
            sr.ReadLine();
            line = sr.ReadLine();
            string[] dayTypeDist = line.Split(new string[] { ", " }, System.StringSplitOptions.None);
            
            for (int i = 0; i < 3; i++) {
                DayTypeDistribution element = new DayTypeDistribution();
                if (i == 0)
                {
                    element.DayType = Enums.DayType.Good;

                }
                else if (i == 1)
                {
                    element.DayType = Enums.DayType.Fair;
                }
                else if (i == 2)
                {
                    element.DayType = Enums.DayType.Poor;
                }
                element.Probability = Decimal.Parse(dayTypeDist[i]);
                this.DayTypeDistributions.Add(element);
            }
            sr.ReadLine();
            line=sr.ReadLine();
            //bool end = false;
            while(line != "")
            {
              line = sr.ReadLine();
              string [] demandDisp = line.Split(new string[] { ", " }, System.StringSplitOptions.None);
                DemandDistribution element = new DemandDistribution();
                List<DayTypeDistribution> list = new List<DayTypeDistribution>();
                element.Demand = Int32.Parse(demandDisp[0]);
                for (int i = 0; i <3; i++)
                {
                    DayTypeDistribution listElement = new DayTypeDistribution();
                    listElement.Probability = Decimal.Parse(demandDisp[i+1]);
                    if (i == 0)
                    {
                        listElement.DayType = Enums.DayType.Good;

                    }
                    else if (i == 1)
                    {
                        listElement.DayType = Enums.DayType.Fair;
                    }
                    else if (i == 2)
                    {
                        listElement.DayType = Enums.DayType.Poor;
                    }
                    list.Add(listElement);
                    
                }
                element.DayTypeDistributions = list;
                this.DemandDistributions.Add(element);
                if (sr.Peek() == -1)
                {
                    
                    break;
                }

            }

        }
        #endregion

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }
    }
}
