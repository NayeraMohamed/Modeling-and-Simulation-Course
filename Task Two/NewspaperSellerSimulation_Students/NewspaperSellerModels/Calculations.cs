using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class Calculations
    {
        public Calculations(SimulationSystem simulationSystem)
        {
            this.simulationSystem = simulationSystem;
        }

        SimulationSystem simulationSystem;

        //Main method
        public SimulationSystem calculate()
        {
            Random random = new Random();
            DayTypeRangesCalcualtion(simulationSystem.DayTypeDistributions);
            DemandsRangesCalcualtion(simulationSystem.DemandDistributions);

            int lostProfitCounter = 0, scrapProfitCounter = 0;
            decimal dailyCost = simulationSystem.NumOfNewspapers * simulationSystem.PurchasePrice, totalSalesProfit = 0,
                totalCost = dailyCost * simulationSystem.NumOfRecords, totalLostProfit = 0, totalScrapProfit = 0, totalNetProfit;
            
            for (int i=0; i< simulationSystem.NumOfRecords; i++)
            {
                //Generating random number for dayType and mapping it
                int randomDayType = random.Next(1, 100);
                Enums.DayType newsDayType = MapDayTypeRanges(simulationSystem.DayTypeDistributions, randomDayType);

                //Generating Random number for demands and mapping it
                int randomDemand = random.Next(1, 100), demand = 0;
                foreach(DemandDistribution demandElement in simulationSystem.DemandDistributions)
                {
                    if(MapDemandRanges(demandElement.DayTypeDistributions, randomDemand, newsDayType))
                    {
                        demand = demandElement.Demand;
                    }
                }
               
                decimal salesProfit, lostProfit = 0, scrapProfit = 0;
                if (demand > simulationSystem.NumOfNewspapers)
                {
                    salesProfit = simulationSystem.SellingPrice * simulationSystem.NumOfNewspapers;
                    lostProfit = (demand - simulationSystem.NumOfNewspapers) * (simulationSystem.SellingPrice - simulationSystem.PurchasePrice);
                    lostProfitCounter++;
                    totalLostProfit += lostProfit;
                }
                else if (demand < simulationSystem.NumOfNewspapers)
                {
                    salesProfit = simulationSystem.SellingPrice * demand;
                    scrapProfit = (simulationSystem.NumOfNewspapers - demand) * simulationSystem.ScrapPrice;
                    scrapProfitCounter++;
                    totalScrapProfit += scrapProfit;
                }
                else
                {
                    salesProfit = simulationSystem.SellingPrice * demand;
                }
                totalSalesProfit += salesProfit;
                decimal dailyNetProfit = salesProfit - dailyCost - lostProfit + scrapProfit;

                //Assigning the calculated values to the simulation table
                SimulationCase simulationCase = new SimulationCase();
                simulationCase.DayNo = i+1;
                simulationCase.RandomNewsDayType = randomDayType;
                simulationCase.NewsDayType = newsDayType;
                simulationCase.RandomDemand = randomDemand;
                simulationCase.Demand = demand;
                simulationCase.DailyCost = dailyCost;
                simulationCase.SalesProfit = salesProfit;
                simulationCase.LostProfit = lostProfit;
                simulationCase.ScrapProfit = scrapProfit;
                simulationCase.DailyNetProfit = dailyNetProfit;

                simulationSystem.SimulationTable.Add(simulationCase);

            }

            totalNetProfit = totalSalesProfit - totalCost - totalLostProfit + totalScrapProfit;

            //Assigning the calculated performance Mesures
            simulationSystem.PerformanceMeasures.TotalSalesProfit = totalSalesProfit;
            simulationSystem.PerformanceMeasures.TotalCost = totalCost;
            simulationSystem.PerformanceMeasures.TotalLostProfit = totalLostProfit;
            simulationSystem.PerformanceMeasures.TotalScrapProfit = totalScrapProfit;
            simulationSystem.PerformanceMeasures.TotalNetProfit = totalNetProfit;
            simulationSystem.PerformanceMeasures.DaysWithMoreDemand = lostProfitCounter;
            simulationSystem.PerformanceMeasures.DaysWithUnsoldPapers = scrapProfitCounter;

            return simulationSystem;
        }

        #region Helper Functions
        //Calculate Ranges for each DayType
        public void DayTypeRangesCalcualtion(List<DayTypeDistribution> dayTypeDistributions)
        {
            decimal cummilative = 1;
            for (int i = 0; i < dayTypeDistributions.Count; i++)
            {
                decimal probability = dayTypeDistributions[i].Probability;

                if (i == 0)
                {
                    dayTypeDistributions[i].CummProbability = probability;
                    cummilative = dayTypeDistributions[i].CummProbability;
                    dayTypeDistributions[i].MinRange = 1;
                    dayTypeDistributions[i].MaxRange = (int)(cummilative * 100);
                }

                else
                {
                    dayTypeDistributions[i].MinRange = (int)((cummilative * 100) + 1);
                    dayTypeDistributions[i].CummProbability = cummilative + probability;
                    cummilative = dayTypeDistributions[i].CummProbability;
                    dayTypeDistributions[i].MaxRange = (int)(cummilative * 100);
                }
                if (probability == 0)
                {
                    dayTypeDistributions[i].MinRange = 0;
                    dayTypeDistributions[i].MaxRange = 0;
                }
            }

        }

        //For each demand calculate Ranges for each day of the 3 DayTypes 
        public void DemandsRangesCalcualtion(List<DemandDistribution> demandDistributions)
        {
            List<decimal> cummilative = new List<decimal>()
            {
                1,
                1,
                1
            };
            for (int i = 0; i < demandDistributions.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    decimal probability = demandDistributions[i].DayTypeDistributions[j].Probability;

                    if (i == 0)
                    {
                        demandDistributions[i].DayTypeDistributions[j].CummProbability = probability;
                        cummilative[j] = demandDistributions[i].DayTypeDistributions[j].CummProbability;
                        demandDistributions[i].DayTypeDistributions[j].MinRange = 1;
                        demandDistributions[i].DayTypeDistributions[j].MaxRange = (int)(cummilative[j] * 100);
                    }

                    else
                    {
                        demandDistributions[i].DayTypeDistributions[j].MinRange = (int)((cummilative[j] * 100) + 1);
                        demandDistributions[i].DayTypeDistributions[j].CummProbability = cummilative[j] + probability;
                        cummilative[j] = demandDistributions[i].DayTypeDistributions[j].CummProbability;
                        demandDistributions[i].DayTypeDistributions[j].MaxRange = (int)(cummilative[j] * 100);
                    }
                    if (probability == 0)
                    {
                        demandDistributions[i].DayTypeDistributions[j].MinRange = 0;
                        demandDistributions[i].DayTypeDistributions[j].MaxRange = 0;
                    }
                }
            }

        }
        //Function to map DayType ranges
        public Enums.DayType MapDayTypeRanges(List<DayTypeDistribution> dayTypeDistributions, int num)
        {

            for (int i = 0; i < dayTypeDistributions.Count(); i++)
            {
                if (num >= dayTypeDistributions[i].MinRange && num <= dayTypeDistributions[i].MaxRange)
                {
                    return dayTypeDistributions[i].DayType;
                }
            }
            return Enums.DayType.Poor;
        }

        //Function to map Demand ranges based on DayType
        //Check the list of each demand => checks day type and its ranges
        public bool MapDemandRanges(List<DayTypeDistribution> dayTypeDistributions, int num, Enums.DayType dayType)
        {

            for (int i = 0; i < dayTypeDistributions.Count(); i++)
            {
                if (dayTypeDistributions[i].DayType == dayType && num >= dayTypeDistributions[i].MinRange && num <= dayTypeDistributions[i].MaxRange)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
