namespace Cinematorium.Forms
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TicketSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonTanımlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımamalarToolStripMenuItem,
            this.satışToolStripMenuItem,
            this.yöneticiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(319, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımamalarToolStripMenuItem
            // 
            this.tanımamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TicketSaleToolStripMenuItem,
            this.salonTanımlaToolStripMenuItem,
            this.filmEkleToolStripMenuItem});
            this.tanımamalarToolStripMenuItem.Name = "tanımamalarToolStripMenuItem";
            this.tanımamalarToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.tanımamalarToolStripMenuItem.Text = "Çalışan";
            // 
            // TicketSaleToolStripMenuItem
            // 
            this.filmTanımlaToolStripMenuItem.Name = "filmTanımlaToolStripMenuItem";
            this.filmTanımlaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filmTanımlaToolStripMenuItem.Text = "Bilet Satış";
            // 
            // salonTanımlaToolStripMenuItem
            // 
            this.salonTanımlaToolStripMenuItem.Name = "salonTanımlaToolStripMenuItem";
            this.salonTanımlaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salonTanımlaToolStripMenuItem.Text = "Salon Tanımla";
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporlarToolStripMenuItem});
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.satışToolStripMenuItem.Text = "Muhasebeci";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // yöneticiToolStripMenuItem
            // 
            this.yöneticiToolStripMenuItem.Name = "yöneticiToolStripMenuItem";
            this.yöneticiToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.yöneticiToolStripMenuItem.Text = "Yönetici";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 246);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TicketSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonTanımlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmEkleToolStripMenuItem;
    }
}