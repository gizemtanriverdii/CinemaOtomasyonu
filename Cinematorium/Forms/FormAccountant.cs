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
    public partial class FormAccountant : Form
    {
        public FormAccountant()
        {
            InitializeComponent();
        }
        public DatabaseContext db = new DatabaseContext();

        private void MnuTotalCounter_Click(object sender, EventArgs e)
        {
            var MovieSalesCount = from t in db.Tickets
                                  join m in db.Movies on t.Movie.Id equals m.Id
                                  join x in db.User on t.User.Id equals x.Id
                                  select new
                                  {
                                      movieName = m.Name,
                                      MovieTicketCount = m.Tickets.Count(),
                                      UserName = x.Name + " " + x.Surname,

                                  };

            dgvAccountant.DataSource = MovieSalesCount.Distinct().OrderByDescending(x => x.MovieTicketCount).OrderBy(x => x.movieName).ToList();

            int sum = MovieSalesCount.Distinct().Sum(m => m.MovieTicketCount);
            MessageBox.Show($"Movie Sales Count : {sum} ");

            dgvAccountant_SelectionChanged(sender, e);
        }

        private void addSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loadusertodgv();
        }

        private void Loadusertodgv()
        {
            var users = from u in db.User
                        select new
                        {
                            FullName = u.Name + " " + u.Surname,
                            u.UserName,
                            u.EmployeeKind,
                            u.StartWorkDate,
                            u.Salary,
                            u.IsWorking
                        };
            dgvAccountant.DataSource = users.ToList();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (dgvAccountant.CurrentRow == null) return;

            int UserID = (dgvAccountant.CurrentRow.DataBoundItem as User).Id;

            User u = db.User.FirstOrDefault(x => x.Id == UserID);

            if (u == null) return;

            u.StartWorkDate = dtpStartWorkDate.Value;
            u.Salary = numSalary.Value;
            u.IsWorking = chbIsWorking.Checked;

            db.SaveChanges();

            MessageBox.Show("Your registration came true successfully.");

            dgvAccountant.DataSource = db.User.ToList();
        }

        private void MnuTotalGain_Click(object sender, EventArgs e)
        {
            var MoviePrice = from t in db.Tickets
                             join m in db.Movies on t.Movie.Id equals m.Id
                             select new
                             {
                                 movieId = m.Id,
                                 movieName = m.Name,

                                 TicketPrice = t.Price
                             };

            dgvAccountant.DataSource = MoviePrice.ToList();

           
                decimal sum = MoviePrice.Distinct().Sum(m => m.TicketPrice);
                MessageBox.Show($"Movie Sales Count : {sum} ");
        }

        private void dgvAccountant_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAccountant.CurrentRow != null)
            {
                User user = dgvAccountant.CurrentRow.DataBoundItem as User;
                if (user != null)
                {
                    txnameandsurname.Text = dgvAccountant.CurrentRow.Cells["UserName"].Value.ToString();
                    dgvAccountant.CurrentRow.Cells["Salary"].Value = dtpStartWorkDate.Value;
                    dgvAccountant.CurrentRow.Cells[7].Value = numSalary.Value;
                    dgvAccountant.CurrentRow.Cells[8].Value = chbIsWorking.Checked;
                }
            }
        }

        private void FormAccountant_Load(object sender, EventArgs e)
        {
            IEnumerable<User> users = db.User;

            var list_User = from u in users select u;
                        
            dgvAccountant.DataSource = list_User.ToList();
        }

        private void taxReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<Ticket> reports = db.Tickets;
            var report = reports.Sum(s => s.Price);

            var r = from ticket in db.Tickets
                    orderby ticket.SellBy.Month ascending
                    group ticket by ticket.SellBy.Month into month
                    select new
                    {
                        sellby = month.Key,
                        price = month.Sum(s => s.Price),
                        Kdv = (month.Sum(s => s.Price) * 18 / 100)
                    };
            dgvAccountant.DataSource = r.ToList();
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            this.Hide();
            frm.Show();
        }
    }
}



