namespace Cinematorium.Forms
{
    partial class FormTicketSales
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
            this.pnlSeat = new System.Windows.Forms.Panel();
            this.btnSell = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbprice = new System.Windows.Forms.ComboBox();
            this.cmbsessions = new System.Windows.Forms.ComboBox();
            this.cmbmovies = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSaloonname = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcustomerinfo = new System.Windows.Forms.TextBox();
            this.selected_seat = new System.Windows.Forms.TextBox();
            this.dtpsellby = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpsellbyy = new System.Windows.Forms.DateTimePicker();
            this.customerName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSeat
            // 
            this.pnlSeat.BackColor = System.Drawing.Color.Transparent;
            this.pnlSeat.Location = new System.Drawing.Point(308, 40);
            this.pnlSeat.Name = "pnlSeat";
            this.pnlSeat.Size = new System.Drawing.Size(816, 480);
            this.pnlSeat.TabIndex = 1;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(107, 327);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 2;
            this.btnSell.Text = "SELL";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Session Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price";
            // 
            // cmbprice
            // 
            this.cmbprice.DisplayMember = "0";
            this.cmbprice.FormattingEnabled = true;
            this.cmbprice.Items.AddRange(new object[] {
            "TAM: 5₺",
            "ÖĞRENCİ: 3₺"});
            this.cmbprice.Location = new System.Drawing.Point(160, 222);
            this.cmbprice.Name = "cmbprice";
            this.cmbprice.Size = new System.Drawing.Size(108, 21);
            this.cmbprice.TabIndex = 2;
            // 
            // cmbsessions
            // 
            this.cmbsessions.DisplayMember = "0";
            this.cmbsessions.FormattingEnabled = true;
            this.cmbsessions.Location = new System.Drawing.Point(160, 159);
            this.cmbsessions.Name = "cmbsessions";
            this.cmbsessions.Size = new System.Drawing.Size(108, 21);
            this.cmbsessions.TabIndex = 2;
            this.cmbsessions.SelectionChangeCommitted += new System.EventHandler(this.cmbsessions_SelectionChangeCommitted);
            // 
            // cmbmovies
            // 
            this.cmbmovies.DisplayMember = "0";
            this.cmbmovies.FormattingEnabled = true;
            this.cmbmovies.Location = new System.Drawing.Point(160, 129);
            this.cmbmovies.Name = "cmbmovies";
            this.cmbmovies.Size = new System.Drawing.Size(108, 21);
            this.cmbmovies.TabIndex = 2;
            this.cmbmovies.SelectionChangeCommitted += new System.EventHandler(this.cmbmovies_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Name-Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-62, 596);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selected Seat";
            // 
            // cmbSaloonname
            // 
            this.cmbSaloonname.FormattingEnabled = true;
            this.cmbSaloonname.Location = new System.Drawing.Point(160, 191);
            this.cmbSaloonname.Name = "cmbSaloonname";
            this.cmbSaloonname.Size = new System.Drawing.Size(108, 21);
            this.cmbSaloonname.TabIndex = 0;
            this.cmbSaloonname.SelectionChangeCommitted += new System.EventHandler(this.cmbSaloonname_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Saloon";
            // 
            // txtcustomerinfo
            // 
            this.txtcustomerinfo.Location = new System.Drawing.Point(160, 252);
            this.txtcustomerinfo.Name = "txtcustomerinfo";
            this.txtcustomerinfo.Size = new System.Drawing.Size(108, 20);
            this.txtcustomerinfo.TabIndex = 6;
            // 
            // selected_seat
            // 
            this.selected_seat.Location = new System.Drawing.Point(0, 0);
            this.selected_seat.Name = "selected_seat";
            this.selected_seat.Size = new System.Drawing.Size(100, 20);
            this.selected_seat.TabIndex = 0;
            // 
            // dtpsellby
            // 
            this.dtpsellby.CustomFormat = "";
            this.dtpsellby.Location = new System.Drawing.Point(160, 103);
            this.dtpsellby.Name = "dtpsellby";
            this.dtpsellby.Size = new System.Drawing.Size(108, 20);
            this.dtpsellby.TabIndex = 7;
            this.dtpsellby.ValueChanged += new System.EventHandler(this.dtpsellby_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpsellby);
            this.groupBox1.Controls.Add(this.txtcustomerinfo);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 279);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // dtpsellbyy
            // 
            this.dtpsellbyy.CustomFormat = "dd.MM.yyyy";
            this.dtpsellbyy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpsellbyy.Location = new System.Drawing.Point(160, 103);
            this.dtpsellbyy.Name = "dtpsellbyy";
            this.dtpsellbyy.Size = new System.Drawing.Size(108, 20);
            this.dtpsellbyy.TabIndex = 6;
            this.dtpsellbyy.ValueChanged += new System.EventHandler(this.dtpsellbyy_ValueChanged);
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(160, 249);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(108, 20);
            this.customerName.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1194, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.sessionToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // movieToolStripMenuItem
            // 
            this.movieToolStripMenuItem.Name = "movieToolStripMenuItem";
            this.movieToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.movieToolStripMenuItem.Text = "Movie";
            this.movieToolStripMenuItem.Click += new System.EventHandler(this.movieToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sessionToolStripMenuItem.Text = "Session";
            this.sessionToolStripMenuItem.Click += new System.EventHandler(this.sessionToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // FormTicketSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinematorium.Properties.Resources.salon3;
            this.ClientSize = new System.Drawing.Size(1194, 586);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.dtpsellbyy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.cmbSaloonname);
            this.Controls.Add(this.pnlSeat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbmovies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbsessions);
            this.Controls.Add(this.cmbprice);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTicketSales";
            this.Text = "Cinema";
          
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlSeat;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbprice;
        private System.Windows.Forms.ComboBox cmbsessions;
        private System.Windows.Forms.ComboBox cmbmovies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSaloonname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcustomerinfo;
        private System.Windows.Forms.TextBox selected_seat;
        private System.Windows.Forms.DateTimePicker dtpsellby;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpsellbyy;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}