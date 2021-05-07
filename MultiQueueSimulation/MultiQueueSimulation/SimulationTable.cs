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
    public partial class SimulationTable : Form
    {
        public SimulationTable(MultiQueueModels.SimulationSystem s)
        {
            InitializeComponent();
            for(int i=0; i < s.SimulationTable.Count(); i++) {
                simulationGrid.Rows.Add(s.SimulationTable[i].CustomerNumber, s.SimulationTable[i].RandomInterArrival, s.SimulationTable[i].InterArrival, s.SimulationTable[i].ArrivalTime, s.SimulationTable[i].RandomService,
                    s.SimulationTable[i].ServiceTime,s.SimulationTable[i].AssignedServer.ID,s.SimulationTable[i].StartTime, s.SimulationTable[i].EndTime, s.SimulationTable[i].TimeInQueue);
            }
            
        }

        private void simulationGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SimulationTable_Load(object sender, EventArgs e)
        {

        }
    }
}
