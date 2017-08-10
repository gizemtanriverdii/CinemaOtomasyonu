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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }

        DatabaseContext db = new DatabaseContext();       

        private void btnUserProcesses_Click(object sender, EventArgs e)
        {
            FormUserProcesses addUserProcesses = new FormUserProcesses();
            addUserProcesses.Show();
        }

        private void btnAddSaloon_Click(object sender, EventArgs e)
        {
            FormAddSaloon AddSaloon = new FormAddSaloon();
            AddSaloon.Show();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            this.dgvReportTable.ForeColor = Color.Transparent;
            this.BackgroundImage = Cinematorium.Properties.Resources.salon3;
            var reportTable = from t in db.Tickets
                              join m in db.Movies on t.Movie.Id equals m.Id
                              join x in db.User on t.User.Id equals x.Id
                              join c in db.Customers on t.customer.Id equals c.Id
                              select new
                              {
                                  movieId = m.Id,
                                  movieName = m.Name,
                                  ticketId = t.Id,
                                  ticketSellBy = t.SellBy,
                                  ticketPrice = t.Price,
                                  UserId = x.Id,
                                  UserName = x.Name + " " + x.Surname,
                                  UserKind = x.EmployeeKind,
                                  customerId = c.Id,
                                  customerName = c.Name + " " + c.Surname

                              };

            dgvReportTable.DataSource = reportTable.ToList();
        }
        private void btnReport1_Click(object sender, EventArgs e)
        {
            var MovieSalesCount = from t in db.Tickets
                                  join m in db.Movies on t.Movie.Id equals m.Id
                                  select new
                                  {
                                      movieId = m.Id,
                                      movieName = m.Name,
                                      MovieSalesCount = m.Tickets.Count()
                                  };

            dgvReportTable.DataSource = MovieSalesCount.Distinct().OrderByDescending(x => x.MovieSalesCount).OrderBy(x => x.movieName).ToList();

            int sum = MovieSalesCount.Distinct().Sum(m => m.MovieSalesCount);
            MessageBox.Show($"Movie Sales Count : {sum} ");
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            var TicketsSoldbyEmployeesCount = from t in db.Tickets
                                              join x in db.User on t.User.Id equals x.Id
                                              select new
                                              {
                                                  UserId = x.Id,
                                                  UserName = x.Name + " " + x.Surname,
                                                  UserKind = x.EmployeeKind,
                                                  TicketsSoldbyEmployeesCount =
                                                  x.Ticket.Count()
                                              };
            dgvReportTable.DataSource = TicketsSoldbyEmployeesCount.Distinct().OrderByDescending(x => x.TicketsSoldbyEmployeesCount).OrderBy(x => x.UserName).ToList();
            int sum = TicketsSoldbyEmployeesCount.Distinct().Sum(m => m.TicketsSoldbyEmployeesCount);
            MessageBox.Show($"Ticket Sold by Employees Count : {sum} ");
        }

        private void btnReport3_Click(object sender, EventArgs e)
        {
            var MoviesWatchedbyCustomersCount = from t in db.Tickets
                                                join c in db.Customers on t.customer.Id equals c.Id
                                                join m in db.Movies on t.Movie.Id equals m.Id
                                                select new
                                                {
                                                    customerId = c.Id,
                                                    customerName = c.Name + " " + c.Surname,
                                                    MoviesWatchedbyCustomersCount = c.Tickets.Count()
                                                };
            dgvReportTable.DataSource = MoviesWatchedbyCustomersCount.Distinct().OrderByDescending(x => x.MoviesWatchedbyCustomersCount).OrderBy(x => x.customerName).ToList();
            int sum = MoviesWatchedbyCustomersCount.Distinct().Sum(m => m.MoviesWatchedbyCustomersCount);
            MessageBox.Show($"Movies Watched by Customers Count : {sum} ");
        }

        private void btnReport4_Click(object sender, EventArgs e)
        {
            var records = db.Tickets.Where(x => x.SellBy == dtpStart.Value.Date).ToList();
            decimal total = 0;
            if (records != null && records.Count > 0)
            {
                total = records.Sum(a => a.Price);
            }

            MessageBox.Show($" {dtpStart.Value.ToShortDateString()}  {total.ToString()}");
        }

        private void btnReport5_Click(object sender, EventArgs e)
        {
            var records = db.Tickets.Where(x => x.SellBy >= dtpStart.Value.Date && x.SellBy <= dateTimePicker2.Value.Date).ToList();
            decimal total = 0;
            if (records != null && records.Count > 0)
            {
                total = records.Sum(a => a.Price);
            }
            MessageBox.Show($" {dtpStart.Value.ToShortDateString()}  {total.ToString()}");
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }
    }
}
