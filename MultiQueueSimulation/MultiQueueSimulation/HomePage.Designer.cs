namespace MultiQueueSimulation
{
    partial class HomePage
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
            this.preformance_btn = new System.Windows.Forms.Button();
            this.graphs_btn = new System.Windows.Forms.Button();
            this.serversPreformance_btn = new System.Windows.Forms.Button();
            this.Table_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // preformance_btn
            // 
            this.preformance_btn.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preformance_btn.Location = new System.Drawing.Point(249, 174);
            this.preformance_btn.Name = "preformance_btn";
            this.preformance_btn.Size = new System.Drawing.Size(423, 43);
            this.preformance_btn.TabIndex = 0;
            this.preformance_btn.Text = "Simulation Preformance";
            this.preformance_btn.UseVisualStyleBackColor = true;
            this.preformance_btn.Click += new System.EventHandler(this.preformance_btn_Click);
            // 
            // graphs_btn
            // 
            this.graphs_btn.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphs_btn.Location = new System.Drawing.Point(249, 264);
            this.graphs_btn.Name = "graphs_btn";
            this.graphs_btn.Size = new System.Drawing.Size(423, 43);
            this.graphs_btn.TabIndex = 1;
            this.graphs_btn.Text = "Servers Graphs";
            this.graphs_btn.UseVisualStyleBackColor = true;
            this.graphs_btn.Click += new System.EventHandler(this.graphs_btn_Click);
            // 
            // serversPreformance_btn
            // 
            this.serversPreformance_btn.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serversPreformance_btn.Location = new System.Drawing.Point(249, 347);
            this.serversPreformance_btn.Name = "serversPreformance_btn";
            this.serversPreformance_btn.Size = new System.Drawing.Size(423, 43);
            this.serversPreformance_btn.TabIndex = 2;
            this.serversPreformance_btn.Text = "Servers Preformance";
            this.serversPreformance_btn.UseVisualStyleBackColor = true;
            this.serversPreformance_btn.Click += new System.EventHandler(this.serversPreformance_btn_Click);
            // 
            // Table_btn
            // 
            this.Table_btn.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Table_btn.Location = new System.Drawing.Point(249, 86);
            this.Table_btn.Name = "Table_btn";
            this.Table_btn.Size = new System.Drawing.Size(423, 43);
            this.Table_btn.TabIndex = 3;
            this.Table_btn.Text = "Simulation Table";
            this.Table_btn.UseVisualStyleBackColor = true;
            this.Table_btn.Click += new System.EventHandler(this.Table_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Multi Queue Simulation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Table_btn);
            this.Controls.Add(this.serversPreformance_btn);
            this.Controls.Add(this.graphs_btn);
            this.Controls.Add(this.preformance_btn);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button preformance_btn;
        private System.Windows.Forms.Button graphs_btn;
        private System.Windows.Forms.Button serversPreformance_btn;
        private System.Windows.Forms.Button Table_btn;
        private System.Windows.Forms.Label label1;
    }
}