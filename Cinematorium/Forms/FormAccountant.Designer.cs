namespace Cinematorium.Forms
{
    partial class FormAccountant
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
            this.txnameandsurname = new System.Windows.Forms.TextBox();
            this.chbIsWorking = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.dtpStartWorkDate = new System.Windows.Forms.DateTimePicker();
            this.cmbMovies = new System.Windows.Forms.ComboBox();
            this.dgvAccountant = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuTotalGain = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTotalCounter = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanMaaşlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountant)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txnameandsurname
            // 
            this.txnameandsurname.Location = new System.Drawing.Point(490, 204);
            this.txnameandsurname.Name = "txnameandsurname";
            this.txnameandsurname.Size = new System.Drawing.Size(170, 20);
            this.txnameandsurname.TabIndex = 79;
            // 
            // chbIsWorking
            // 
            this.chbIsWorking.AutoSize = true;
            this.chbIsWorking.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.chbIsWorking.Location = new System.Drawing.Point(490, 325);
            this.chbIsWorking.Name = "chbIsWorking";
            this.chbIsWorking.Size = new System.Drawing.Size(94, 19);
            this.chbIsWorking.TabIndex = 75;
            this.chbIsWorking.Text = "Is Working?";
            this.chbIsWorking.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(486, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 71;
            this.label9.Text = "Salary:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(486, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 70;
            this.label6.Text = "Start Work Date:";
            // 
            // numSalary
            // 
            this.numSalary.DecimalPlaces = 3;
            this.numSalary.Location = new System.Drawing.Point(490, 294);
            this.numSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSalary.Name = "numSalary";
            this.numSalary.Size = new System.Drawing.Size(170, 20);
            this.numSalary.TabIndex = 74;
            // 
            // dtpStartWorkDate
            // 
            this.dtpStartWorkDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartWorkDate.Location = new System.Drawing.Point(490, 249);
            this.dtpStartWorkDate.Name = "dtpStartWorkDate";
            this.dtpStartWorkDate.Size = new System.Drawing.Size(170, 20);
            this.dtpStartWorkDate.TabIndex = 72;
            // 
            // cmbMovies
            // 
            this.cmbMovies.FormattingEnabled = true;
            this.cmbMovies.Location = new System.Drawing.Point(-198, -13);
            this.cmbMovies.Name = "cmbMovies";
            this.cmbMovies.Size = new System.Drawing.Size(179, 21);
            this.cmbMovies.TabIndex = 68;
            // 
            // dgvAccountant
            // 
            this.dgvAccountant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccountant.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvAccountant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountant.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAccountant.Location = new System.Drawing.Point(8, 33);
            this.dgvAccountant.Name = "dgvAccountant";
            this.dgvAccountant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountant.Size = new System.Drawing.Size(461, 369);
            this.dgvAccountant.TabIndex = 67;
            this.dgvAccountant.SelectionChanged += new System.EventHandler(this.dgvAccountant_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuTotalGain,
            this.MnuTotalCounter,
            this.çalışanMaaşlarıToolStripMenuItem,
            this.taxReportToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 66;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuTotalGain
            // 
            this.MnuTotalGain.Image = global::Cinematorium.Properties.Resources.if_total_plan_cost_64896;
            this.MnuTotalGain.Name = "MnuTotalGain";
            this.MnuTotalGain.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MnuTotalGain.Size = new System.Drawing.Size(92, 20);
            this.MnuTotalGain.Text = "Total Gain";
            this.MnuTotalGain.Click += new System.EventHandler(this.MnuTotalGain_Click);
            // 
            // MnuTotalCounter
            // 
            this.MnuTotalCounter.Image = global::Cinematorium.Properties.Resources.if_counter_62799;
            this.MnuTotalCounter.Name = "MnuTotalCounter";
            this.MnuTotalCounter.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MnuTotalCounter.Size = new System.Drawing.Size(111, 20);
            this.MnuTotalCounter.Text = "Total Counter";
            this.MnuTotalCounter.Click += new System.EventHandler(this.MnuTotalCounter_Click);
            // 
            // çalışanMaaşlarıToolStripMenuItem
            // 
            this.çalışanMaaşlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSalaryToolStripMenuItem});
            this.çalışanMaaşlarıToolStripMenuItem.Image = global::Cinematorium.Properties.Resources.if_business_work_2_2377644;
            this.çalışanMaaşlarıToolStripMenuItem.Name = "çalışanMaaşlarıToolStripMenuItem";
            this.çalışanMaaşlarıToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.çalışanMaaşlarıToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.çalışanMaaşlarıToolStripMenuItem.Text = "Salaries";
            this.çalışanMaaşlarıToolStripMenuItem.Click += new System.EventHandler
            // 
            // addSalaryToolStripMenuItem
            // 
            this.addSalaryToolStripMenuItem.Name = "addSalaryToolStripMenuItem";
            this.addSalaryToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.addSalaryToolStripMenuItem.Text = "Add Salary";
            this.addSalaryToolStripMenuItem.Click += new System.EventHandler(this.addSalaryToolStripMenuItem_Click);
            // 
            // taxReportToolStripMenuItem
            // 
            this.taxReportToolStripMenuItem.Image = global::Cinematorium.Properties.Resources.if_13_Tax_1871418;
            this.taxReportToolStripMenuItem.Name = "taxReportToolStripMenuItem";
            this.taxReportToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.taxReportToolStripMenuItem.Text = "Tax Report";
            this.taxReportToolStripMenuItem.Click += new System.EventHandler(this.taxReportToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Image = global::Cinematorium.Properties.Resources.if_home_134213;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(487, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 80;
            this.label1.Text = "To Be Updated";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::Cinematorium.Properties.Resources.if_InterfaceExpendet_01_5926001;
            this.btnRefresh.Location = new System.Drawing.Point(511, 350);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 53);
            this.btnRefresh.TabIndex = 78;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Cinematorium.Properties.Resources.if_business_coins_money_stack_salary_glyph_763193__1_;
            this.panel1.Location = new System.Drawing.Point(500, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 125);
            this.panel1.TabIndex = 77;
            // 
            // FormAccountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(665, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txnameandsurname);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chbIsWorking);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numSalary);
            this.Controls.Add(this.dtpStartWorkDate);
            this.Controls.Add(this.cmbMovies);
            this.Controls.Add(this.dgvAccountant);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormAccountant";
            this.Text = "FormAccountant";
            this.Load += new System.EventHandler(this.FormAccountant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountant)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txnameandsurname;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbIsWorking;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numSalary;
        private System.Windows.Forms.DateTimePicker dtpStartWorkDate;
        private System.Windows.Forms.ComboBox cmbMovies;
        private System.Windows.Forms.DataGridView dgvAccountant;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuTotalGain;
        private System.Windows.Forms.ToolStripMenuItem MnuTotalCounter;
        private System.Windows.Forms.ToolStripMenuItem çalışanMaaşlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSalaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxReportToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}