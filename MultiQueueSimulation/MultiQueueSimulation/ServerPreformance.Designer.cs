namespace MultiQueueSimulation
{
    partial class ServerPreformance
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
            this.serversIds_cbx = new System.Windows.Forms.ComboBox();
            this.select_btn = new System.Windows.Forms.Button();
            this.idle_tb = new System.Windows.Forms.TextBox();
            this.averageService_tb = new System.Windows.Forms.TextBox();
            this.utilization_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idle Probability";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average Service Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Utilization";
            // 
            // serversIds_cbx
            // 
            this.serversIds_cbx.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serversIds_cbx.FormattingEnabled = true;
            this.serversIds_cbx.Location = new System.Drawing.Point(98, 78);
            this.serversIds_cbx.Name = "serversIds_cbx";
            this.serversIds_cbx.Size = new System.Drawing.Size(174, 31);
            this.serversIds_cbx.TabIndex = 3;
            // 
            // select_btn
            // 
            this.select_btn.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_btn.Location = new System.Drawing.Point(129, 210);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(103, 48);
            this.select_btn.TabIndex = 4;
            this.select_btn.Text = "Select";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // idle_tb
            // 
            this.idle_tb.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idle_tb.Location = new System.Drawing.Point(698, 170);
            this.idle_tb.Name = "idle_tb";
            this.idle_tb.ReadOnly = true;
            this.idle_tb.Size = new System.Drawing.Size(157, 34);
            this.idle_tb.TabIndex = 5;
            this.idle_tb.TextChanged += new System.EventHandler(this.idle_tb_TextChanged);
            // 
            // averageService_tb
            // 
            this.averageService_tb.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageService_tb.Location = new System.Drawing.Point(698, 63);
            this.averageService_tb.Name = "averageService_tb";
            this.averageService_tb.ReadOnly = true;
            this.averageService_tb.Size = new System.Drawing.Size(157, 34);
            this.averageService_tb.TabIndex = 6;
            // 
            // utilization_tb
            // 
            this.utilization_tb.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilization_tb.Location = new System.Drawing.Point(698, 281);
            this.utilization_tb.Name = "utilization_tb";
            this.utilization_tb.ReadOnly = true;
            this.utilization_tb.Size = new System.Drawing.Size(157, 34);
            this.utilization_tb.TabIndex = 7;
            this.utilization_tb.TextChanged += new System.EventHandler(this.utilization_tb_TextChanged);
            // 
            // ServerPreformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 402);
            this.Controls.Add(this.utilization_tb);
            this.Controls.Add(this.averageService_tb);
            this.Controls.Add(this.idle_tb);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.serversIds_cbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ServerPreformance";
            this.Text = "ServerPreformance";
            this.Load += new System.EventHandler(this.ServerPreformance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox serversIds_cbx;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.TextBox idle_tb;
        private System.Windows.Forms.TextBox averageService_tb;
        private System.Windows.Forms.TextBox utilization_tb;
    }
}