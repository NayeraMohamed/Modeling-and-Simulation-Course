namespace MultiQueueSimulation
{
    partial class SimulationPreformance
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.averageWaitingTime_tb = new System.Windows.Forms.TextBox();
            this.maxQlen_tb = new System.Windows.Forms.TextBox();
            this.waitingProbability_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comment_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average Waiting Time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maximum Queue Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Waiting Probability";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // averageWaitingTime_tb
            // 
            this.averageWaitingTime_tb.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageWaitingTime_tb.Location = new System.Drawing.Point(483, 89);
            this.averageWaitingTime_tb.Name = "averageWaitingTime_tb";
            this.averageWaitingTime_tb.ReadOnly = true;
            this.averageWaitingTime_tb.Size = new System.Drawing.Size(292, 34);
            this.averageWaitingTime_tb.TabIndex = 3;
            // 
            // maxQlen_tb
            // 
            this.maxQlen_tb.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxQlen_tb.Location = new System.Drawing.Point(483, 158);
            this.maxQlen_tb.Name = "maxQlen_tb";
            this.maxQlen_tb.ReadOnly = true;
            this.maxQlen_tb.Size = new System.Drawing.Size(292, 34);
            this.maxQlen_tb.TabIndex = 4;
            // 
            // waitingProbability_tb
            // 
            this.waitingProbability_tb.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingProbability_tb.Location = new System.Drawing.Point(483, 226);
            this.waitingProbability_tb.Name = "waitingProbability_tb";
            this.waitingProbability_tb.ReadOnly = true;
            this.waitingProbability_tb.Size = new System.Drawing.Size(292, 34);
            this.waitingProbability_tb.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preformance Measures";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Comment";
            // 
            // comment_tb
            // 
            this.comment_tb.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comment_tb.Location = new System.Drawing.Point(150, 352);
            this.comment_tb.Name = "comment_tb";
            this.comment_tb.ReadOnly = true;
            this.comment_tb.Size = new System.Drawing.Size(713, 34);
            this.comment_tb.TabIndex = 8;
            // 
            // SimulationPreformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 402);
            this.Controls.Add(this.comment_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.waitingProbability_tb);
            this.Controls.Add(this.maxQlen_tb);
            this.Controls.Add(this.averageWaitingTime_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SimulationPreformance";
            this.Text = "SimulationPreformance";
            this.Load += new System.EventHandler(this.SimulationPreformance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox averageWaitingTime_tb;
        private System.Windows.Forms.TextBox maxQlen_tb;
        private System.Windows.Forms.TextBox waitingProbability_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox comment_tb;
    }
}