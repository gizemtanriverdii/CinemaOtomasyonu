namespace Cinematorium.Forms
{
    partial class FormManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnReport1 = new System.Windows.Forms.ToolStripButton();
            this.btnReport3 = new System.Windows.Forms.ToolStripButton();
            this.btnReport2 = new System.Windows.Forms.ToolStripButton();
            this.btnReport4 = new System.Windows.Forms.ToolStripButton();
            this.btnReport5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUserProcesses = new System.Windows.Forms.ToolStripButton();
            this.btnAddSaloon = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.dgvReportTable = new System.Windows.Forms.DataGridView();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReport1,
            this.btnReport3,
            this.btnReport2,
            this.btnReport4,
            this.btnReport5,
            this.toolStripSeparator1,
            this.btnUserProcesses,
            this.btnAddSaloon,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(877, 58);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnReport1
            // 
            this.btnReport1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReport1.Image = global::Cinematorium.Properties.Resources.if_Business1_2316014__1_;
            this.btnReport1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReport1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport1.Name = "btnReport1";
            this.btnReport1.Size = new System.Drawing.Size(116, 55);
            this.btnReport1.Text = "Movie Sales Count ";
            this.btnReport1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport1.Click += new System.EventHandler(this.btnReport1_Click);
            // 
            // btnReport3
            // 
            this.btnReport3.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReport3.Image = global::Cinematorium.Properties.Resources.if_thefreeforty_profile_sheet_1243699;
            this.btnReport3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReport3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport3.Name = "btnReport3";
            this.btnReport3.Size = new System.Drawing.Size(139, 55);
            this.btnReport3.Text = "Customer Movie Count";
            this.btnReport3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport3.Click += new System.EventHandler(this.btnReport3_Click);
            // 
            // btnReport2
            // 
            this.btnReport2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReport2.Image = global::Cinematorium.Properties.Resources.if_AccountingAuditor_5_2175891;
            this.btnReport2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReport2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport2.Name = "btnReport2";
            this.btnReport2.Size = new System.Drawing.Size(140, 55);
            this.btnReport2.Text = "Employee Ticket Count";
            this.btnReport2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport2.Click += new System.EventHandler(this.btnReport2_Click);
            // 
            // btnReport4
            // 
            this.btnReport4.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReport4.Image = global::Cinematorium.Properties.Resources.envelope_stats;
            this.btnReport4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReport4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport4.Name = "btnReport4";
            this.btnReport4.Size = new System.Drawing.Size(144, 55);
            this.btnReport4.Text = "Sum of Earning to Date";
            this.btnReport4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport4.Click += new System.EventHandler(this.btnReport4_Click);
            // 
            // btnReport5
            // 
            this.btnReport5.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReport5.Image = global::Cinematorium.Properties.Resources.envelope_stats;
            this.btnReport5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReport5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport5.Name = "btnReport5";
            this.btnReport5.Size = new System.Drawing.Size(181, 55);
            this.btnReport5.Text = "Sum of Earning to Date Range";
            this.btnReport5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport5.Click += new System.EventHandler(this.btnReport5_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // btnUserProcesses
            // 
            this.btnUserProcesses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUserProcesses.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserProcesses.Image = global::Cinematorium.Properties.Resources.if_213_User_2124129__1_;
            this.btnUserProcesses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUserProcesses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUserProcesses.Name = "btnUserProcesses";
            this.btnUserProcesses.Size = new System.Drawing.Size(36, 55);
            this.btnUserProcesses.Text = "User Processes";
            this.btnUserProcesses.Click += new System.EventHandler(this.btnUserProcesses_Click);
            // 
            // btnAddSaloon
            // 
            this.btnAddSaloon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddSaloon.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSaloon.Image = global::Cinematorium.Properties.Resources.if_Audio___Video___Game_05_2298390;
            this.btnAddSaloon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddSaloon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSaloon.Name = "btnAddSaloon";
            this.btnAddSaloon.Size = new System.Drawing.Size(52, 55);
            this.btnAddSaloon.Text = "Add Saloon";
            this.btnAddSaloon.Click += new System.EventHandler(this.btnAddSaloon_Click);
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Image = global::Cinematorium.Properties.Resources.if_exit_2427705;
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 55);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvReportTable
            // 
            this.dgvReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReportTable.Location = new System.Drawing.Point(0, 0);
            this.dgvReportTable.Name = "dgvReportTable";
            this.dgvReportTable.Size = new System.Drawing.Size(877, 372);
            this.dgvReportTable.TabIndex = 1;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(132, 12);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(586, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dtpEnd
            // 
            this.dtpEnd.AutoSize = true;
            this.dtpEnd.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpEnd.Location = new System.Drawing.Point(516, 12);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(64, 19);
            this.dtpEnd.TabIndex = 4;
            this.dtpEnd.Text = "End Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(55, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Date:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 44);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvReportTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 372);
            this.panel2.TabIndex = 6;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::Cinematorium.Properties.Resources.stock_photo_movie_clapper_and_film_reel_on_a_wooden_background_169841813;
            this.ClientSize = new System.Drawing.Size(877, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormManager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnReport1;
        private System.Windows.Forms.ToolStripButton btnReport2;
        private System.Windows.Forms.ToolStripButton btnReport3;
        private System.Windows.Forms.ToolStripButton btnReport4;
        private System.Windows.Forms.ToolStripButton btnReport5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnUserProcesses;
        private System.Windows.Forms.ToolStripButton btnAddSaloon;
        private System.Windows.Forms.DataGridView dgvReportTable;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label dtpEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}