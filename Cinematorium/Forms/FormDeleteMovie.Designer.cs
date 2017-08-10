namespace Cinematorium.Forms
{
    partial class FormDeleteMovie
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMoviess = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.chkIs3D = new System.Windows.Forms.CheckBox();
            this.chkHasDubbing = new System.Windows.Forms.CheckBox();
            this.lblDurationAfterMin = new System.Windows.Forms.Label();
            this.nmuDuration = new System.Windows.Forms.NumericUpDown();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTrailerUrl = new System.Windows.Forms.TextBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTrailerUrl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDurationTime = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblPublishDate = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuDuration)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(348, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Movies";
            // 
            // cmbMoviess
            // 
            this.cmbMoviess.FormattingEnabled = true;
            this.cmbMoviess.Location = new System.Drawing.Point(88, 38);
            this.cmbMoviess.Name = "cmbMoviess";
            this.cmbMoviess.Size = new System.Drawing.Size(159, 21);
            this.cmbMoviess.TabIndex = 3;
            this.cmbMoviess.SelectedIndexChanged += new System.EventHandler(this.cmbMoviess_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(267, 36);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelUpdate
            // 
            this.panelUpdate.BackColor = System.Drawing.Color.Transparent;
            this.panelUpdate.Controls.Add(this.chkIs3D);
            this.panelUpdate.Controls.Add(this.chkHasDubbing);
            this.panelUpdate.Controls.Add(this.lblDurationAfterMin);
            this.panelUpdate.Controls.Add(this.nmuDuration);
            this.panelUpdate.Controls.Add(this.dtpDueDate);
            this.panelUpdate.Controls.Add(this.dtpPublishDate);
            this.panelUpdate.Controls.Add(this.txtDescription);
            this.panelUpdate.Controls.Add(this.txtTrailerUrl);
            this.panelUpdate.Controls.Add(this.txtMovieName);
            this.panelUpdate.Controls.Add(this.label7);
            this.panelUpdate.Controls.Add(this.lblTrailerUrl);
            this.panelUpdate.Controls.Add(this.label5);
            this.panelUpdate.Controls.Add(this.label4);
            this.panelUpdate.Controls.Add(this.lblDurationTime);
            this.panelUpdate.Controls.Add(this.lblDueDate);
            this.panelUpdate.Controls.Add(this.lblPublishDate);
            this.panelUpdate.Controls.Add(this.lblMovieName);
            this.panelUpdate.Location = new System.Drawing.Point(9, 77);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(428, 381);
            this.panelUpdate.TabIndex = 6;
            // 
            // chkIs3D
            // 
            this.chkIs3D.AutoSize = true;
            this.chkIs3D.BackColor = System.Drawing.Color.White;
            this.chkIs3D.Location = new System.Drawing.Point(194, 221);
            this.chkIs3D.Name = "chkIs3D";
            this.chkIs3D.Size = new System.Drawing.Size(44, 17);
            this.chkIs3D.TabIndex = 37;
            this.chkIs3D.Text = "Yes";
            this.chkIs3D.UseVisualStyleBackColor = false;
            // 
            // chkHasDubbing
            // 
            this.chkHasDubbing.AutoSize = true;
            this.chkHasDubbing.BackColor = System.Drawing.Color.White;
            this.chkHasDubbing.Location = new System.Drawing.Point(194, 184);
            this.chkHasDubbing.Name = "chkHasDubbing";
            this.chkHasDubbing.Size = new System.Drawing.Size(44, 17);
            this.chkHasDubbing.TabIndex = 36;
            this.chkHasDubbing.Text = "Yes";
            this.chkHasDubbing.UseVisualStyleBackColor = false;
            // 
            // lblDurationAfterMin
            // 
            this.lblDurationAfterMin.AutoSize = true;
            this.lblDurationAfterMin.BackColor = System.Drawing.Color.White;
            this.lblDurationAfterMin.Location = new System.Drawing.Point(270, 148);
            this.lblDurationAfterMin.Name = "lblDurationAfterMin";
            this.lblDurationAfterMin.Size = new System.Drawing.Size(26, 13);
            this.lblDurationAfterMin.TabIndex = 35;
            this.lblDurationAfterMin.Text = "min.";
            // 
            // nmuDuration
            // 
            this.nmuDuration.Location = new System.Drawing.Point(194, 145);
            this.nmuDuration.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nmuDuration.Name = "nmuDuration";
            this.nmuDuration.Size = new System.Drawing.Size(70, 20);
            this.nmuDuration.TabIndex = 34;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(194, 105);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(183, 20);
            this.dtpDueDate.TabIndex = 33;
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Location = new System.Drawing.Point(194, 68);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(183, 20);
            this.dtpPublishDate.TabIndex = 32;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(194, 293);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(183, 20);
            this.txtDescription.TabIndex = 30;
            // 
            // txtTrailerUrl
            // 
            this.txtTrailerUrl.Location = new System.Drawing.Point(194, 256);
            this.txtTrailerUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrailerUrl.Name = "txtTrailerUrl";
            this.txtTrailerUrl.Size = new System.Drawing.Size(183, 20);
            this.txtTrailerUrl.TabIndex = 31;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(194, 34);
            this.txtMovieName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(183, 20);
            this.txtMovieName.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(56, 296);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Description";
            // 
            // lblTrailerUrl
            // 
            this.lblTrailerUrl.AutoSize = true;
            this.lblTrailerUrl.BackColor = System.Drawing.Color.White;
            this.lblTrailerUrl.Location = new System.Drawing.Point(56, 259);
            this.lblTrailerUrl.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblTrailerUrl.Name = "lblTrailerUrl";
            this.lblTrailerUrl.Size = new System.Drawing.Size(58, 13);
            this.lblTrailerUrl.TabIndex = 26;
            this.lblTrailerUrl.Text = "Trailer Url :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(56, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Is 3D :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Has Dubbing :";
            // 
            // lblDurationTime
            // 
            this.lblDurationTime.AutoSize = true;
            this.lblDurationTime.BackColor = System.Drawing.Color.White;
            this.lblDurationTime.Location = new System.Drawing.Point(56, 148);
            this.lblDurationTime.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblDurationTime.Name = "lblDurationTime";
            this.lblDurationTime.Size = new System.Drawing.Size(99, 13);
            this.lblDurationTime.TabIndex = 23;
            this.lblDurationTime.Text = "Duration (Minutes) :";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.BackColor = System.Drawing.Color.White;
            this.lblDueDate.Location = new System.Drawing.Point(56, 111);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(59, 13);
            this.lblDueDate.TabIndex = 22;
            this.lblDueDate.Text = "Due Date :";
            // 
            // lblPublishDate
            // 
            this.lblPublishDate.AutoSize = true;
            this.lblPublishDate.BackColor = System.Drawing.Color.White;
            this.lblPublishDate.Location = new System.Drawing.Point(56, 74);
            this.lblPublishDate.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblPublishDate.Name = "lblPublishDate";
            this.lblPublishDate.Size = new System.Drawing.Size(73, 13);
            this.lblPublishDate.TabIndex = 28;
            this.lblPublishDate.Text = "Publish Date :";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.BackColor = System.Drawing.Color.White;
            this.lblMovieName.Location = new System.Drawing.Point(56, 41);
            this.lblMovieName.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(73, 13);
            this.lblMovieName.TabIndex = 21;
            this.lblMovieName.Text = "Movie Name :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(449, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // FormDeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinematorium.Properties.Resources.movie4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(449, 470);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMoviess);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDeleteMovie";
            this.Text = "FormDeleteMovie";
            this.Load += new System.EventHandler(this.FormDeleteMovie_Load);
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuDuration)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMoviess;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.CheckBox chkIs3D;
        private System.Windows.Forms.CheckBox chkHasDubbing;
        private System.Windows.Forms.Label lblDurationAfterMin;
        private System.Windows.Forms.NumericUpDown nmuDuration;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTrailerUrl;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTrailerUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDurationTime;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblPublishDate;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}