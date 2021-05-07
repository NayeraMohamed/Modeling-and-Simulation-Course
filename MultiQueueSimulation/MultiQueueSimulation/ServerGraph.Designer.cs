namespace MultiQueueSimulation
{
    partial class ServerGraph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.server_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serversIds_cbx = new System.Windows.Forms.ComboBox();
            this.select_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.server_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // server_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.server_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.server_chart.Legends.Add(legend1);
            this.server_chart.Location = new System.Drawing.Point(194, 12);
            this.server_chart.Name = "server_chart";
            this.server_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "BusyTime";
            this.server_chart.Series.Add(series1);
            this.server_chart.Size = new System.Drawing.Size(710, 383);
            this.server_chart.TabIndex = 0;
            this.server_chart.Text = "chart1";
            title1.Name = "Server Busy Time";
            this.server_chart.Titles.Add(title1);
            this.server_chart.Click += new System.EventHandler(this.server_chart_Click);
            // 
            // serversIds_cbx
            // 
            this.serversIds_cbx.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serversIds_cbx.FormattingEnabled = true;
            this.serversIds_cbx.Location = new System.Drawing.Point(31, 143);
            this.serversIds_cbx.Name = "serversIds_cbx";
            this.serversIds_cbx.Size = new System.Drawing.Size(133, 31);
            this.serversIds_cbx.TabIndex = 1;
            // 
            // select_btn
            // 
            this.select_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_btn.Location = new System.Drawing.Point(46, 278);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(98, 40);
            this.select_btn.TabIndex = 2;
            this.select_btn.Text = "Select";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(46, 338);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(98, 42);
            this.clear_btn.TabIndex = 3;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // ServerGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 402);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.serversIds_cbx);
            this.Controls.Add(this.server_chart);
            this.Name = "ServerGraph";
            this.Text = "ServerGraph";
            this.Load += new System.EventHandler(this.ServerGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.server_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart server_chart;
        private System.Windows.Forms.ComboBox serversIds_cbx;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Button clear_btn;
    }
}