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
    public partial class HomePage : Form
    {
        MultiQueueModels.SimulationSystem system;
        public HomePage(MultiQueueModels.SimulationSystem s)
        {
            InitializeComponent();
            system = s;


        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void Table_btn_Click(object sender, EventArgs e)
        {
            SimulationTable ST = new SimulationTable(system);
            ST.Show();

        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void preformance_btn_Click(object sender, EventArgs e)
        {
            SimulationPreformance SP = new SimulationPreformance(system);
            SP.Show();
        }

        private void graphs_btn_Click(object sender, EventArgs e)
        {
            ServerGraph SG = new ServerGraph(system);
            SG.Show();
        }

        private void serversPreformance_btn_Click(object sender, EventArgs e)
        {
            ServerPreformance SP = new ServerPreformance(system);
            SP.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
