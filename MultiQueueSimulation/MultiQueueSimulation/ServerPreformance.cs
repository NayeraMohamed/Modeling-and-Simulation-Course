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
    public partial class ServerPreformance : Form
    {
        MultiQueueModels.SimulationSystem system;
        public ServerPreformance(MultiQueueModels.SimulationSystem s)
        {
            system = s;
            InitializeComponent();
            for(int i =0; i < system.NumberOfServers; i++)
            {
                serversIds_cbx.Items.Add((system.Servers[i].ID).ToString());
            }
            
        }

        private void ServerPreformance_Load(object sender, EventArgs e)
        {

        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            int selectedId = Int32.Parse((serversIds_cbx.SelectedItem).ToString());
            for(int i=0; i < system.NumberOfServers; i++)
            {
                if (system.Servers[i].ID == selectedId)
                {
                    idle_tb.Text = (system.Servers[i].IdleProbability).ToString();
                    averageService_tb.Text = (system.Servers[i].AverageServiceTime).ToString();
                    utilization_tb.Text= (system.Servers[i].Utilization).ToString();
                    break;
                }
            }

        }

        private void idle_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void utilization_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
