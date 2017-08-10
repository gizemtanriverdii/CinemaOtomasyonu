using Cinematorium.DataAccessLayer;
using Cinematorium.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinematorium.Forms
{
    public partial class FormMain : Form

    {
       
        public FormMain()
        {
            InitializeComponent();
        }

        internal User LoginUser;

        private void salonTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddSession AddSession = new FormAddSession();
            AddSession.Show();
            this.Hide();
        }

        private void TicketSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketSales ticketsale = new TicketSales();
            ticketsale.Show();
            this.Hide();
        }

        private void filmEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToAddMovie addmovie = new ToAddMovie();
            addmovie.Show();
            this.Hide();
        }
    }
}
