using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DemandDistribution = new List<Distribution>();
            LeadDaysDistribution = new List<Distribution>();
            SimulationCases = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }

        ///////////// INPUTS /////////////

        public int OrderUpTo { get; set; }
        public int ReviewPeriod { get; set; }
        public int NumberOfDays { get; set; }
        public int StartInventoryQuantity { get; set; }
        public int StartLeadDays { get; set; }
        public int StartOrderQuantity { get; set; }
        public List<Distribution> DemandDistribution { get; set; }
        public List<Distribution> LeadDaysDistribution { get; set; }

        ///////////// OUTPUTS /////////////

        public List<SimulationCase> SimulationCases { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

        #region Reading File
        public void ReadFile()
        {
            FileStream TestCase = new FileStream("TestCase1.txt", FileMode.OpenOrCreate); 
            StreamReader sr = new StreamReader(TestCase);
            string line;
            sr.ReadLine();
            line = sr.ReadLine();
            this.OrderUpTo = Int32.Parse(line);
            sr.ReadLine();
            sr.ReadLine();
            line = sr.ReadLine();
            this.ReviewPeriod = Int32.Parse(line);
            sr.ReadLine();
            sr.ReadLine();
            line = sr.ReadLine();
            this.StartInventoryQuantity = Int32.Parse(line);
            sr.ReadLine();
            sr.ReadLine();
            line = sr.ReadLine();
            this.StartLeadDays = Int32.Parse(line);
            sr.ReadLine();
            sr.ReadLine();
            line = sr.ReadLine();
            this.StartOrderQuantity = Int32.Parse(line);
            sr.ReadLine();
            sr.ReadLine();
            line = sr.ReadLine();
            this.NumberOfDays = Int32.Parse(line);
            sr.ReadLine();
            sr.ReadLine();
            line = sr.ReadLine();
            
            while (line != "")
            {
                string[] demandDist = line.Split(new string[] { ", " }, System.StringSplitOptions.None);
                Distribution DemanDistribution = new Distribution();
                DemanDistribution.Value = Int32.Parse(demandDist[0]);
                DemanDistribution.Probability = Decimal.Parse(demandDist[1]);
                this.DemandDistribution.Add(DemanDistribution);
                line = sr.ReadLine();
            }

            sr.ReadLine();
            line = sr.ReadLine();
            while (line != "")
            {
                string[] leadDayDist = line.Split(new string[] { ", " }, System.StringSplitOptions.None);
                Distribution LeadDayDistribution = new Distribution();
                LeadDayDistribution.Value = Int32.Parse(leadDayDist[0]);
                LeadDayDistribution.Probability = Decimal.Parse(leadDayDist[1]);
                this.LeadDaysDistribution.Add(LeadDayDistribution);
                line = sr.ReadLine();
                if (line == null)
                    line = "";
            }
            sr.Close();
            TestCase.Close();
        }
        #endregion
    }
}
