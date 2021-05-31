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
            //Calculating cumalitive probability, MinRange and MaxRange for Demand and Lead Days
            RangesCalcualtion(simulationSystem.DemandDistribution);
            RangesCalcualtion(simulationSystem.LeadDaysDistribution);

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
              

                //Generating random number for Demand and mapping it
                int randomDemand = random.Next(1, 100);
                int demandNumber = MapRanges(simulationSystem.DemandDistribution, randomDemand);


                int endingQuantity = startQuantity - demandNumber;
                if (orderJustArrived)
                {
                    endingQuantity -= prevShortage;
                    orderJustArrived = false;
                    prevShortage = 0;
                }

              
                if (endingQuantity < 0)
                {
                    endingQuantity = 0;
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
                    leadDayValue = MapRanges(simulationSystem.LeadDaysDistribution, randomLead);
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
                simulationCase.DaysUntilOrderArrive = daysUntilOrderArrive;

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
        //Calculate Ranges for Demand and Lead Days
        public void RangesCalcualtion(List<Distribution> distribution)
        {
            decimal cummilative = 1;
            for (int i = 0; i < distribution.Count; i++)
            {
                decimal probability = distribution[i].Probability;

                if (i == 0)
                {
                    distribution[i].CummProbability = probability;
                    cummilative = distribution[i].CummProbability;
                    distribution[i].MinRange = 1;
                    distribution[i].MaxRange = (int)(cummilative * 100);
                }

                else
                {
                    distribution[i].MinRange = (int)((cummilative * 100) + 1);
                    distribution[i].CummProbability = cummilative + probability;
                    cummilative = distribution[i].CummProbability;
                    distribution[i].MaxRange = (int)(cummilative * 100);
                }
                if (probability == 0)
                {
                    distribution[i].MinRange = 0;
                    distribution[i].MaxRange = 0;
                }
            }
        }

        //Function to map Demand ranges and Lead Days ranges
        public int MapRanges(List<Distribution> distributions, int num)
        {

            for (int i = 0; i < distributions.Count(); i++)
            {
                if (num >= distributions[i].MinRange && num <= distributions[i].MaxRange)
                {
                    return distributions[i].Value;
                }
            }
            return -1;
        }
        #endregion
    }
}
