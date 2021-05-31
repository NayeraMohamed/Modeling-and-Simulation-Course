namespace InventorySimulation
{
    partial class Form1
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
            this.choose_pnl = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.testCaseNo_lbl = new System.Windows.Forms.Label();
            this.testCase_cbx = new System.Windows.Forms.ComboBox();
            this.read_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.readingFiles_pnl = new System.Windows.Forms.Panel();
            this.genSimTable_btn = new System.Windows.Forms.Button();
            this.file_dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simTable_pnl = new System.Windows.Forms.Panel();
            this.perfMeasure_btn = new System.Windows.Forms.Button();
            this.simTable_dgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choose_pnl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.readingFiles_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.file_dgv)).BeginInit();
            this.simTable_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simTable_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // choose_pnl
            // 
            this.choose_pnl.Controls.Add(this.groupBox1);
            this.choose_pnl.Controls.Add(this.read_btn);
            this.choose_pnl.Location = new System.Drawing.Point(166, 201);
            this.choose_pnl.Name = "choose_pnl";
            this.choose_pnl.Size = new System.Drawing.Size(584, 262);
            this.choose_pnl.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.testCaseNo_lbl);
            this.groupBox1.Controls.Add(this.testCase_cbx);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(81, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 109);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Test Case :";
            // 
            // testCaseNo_lbl
            // 
            this.testCaseNo_lbl.AutoSize = true;
            this.testCaseNo_lbl.BackColor = System.Drawing.Color.Transparent;
            this.testCaseNo_lbl.Font = new System.Drawing.Font("Tahoma", 16F);
            this.testCaseNo_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.testCaseNo_lbl.Location = new System.Drawing.Point(16, 52);
            this.testCaseNo_lbl.Name = "testCaseNo_lbl";
            this.testCaseNo_lbl.Size = new System.Drawing.Size(156, 27);
            this.testCaseNo_lbl.TabIndex = 4;
            this.testCaseNo_lbl.Text = "Test Case No. ";
            // 
            // testCase_cbx
            // 
            this.testCase_cbx.FormattingEnabled = true;
            this.testCase_cbx.Location = new System.Drawing.Point(178, 55);
            this.testCase_cbx.Name = "testCase_cbx";
            this.testCase_cbx.Size = new System.Drawing.Size(123, 24);
            this.testCase_cbx.TabIndex = 3;
            // 
            // read_btn
            // 
            this.read_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.read_btn.Font = new System.Drawing.Font("Tahoma", 16F);
            this.read_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.read_btn.Location = new System.Drawing.Point(163, 176);
            this.read_btn.Name = "read_btn";
            this.read_btn.Size = new System.Drawing.Size(239, 45);
            this.read_btn.TabIndex = 2;
            this.read_btn.Text = "Read Data from File";
            this.read_btn.UseVisualStyleBackColor = false;
            this.read_btn.Click += new System.EventHandler(this.read_btn_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26F);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(227, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Inventory Simulation System";
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.Font = new System.Drawing.Font("Tahoma", 22F);
            this.welcome_lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.welcome_lbl.Location = new System.Drawing.Point(30, 37);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(200, 36);
            this.welcome_lbl.TabIndex = 7;
            this.welcome_lbl.Text = "Welcome to : ";
            // 
            // readingFiles_pnl
            // 
            this.readingFiles_pnl.Controls.Add(this.genSimTable_btn);
            this.readingFiles_pnl.Controls.Add(this.file_dgv);
            this.readingFiles_pnl.Location = new System.Drawing.Point(12, 87);
            this.readingFiles_pnl.Name = "readingFiles_pnl";
            this.readingFiles_pnl.Size = new System.Drawing.Size(1095, 449);
            this.readingFiles_pnl.TabIndex = 10;
            // 
            // genSimTable_btn
            // 
            this.genSimTable_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.genSimTable_btn.Font = new System.Drawing.Font("Tahoma", 16F);
            this.genSimTable_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.genSimTable_btn.Location = new System.Drawing.Point(733, 346);
            this.genSimTable_btn.Name = "genSimTable_btn";
            this.genSimTable_btn.Size = new System.Drawing.Size(315, 69);
            this.genSimTable_btn.TabIndex = 3;
            this.genSimTable_btn.Text = "Generate Simulation Table ";
            this.genSimTable_btn.UseVisualStyleBackColor = false;
            this.genSimTable_btn.Click += new System.EventHandler(this.genSimTable_btn_Click);
            // 
            // file_dgv
            // 
            this.file_dgv.AllowUserToDeleteRows = false;
            this.file_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.file_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.file_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.file_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.file_dgv.Location = new System.Drawing.Point(0, 0);
            this.file_dgv.Name = "file_dgv";
            this.file_dgv.ReadOnly = true;
            this.file_dgv.RowHeadersWidth = 60;
            this.file_dgv.Size = new System.Drawing.Size(706, 415);
            this.file_dgv.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Input";
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 58;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Value";
            this.Column2.MinimumWidth = 50;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 58;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 21;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 21;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 21;
            // 
            // simTable_pnl
            // 
            this.simTable_pnl.Controls.Add(this.perfMeasure_btn);
            this.simTable_pnl.Controls.Add(this.simTable_dgv);
            this.simTable_pnl.Location = new System.Drawing.Point(1, 1);
            this.simTable_pnl.Name = "simTable_pnl";
            this.simTable_pnl.Size = new System.Drawing.Size(1103, 535);
            this.simTable_pnl.TabIndex = 11;
            // 
            // perfMeasure_btn
            // 
            this.perfMeasure_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.perfMeasure_btn.Font = new System.Drawing.Font("Tahoma", 16F);
            this.perfMeasure_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.perfMeasure_btn.Location = new System.Drawing.Point(332, 456);
            this.perfMeasure_btn.Name = "perfMeasure_btn";
            this.perfMeasure_btn.Size = new System.Drawing.Size(385, 64);
            this.perfMeasure_btn.TabIndex = 3;
            this.perfMeasure_btn.Text = "Performance Measurement ";
            this.perfMeasure_btn.UseVisualStyleBackColor = false;
            this.perfMeasure_btn.Click += new System.EventHandler(this.perfMeasure_btn_Click);
            // 
            // simTable_dgv
            // 
            this.simTable_dgv.AllowUserToDeleteRows = false;
            this.simTable_dgv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simTable_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.simTable_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.simTable_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.simTable_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column6,
            this.Column12});
            this.simTable_dgv.Location = new System.Drawing.Point(14, 10);
            this.simTable_dgv.Name = "simTable_dgv";
            this.simTable_dgv.RowHeadersWidth = 60;
            this.simTable_dgv.Size = new System.Drawing.Size(1082, 434);
            this.simTable_dgv.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "Day";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 51;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.HeaderText = "Cycle";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 58;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.HeaderText = "Day within Cycle";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 102;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.HeaderText = "Beginning Inventory";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 118;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.HeaderText = "Random Digits for Demand";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 110;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Demand";
            this.Column7.Name = "Column7";
            this.Column7.Width = 71;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Ending Inventory";
            this.Column8.Name = "Column8";
            this.Column8.Width = 105;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "Shortage Quantity";
            this.Column9.Name = "Column9";
            this.Column9.Width = 111;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "Order Quantity";
            this.Column10.Name = "Column10";
            this.Column10.Width = 96;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column11.HeaderText = "Random Digits for Lead-Time";
            this.Column11.Name = "Column11";
            this.Column11.Width = 110;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Lead-Time(Days)";
            this.Column6.Name = "Column6";
            this.Column6.Width = 113;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column12.HeaderText = "Days Until Order Arrives";
            this.Column12.Name = "Column12";
            this.Column12.Width = 105;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 542);
            this.Controls.Add(this.simTable_pnl);
            this.Controls.Add(this.readingFiles_pnl);
            this.Controls.Add(this.choose_pnl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcome_lbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.choose_pnl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.readingFiles_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.file_dgv)).EndInit();
            this.simTable_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.simTable_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel choose_pnl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label testCaseNo_lbl;
        private System.Windows.Forms.ComboBox testCase_cbx;
        private System.Windows.Forms.Button read_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcome_lbl;
        private System.Windows.Forms.Panel readingFiles_pnl;
        private System.Windows.Forms.Button genSimTable_btn;
        private System.Windows.Forms.DataGridView file_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel simTable_pnl;
        private System.Windows.Forms.Button perfMeasure_btn;
        private System.Windows.Forms.DataGridView simTable_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}

