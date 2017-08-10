namespace Cinematorium.Forms
{
    partial class FormAddMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddMovie));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAndClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnReset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnMovieKindAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.lblPublishDate = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblDurationTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTrailerUrl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nmuDuration = new System.Windows.Forms.NumericUpDown();
            this.lblDurationAfterMin = new System.Windows.Forms.Label();
            this.chkHasDubbing = new System.Windows.Forms.CheckBox();
            this.chkIs3D = new System.Windows.Forms.CheckBox();
            this.txtTrailerUrl = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnTS = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.cmbmoviekinds = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnSaveAndClose,
            this.toolStripSeparator,
            this.btnReset,
            this.toolStripSeparator2,
            this.btnDelete,
            this.btnMovieKindAdd,
            this.toolStripButton1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(673, 25);
            this.toolStrip.TabIndex = 13;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::Cinematorium.Properties.Resources.save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Save";
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAndClose.Image = global::Cinematorium.Properties.Resources.saveAndClose;
            this.btnSaveAndClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(23, 22);
            this.btnSaveAndClose.Text = "Save & Close";
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // btnReset
            // 
            this.btnReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReset.Image = global::Cinematorium.Properties.Resources.turnBack;
            this.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(23, 22);
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = global::Cinematorium.Properties.Resources.cross;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMovieKindAdd
            // 
            this.btnMovieKindAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMovieKindAdd.Image = global::Cinematorium.Properties.Resources.if__movie_festival2_2324154;
            this.btnMovieKindAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMovieKindAdd.Name = "btnMovieKindAdd";
            this.btnMovieKindAdd.Size = new System.Drawing.Size(23, 22);
            this.btnMovieKindAdd.Text = "toolStripButton1";
            this.btnMovieKindAdd.Click += new System.EventHandler(this.btnMovieKindAdd_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(131, 32);
            this.lblMovieName.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(90, 17);
            this.lblMovieName.TabIndex = 14;
            this.lblMovieName.Text = "Movie Name :";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(269, 29);
            this.txtMovieName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(183, 25);
            this.txtMovieName.TabIndex = 15;
            // 
            // lblPublishDate
            // 
            this.lblPublishDate.AutoSize = true;
            this.lblPublishDate.Location = new System.Drawing.Point(131, 98);
            this.lblPublishDate.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblPublishDate.Name = "lblPublishDate";
            this.lblPublishDate.Size = new System.Drawing.Size(87, 17);
            this.lblPublishDate.TabIndex = 14;
            this.lblPublishDate.Text = "Publish Date :";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(131, 135);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(69, 17);
            this.lblDueDate.TabIndex = 14;
            this.lblDueDate.Text = "Due Date :";
            // 
            // lblDurationTime
            // 
            this.lblDurationTime.AutoSize = true;
            this.lblDurationTime.Location = new System.Drawing.Point(131, 172);
            this.lblDurationTime.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblDurationTime.Name = "lblDurationTime";
            this.lblDurationTime.Size = new System.Drawing.Size(123, 17);
            this.lblDurationTime.TabIndex = 14;
            this.lblDurationTime.Text = "Duration (Minutes) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Has Dubbing :";
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.CustomFormat = "dd:mm:yyyy";
            this.dtpPublishDate.Location = new System.Drawing.Point(269, 92);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(183, 25);
            this.dtpPublishDate.TabIndex = 17;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "dd:mm:yyyy";
            this.dtpDueDate.Location = new System.Drawing.Point(269, 129);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(183, 25);
            this.dtpDueDate.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Is 3D :";
            // 
            // lblTrailerUrl
            // 
            this.lblTrailerUrl.AutoSize = true;
            this.lblTrailerUrl.Location = new System.Drawing.Point(131, 283);
            this.lblTrailerUrl.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblTrailerUrl.Name = "lblTrailerUrl";
            this.lblTrailerUrl.Size = new System.Drawing.Size(72, 17);
            this.lblTrailerUrl.TabIndex = 14;
            this.lblTrailerUrl.Text = "Trailer Url :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 320);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Description";
            // 
            // nmuDuration
            // 
            this.nmuDuration.Location = new System.Drawing.Point(269, 163);
            this.nmuDuration.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nmuDuration.Name = "nmuDuration";
            this.nmuDuration.Size = new System.Drawing.Size(70, 25);
            this.nmuDuration.TabIndex = 18;
            // 
            // lblDurationAfterMin
            // 
            this.lblDurationAfterMin.AutoSize = true;
            this.lblDurationAfterMin.Location = new System.Drawing.Point(345, 172);
            this.lblDurationAfterMin.Name = "lblDurationAfterMin";
            this.lblDurationAfterMin.Size = new System.Drawing.Size(32, 17);
            this.lblDurationAfterMin.TabIndex = 19;
            this.lblDurationAfterMin.Text = "min.";
            // 
            // chkHasDubbing
            // 
            this.chkHasDubbing.AutoSize = true;
            this.chkHasDubbing.Location = new System.Drawing.Point(269, 208);
            this.chkHasDubbing.Name = "chkHasDubbing";
            this.chkHasDubbing.Size = new System.Drawing.Size(46, 21);
            this.chkHasDubbing.TabIndex = 20;
            this.chkHasDubbing.Text = "Yes";
            this.chkHasDubbing.UseVisualStyleBackColor = true;
            // 
            // chkIs3D
            // 
            this.chkIs3D.AutoSize = true;
            this.chkIs3D.Location = new System.Drawing.Point(269, 245);
            this.chkIs3D.Name = "chkIs3D";
            this.chkIs3D.Size = new System.Drawing.Size(46, 21);
            this.chkIs3D.TabIndex = 20;
            this.chkIs3D.Text = "Yes";
            this.chkIs3D.UseVisualStyleBackColor = true;
            // 
            // txtTrailerUrl
            // 
            this.txtTrailerUrl.Location = new System.Drawing.Point(269, 280);
            this.txtTrailerUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrailerUrl.Name = "txtTrailerUrl";
            this.txtTrailerUrl.Size = new System.Drawing.Size(183, 25);
            this.txtTrailerUrl.TabIndex = 15;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(269, 317);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(183, 25);
            this.txtDescription.TabIndex = 15;
            // 
            // btnTS
            // 
            this.btnTS.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTS.Location = new System.Drawing.Point(269, 360);
            this.btnTS.Name = "btnTS";
            this.btnTS.Size = new System.Drawing.Size(90, 31);
            this.btnTS.TabIndex = 21;
            this.btnTS.Text = "Movies";
            this.btnTS.UseVisualStyleBackColor = true;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(365, 360);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(87, 31);
            this.btnAddMovie.TabIndex = 21;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // cmbmoviekinds
            // 
            this.cmbmoviekinds.FormattingEnabled = true;
            this.cmbmoviekinds.Location = new System.Drawing.Point(269, 61);
            this.cmbmoviekinds.Name = "cmbmoviekinds";
            this.cmbmoviekinds.Size = new System.Drawing.Size(183, 25);
            this.cmbmoviekinds.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Movie Kind :";
            // 
            // FormAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinematorium.Properties.Resources._11;
            this.ClientSize = new System.Drawing.Size(673, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbmoviekinds);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.btnTS);
            this.Controls.Add(this.chkIs3D);
            this.Controls.Add(this.chkHasDubbing);
            this.Controls.Add(this.lblDurationAfterMin);
            this.Controls.Add(this.nmuDuration);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.dtpPublishDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTrailerUrl);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTrailerUrl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDurationTime);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblPublishDate);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Movie";
            this.Load += new System.EventHandler(this.FormAddMovie_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnSaveAndClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton btnReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label lblPublishDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblDurationTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTrailerUrl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmuDuration;
        private System.Windows.Forms.Label lblDurationAfterMin;
        private System.Windows.Forms.CheckBox chkHasDubbing;
        private System.Windows.Forms.CheckBox chkIs3D;
        private System.Windows.Forms.TextBox txtTrailerUrl;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnTS;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.ComboBox cmbmoviekinds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnMovieKindAdd;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}