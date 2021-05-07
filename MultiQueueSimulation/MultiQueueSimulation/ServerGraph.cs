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
    public partial class ServerGraph : Form
    {
        MultiQueueModels.SimulationSystem system;
        public ServerGraph(MultiQueueModels.SimulationSystem s)
        {
            system = s;
            InitializeComponent();
            for (int i = 0; i < system.NumberOfServers; i++)
            {
                serversIds_cbx.Items.Add((system.Servers[i].ID).ToString());
            }
           
        }

        private void ServerGraph_Load(object sender, EventArgs e)
        {

        }

        private void server_chart_Click(object sender, EventArgs e)
        {

        }

        private void select_btn_Click(object sender, EventArgs e)
        {
       
            server_chart.ChartAreas[0].AxisX.Minimum = 0;
            server_chart.ChartAreas[0].AxisY.Maximum = 1;
            server_chart.ChartAreas[0].AxisX.Title = "Time";
            server_chart.ChartAreas[0].AxisY.Title = "Busy[t]";

            int selectedId = Int32.Parse((serversIds_cbx.SelectedItem).ToString());
            
                    for (int j = 0; j < system.SimulationTable.Count; j++)
                    {
                        
                        if (system.SimulationTable[j].AssignedServer.ID== selectedId)
                        {
                            for (int i = system.SimulationTable[j].StartTime; i < system.SimulationTable[j].EndTime; i++)
                            {
                                server_chart.Series["BusyTime"].Points.AddXY(i, 1);
                            }
                        }
                        
                    }
   
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            server_chart.Series["BusyTime"].Points.Clear();
        }
    }
}
