using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryModels
{
    public class Calculations
    {
        public Calculations(SimulationSystem simulationSystem)
        {
            this.simulationSystem = simulationSystem;
        }
        SimulationSystem simulationSystem;

        //Main Function
        public SimulationSystem calculate()
        {
            Random random = new Random();
            DemandRangesCalcualtion(simulationSystem.DemandDistribution);
            LeadDaysRangesCalcualtion(simulationSystem.LeadDaysDistribution);

            //Declaring global Variables
            int dayWithinCycle = 1, cycle = 1, 
                startQuantity = simulationSystem.StartInventoryQuantity, 
                daysUntilOrderArrive = simulationSystem.StartLeadDays - 1,
                orderQuantityArr = simulationSystem.StartOrderQuantity,
                prevShortage=0;
            decimal totalEndingInventory = 0, totalShortage = 0;
            bool orderJustArrived = false, toDecrease = true;

            for (int i = 0; i < simulationSystem.NumberOfDays; i++)
            {
                //int beginningQuantity = startQuantity;

                //Generating random number for Demand and mapping it
                int randomDemand = random.Next(1, 100);
                int demandNumber = MapDemandRanges(simulationSystem.DemandDistribution, randomDemand);


                int endingQuantity = startQuantity - demandNumber;
                if (orderJustArrived)
                {
                    endingQuantity -= prevShortage;
                    orderJustArrived = false;
                    prevShortage = 0;
                }

                //int shortage = 0;
                if (endingQuantity < 0)
                {
                    endingQuantity = 0;
                    //shortage = demandNumber - startQuantity;
                    prevShortage += demandNumber - startQuantity;
                }
                //Accumalting Total for Performance Mesures
                totalEndingInventory += endingQuantity;
                totalShortage += prevShortage;

                int orderQuantity = 0, randomLead = 0, leadDayValue = 0;

                //if it's day of ordering
                if(dayWithinCycle == 5)
                {
                    //Generating Random number for Lead Days and mapping it
                    randomLead = random.Next(1, 100);
                    leadDayValue = MapDemandRanges(simulationSystem.LeadDaysDistribution, randomLead);
                    daysUntilOrderArrive = leadDayValue;
                     
                    //calculate the next qty
                    orderQuantity = simulationSystem.OrderUpTo - endingQuantity + prevShortage;
                    orderQuantityArr = orderQuantity;
                    toDecrease = true;
                }
                

                //Assigning the calculated values to the simulation table
                SimulationCase simulationCase = new SimulationCase();
                simulationCase.Day = i + 1;
                simulationCase.Cycle = cycle;
                simulationCase.DayWithinCycle = dayWithinCycle;
                simulationCase.BeginningInventory = startQuantity;
                simulationCase.RandomDemand = randomDemand;
                simulationCase.Demand = demandNumber;
                simulationCase.EndingInventory = endingQuantity;
                simulationCase.ShortageQuantity = prevShortage;
                simulationCase.RandomLeadDays = randomLead;
                simulationCase.LeadDays = leadDayValue ;
                simulationCase.OrderQuantity = orderQuantity;

                simulationSystem.SimulationCases.Add(simulationCase);

                startQuantity = endingQuantity;
                if(daysUntilOrderArrive == 0 && toDecrease)
                {
                    startQuantity += orderQuantityArr;
                    orderJustArrived = true;
                    toDecrease = false;
                }

                if(toDecrease)
                {
                    daysUntilOrderArrive--;
                }
                
                if (dayWithinCycle == 5)
                {
                    cycle++;
                    dayWithinCycle = 1;
                }
                else
                {
                    dayWithinCycle++;
                }
                 
            }

            //Performance Mesures Calculations
            decimal endingInvAvg = totalEndingInventory / simulationSystem.NumberOfDays;
            decimal shortageQuantityAvg = totalShortage / simulationSystem.NumberOfDays;

            //Assigning the calculated performance Mesures
            simulationSystem.PerformanceMeasures.EndingInventoryAverage = endingInvAvg;
            simulationSystem.PerformanceMeasures.ShortageQuantityAverage = shortageQuantityAvg;
            

            return simulationSystem;
        }


        #region Helper Functions
        //Calculate Ranges for Demand
        public void DemandRangesCalcualtion(List<Distribution> demandDistribution)
        {
            decimal cummilative = 1;
            for (int i = 0; i < demandDistribution.Count; i++)
            {
                decimal probability = demandDistribution[i].Probability;

                if (i == 0)
                {
                    demandDistribution[i].CummProbability = probability;
                    cummilative = demandDistribution[i].CummProbability;
                    demandDistribution[i].MinRange = 1;
                    demandDistribution[i].MaxRange = (int)(cummilative * 100);
                }

                else
                {
                    demandDistribution[i].MinRange = (int)((cummilative * 100) + 1);
                    demandDistribution[i].CummProbability = cummilative + probability;
                    cummilative = demandDistribution[i].CummProbability;
                    demandDistribution[i].MaxRange = (int)(cummilative * 100);
                }
                if (probability == 0)
                {
                    demandDistribution[i].MinRange = 0;
                    demandDistribution[i].MaxRange = 0;
                }
            }
        }
        //Calculate Ranges for LeadDays
        public void LeadDaysRangesCalcualtion(List<Distribution> leadDaysDistribution)
        {
            decimal cummilative = 1;
            for (int i = 0; i < leadDaysDistribution.Count; i++)
            {
                decimal probability = leadDaysDistribution[i].Probability;

                if (i == 0)
                {
                    leadDaysDistribution[i].CummProbability = probability;
                    cummilative = leadDaysDistribution[i].CummProbability;
                    leadDaysDistribution[i].MinRange = 1;
                    leadDaysDistribution[i].MaxRange = (int)(cummilative * 100);
                }

                else
                {
                    leadDaysDistribution[i].MinRange = (int)((cummilative * 100) + 1);
                    leadDaysDistribution[i].CummProbability = cummilative + probability;
                    cummilative = leadDaysDistribution[i].CummProbability;
                    leadDaysDistribution[i].MaxRange = (int)(cummilative * 100);
                }
                if (probability == 0)
                {
                    leadDaysDistribution[i].MinRange = 0;
                    leadDaysDistribution[i].MaxRange = 0;
                }
            }
        }

        //Function to map demand ranges
        public int MapDemandRanges(List<Distribution> demandDistributions, int num)
        {

            for (int i = 0; i < demandDistributions.Count(); i++)
            {
                if (num >= demandDistributions[i].MinRange && num <= demandDistributions[i].MaxRange)
                {
                    return demandDistributions[i].Value;
                }
            }
            return -1;
        }
        //Function to map Lead Days ranges
        public int MapLeadDaysRanges(List<Distribution> leadDaysDistribution, int num)
        {

            for (int i = 0; i < leadDaysDistribution.Count(); i++)
            {
                if (num >= leadDaysDistribution[i].MinRange && num <= leadDaysDistribution[i].MaxRange)
                {
                    return leadDaysDistribution[i].Value;
                }
            }
            return -1;
        }
        #endregion
    }
}
