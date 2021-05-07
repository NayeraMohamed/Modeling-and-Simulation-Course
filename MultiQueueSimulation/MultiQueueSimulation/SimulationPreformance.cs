using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiQueueSimulation
{
    public partial class SimulationPreformance : Form
    {
        public SimulationPreformance(MultiQueueModels.SimulationSystem s)
        {
            InitializeComponent();
            this.averageWaitingTime_tb.Text = (s.PerformanceMeasures.AverageWaitingTime).ToString();
            this.maxQlen_tb.Text = (s.PerformanceMeasures.MaxQueueLength).ToString();
            this.waitingProbability_tb.Text = (s.PerformanceMeasures.WaitingProbability).ToString();
            //this.comment_tb.Text= .ToString()
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SimulationPreformance_Load(object sender, EventArgs e)
        {

        }
    }
}
