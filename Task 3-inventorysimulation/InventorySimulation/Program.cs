using InventoryModels;
using InventoryTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySimulation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SimulationSystem simulationSystem = new SimulationSystem();
            simulationSystem.ReadFile();

            Calculations calculations = new Calculations(simulationSystem);
            simulationSystem = calculations.calculate();

            string result = TestingManager.Test(simulationSystem, Constants.FileNames.TestCase1); 
            MessageBox.Show(result);
            Application.Run(new Form1(calculations.calculate()));
        }
    }
}
