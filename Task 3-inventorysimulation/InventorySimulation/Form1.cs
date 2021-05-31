using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryModels;
using InventoryTesting;

namespace InventorySimulation
{
    public partial class Form1 : Form
    {

        SimulationSystem simulationSystem;


        public Form1(SimulationSystem simSystem)
        {

            InitializeComponent();
            simulationSystem = simSystem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readingFiles_pnl.Hide();
            simTable_pnl.Hide();
            choose_pnl.Show();

            testCase_cbx.Items.Add("1");
        
        }
        
        private void read_btn_Click(object sender, EventArgs e)
        {
            choose_pnl.Hide();
            readingFiles_pnl.Show();
            simTable_pnl.Hide();


            // filling  DataGridView with file content : 
            DataGridViewRow row = (DataGridViewRow)file_dgv.Rows[file_dgv.Rows.Count - 1].Clone();
            row.Cells[0].Value = " Order UpTo";
            row.Cells[1].Value = simulationSystem.OrderUpTo;
            file_dgv.Rows.Add(row);

            row = (DataGridViewRow)file_dgv.Rows[file_dgv.Rows.Count - 1].Clone();
            row.Cells[0].Value = " Review Period ";
            row.Cells[1].Value = simulationSystem.ReviewPeriod;
            file_dgv.Rows.Add(row);

            row = (DataGridViewRow)file_dgv.Rows[file_dgv.Rows.Count - 1].Clone();
            row.Cells[0].Value = "Start Inventory Quantitye ";
            row.Cells[1].Value = simulationSystem.StartInventoryQuantity;
            file_dgv.Rows.Add(row);

            row = (DataGridViewRow)file_dgv.Rows[file_dgv.Rows.Count - 1].Clone();
            row.Cells[0].Value = " Start Lead-Days ";
            row.Cells[1].Value = simulationSystem.StartLeadDays;
            file_dgv.Rows.Add(row);

            row = (DataGridViewRow)file_dgv.Rows[file_dgv.Rows.Count - 1].Clone();
            row.Cells[0].Value = " Start Order Quantity";
            row.Cells[1].Value = simulationSystem.StartOrderQuantity;
            file_dgv.Rows.Add(row);

            row = (DataGridViewRow)file_dgv.Rows[file_dgv.Rows.Count - 1].Clone();
            row.Cells[0].Value = " Number Of Days";
            row.Cells[1].Value = simulationSystem.NumberOfDays;
            file_dgv.Rows.Add(row);
            

            //********************************************************************
            row = (DataGridViewRow)file_dgv.Rows[file_dgv.Rows.Count - 1].Clone();
            file_dgv.Rows.Add(row);

            //Header : 
            row = (DataGridViewRow)file_dgv.Rows[file_dgv.Rows.Count - 1].Clone();
            row.Cells[0].Value = " Demand Distribution";
            row.Cells[1].Value = " Demand ";
            row.Cells[2].Value = " Probability ";
           
            file_dgv.Rows.Add(row);

            //Data 

            for (int i = 0; i < simulationSystem.DemandDistribution.Count; i++)
            {
                row = (DataGridViewRow)file_dgv.Rows[file_dgv.Rows.Count - 1].Clone();
                row.Cells[1].Value = simulationSystem.DemandDistribution[i].Value;
                row.Cells[2].Value = simulationSystem.DemandDistribution[i].Probability;
               
                file_dgv.Rows.Add(row);
            }
            
           

            //**********************************************************************
            row = (DataGridViewRow)file_dgv.Rows[file_dgv.Rows.Count - 1].Clone();
            file_dgv.Rows.Add(row);
            //Header
            row = (DataGridViewRow)file_dgv.Rows[file_dgv.Rows.Count - 1].Clone();
            row.Cells[0].Value = " Lead-Days Distribution";
            row.Cells[1].Value = " Day";
            row.Cells[2].Value = " Probability ";
            file_dgv.Rows.Add(row);

            

            // Data
            
            for (int i = 0; i < simulationSystem.LeadDaysDistribution.Count; i++)
            {
                row = (DataGridViewRow)file_dgv.Rows[file_dgv.Rows.Count - 1].Clone();
                row.Cells[1].Value = simulationSystem.LeadDaysDistribution[i].Value;
                row.Cells[2].Value = simulationSystem.LeadDaysDistribution[i].Probability;
                file_dgv.Rows.Add(row);
            }
           
        }

        private void genSimTable_btn_Click(object sender, EventArgs e)
        {


            choose_pnl.Hide();
            readingFiles_pnl.Hide();
            simTable_pnl.Show();


            // filling  DataGridView with file content :
            DataGridViewRow row;
            for (int j = 0; j < simulationSystem.SimulationCases.Count; j++)
            {

                row = (DataGridViewRow)simTable_dgv.Rows[j].Clone();
                row.Cells[0].Value = simulationSystem.SimulationCases[j].Day;
                row.Cells[1].Value = simulationSystem.SimulationCases[j].Cycle;
                row.Cells[2].Value = simulationSystem.SimulationCases[j].DayWithinCycle;
                row.Cells[3].Value = simulationSystem.SimulationCases[j].BeginningInventory;

                row.Cells[4].Value = simulationSystem.SimulationCases[j].RandomDemand;
                row.Cells[5].Value = simulationSystem.SimulationCases[j].Demand;
                row.Cells[6].Value = simulationSystem.SimulationCases[j].EndingInventory;
                row.Cells[7].Value = simulationSystem.SimulationCases[j].ShortageQuantity;
                row.Cells[8].Value = simulationSystem.SimulationCases[j].OrderQuantity;
                row.Cells[9].Value = simulationSystem.SimulationCases[j].RandomLeadDays;
                row.Cells[10].Value = simulationSystem.SimulationCases[j].LeadDays;
                row.Cells[11].Value = simulationSystem.SimulationCases[j].DaysUntilOrderArrive;

                simTable_dgv.Rows.Add(row);
            }



        }


        private void perfMeasure_btn_Click(object sender, EventArgs e)
        {

            // Empty Row 
            DataGridViewRow row = (DataGridViewRow)simTable_dgv.Rows[simTable_dgv.Rows.Count - 1].Clone();
            simTable_dgv.Rows.Add(row);

            /*
            //Total Row : 
            row = (DataGridViewRow)simTable_dgv.Rows[simTable_dgv.Rows.Count - 1].Clone();
            row.Cells[0].Value = "Total";
            
         
           
            simTable_dgv.Rows.Add(row);
            row.DefaultCellStyle.BackColor = Color.Bisque;
            row.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
            */
            //Avg. row
            row = (DataGridViewRow)simTable_dgv.Rows[simTable_dgv.Rows.Count - 1].Clone();
            row.Cells[0].Value = " Average ";
            row.Cells[6].Value = simulationSystem.PerformanceMeasures.EndingInventoryAverage;
            row.Cells[7].Value = simulationSystem.PerformanceMeasures.ShortageQuantityAverage;
            simTable_dgv.Rows.Add(row);
            row.DefaultCellStyle.BackColor = Color.Beige;
            row.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);

         
        }

       
       
    }
}
