using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
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
            //maryam btgarb
            NewspaperSellerModels.SimulationSystem s = new NewspaperSellerModels.SimulationSystem();
            s.ReadFile();
            //Application.Run(new Form1());
        }
    }
}
