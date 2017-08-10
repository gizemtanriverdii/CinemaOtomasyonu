namespace Cinematorium
{
    partial class FormAddSaloon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddSaloon));
            this.pnlSeat = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engelliKoltuğuYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bozukKoltukYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.gosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAndClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnReset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblSaloonName = new System.Windows.Forms.Label();
            this.txtSaloonName = new System.Windows.Forms.TextBox();
            this.nudRow = new System.Windows.Forms.NumericUpDown();
            this.lblSaloonRowNumber = new System.Windows.Forms.Label();
            this.nudCollumn = new System.Windows.Forms.NumericUpDown();
            this.lblSaloonCollumnNumber = new System.Windows.Forms.Label();
            this.btnCreateSaloon = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollumn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSeat
            // 
            this.pnlSeat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeat.AutoScroll = true;
            this.pnlSeat.BackColor = System.Drawing.Color.Transparent;
            this.pnlSeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSeat.Location = new System.Drawing.Point(12, 183);
            this.pnlSeat.Name = "pnlSeat";
            this.pnlSeat.Size = new System.Drawing.Size(585, 414);
            this.pnlSeat.TabIndex = 6;
            this.pnlSeat.MouseEnter += new System.EventHandler(this.pnlSeat_MouseEnter);
            this.pnlSeat.Resize += new System.EventHandler(this.pnlSeat_Resize);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.engelliKoltuğuYapToolStripMenuItem,
            this.bozukKoltukYapToolStripMenuItem,
            this.toolStripMenuItem2,
            this.gosterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 98);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // engelliKoltuğuYapToolStripMenuItem
            // 
            this.engelliKoltuğuYapToolStripMenuItem.Name = "engelliKoltuğuYapToolStripMenuItem";
            this.engelliKoltuğuYapToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.engelliKoltuğuYapToolStripMenuItem.Text = "Engelli Koltuğu Yap";
            this.engelliKoltuğuYapToolStripMenuItem.Click += new System.EventHandler(this.engelliKoltuğuYapToolStripMenuItem_Click);
            // 
            // bozukKoltukYapToolStripMenuItem
            // 
            this.bozukKoltukYapToolStripMenuItem.Name = "bozukKoltukYapToolStripMenuItem";
            this.bozukKoltukYapToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.bozukKoltukYapToolStripMenuItem.Text = "Bozuk Koltuk Yap";
            this.bozukKoltukYapToolStripMenuItem.Click += new System.EventHandler(this.bozukKoltukYapToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 6);
            // 
            // gosterToolStripMenuItem
            // 
            this.gosterToolStripMenuItem.Enabled = false;
            this.gosterToolStripMenuItem.Name = "gosterToolStripMenuItem";
            this.gosterToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.gosterToolStripMenuItem.Text = "Göster";
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
            this.toolStripButton1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(609, 25);
            this.toolStrip.TabIndex = 12;
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.Transparent;
            this.pnlControls.Controls.Add(this.lblSaloonName);
            this.pnlControls.Controls.Add(this.txtSaloonName);
            this.pnlControls.Controls.Add(this.nudRow);
            this.pnlControls.Controls.Add(this.lblSaloonRowNumber);
            this.pnlControls.Controls.Add(this.nudCollumn);
            this.pnlControls.Controls.Add(this.lblSaloonCollumnNumber);
            this.pnlControls.Controls.Add(this.btnCreateSaloon);
            this.pnlControls.Location = new System.Drawing.Point(40, 28);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(497, 149);
            this.pnlControls.TabIndex = 15;
            // 
            // lblSaloonName
            // 
            this.lblSaloonName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaloonName.BackColor = System.Drawing.Color.White;
            this.lblSaloonName.Location = new System.Drawing.Point(134, 19);
            this.lblSaloonName.Name = "lblSaloonName";
            this.lblSaloonName.Size = new System.Drawing.Size(98, 25);
            this.lblSaloonName.TabIndex = 15;
            this.lblSaloonName.Text = "Saloon Name ";
            this.lblSaloonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSaloonName
            // 
            this.txtSaloonName.Location = new System.Drawing.Point(238, 19);
            this.txtSaloonName.Name = "txtSaloonName";
            this.txtSaloonName.Size = new System.Drawing.Size(152, 25);
            this.txtSaloonName.TabIndex = 14;
            // 
            // nudRow
            // 
            this.nudRow.Location = new System.Drawing.Point(158, 69);
            this.nudRow.Name = "nudRow";
            this.nudRow.Size = new System.Drawing.Size(49, 25);
            this.nudRow.TabIndex = 13;
            this.nudRow.ThousandsSeparator = true;
            // 
            // lblSaloonRowNumber
            // 
            this.lblSaloonRowNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaloonRowNumber.BackColor = System.Drawing.Color.White;
            this.lblSaloonRowNumber.Location = new System.Drawing.Point(60, 69);
            this.lblSaloonRowNumber.Name = "lblSaloonRowNumber";
            this.lblSaloonRowNumber.Size = new System.Drawing.Size(92, 25);
            this.lblSaloonRowNumber.TabIndex = 2;
            this.lblSaloonRowNumber.Text = "Row Number ";
            this.lblSaloonRowNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudCollumn
            // 
            this.nudCollumn.Location = new System.Drawing.Point(381, 69);
            this.nudCollumn.Name = "nudCollumn";
            this.nudCollumn.Size = new System.Drawing.Size(44, 25);
            this.nudCollumn.TabIndex = 13;
            this.nudCollumn.ThousandsSeparator = true;
            // 
            // lblSaloonCollumnNumber
            // 
            this.lblSaloonCollumnNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaloonCollumnNumber.BackColor = System.Drawing.Color.White;
            this.lblSaloonCollumnNumber.Location = new System.Drawing.Point(261, 69);
            this.lblSaloonCollumnNumber.Name = "lblSaloonCollumnNumber";
            this.lblSaloonCollumnNumber.Size = new System.Drawing.Size(114, 25);
            this.lblSaloonCollumnNumber.TabIndex = 2;
            this.lblSaloonCollumnNumber.Text = "Column Number ";
            this.lblSaloonCollumnNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateSaloon
            // 
            this.btnCreateSaloon.BackColor = System.Drawing.Color.White;
            this.btnCreateSaloon.Location = new System.Drawing.Point(193, 115);
            this.btnCreateSaloon.Margin = new System.Windows.Forms.Padding(45, 4, 45, 4);
            this.btnCreateSaloon.Name = "btnCreateSaloon";
            this.btnCreateSaloon.Size = new System.Drawing.Size(111, 30);
            this.btnCreateSaloon.TabIndex = 3;
            this.btnCreateSaloon.Text = "Create";
            this.btnCreateSaloon.UseVisualStyleBackColor = false;
            this.btnCreateSaloon.Click += new System.EventHandler(this.btnCreateSaloon_Click);
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
            // FormAddSaloon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinematorium.Properties.Resources.salon3;
            this.ClientSize = new System.Drawing.Size(609, 609);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.pnlSeat);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddSaloon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Saloon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.FormAddSaloon_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCollumn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        
        #endregion
        private System.Windows.Forms.Panel pnlSeat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engelliKoltuğuYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bozukKoltukYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gosterToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnSaveAndClose;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblSaloonName;
        private System.Windows.Forms.TextBox txtSaloonName;
        private System.Windows.Forms.NumericUpDown nudRow;
        private System.Windows.Forms.Label lblSaloonRowNumber;
        private System.Windows.Forms.NumericUpDown nudCollumn;
        private System.Windows.Forms.Label lblSaloonCollumnNumber;
        private System.Windows.Forms.Button btnCreateSaloon;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

