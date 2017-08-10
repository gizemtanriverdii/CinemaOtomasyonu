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
    public partial class FormAddSession : Form
    {
        DatabaseContext db = new DatabaseContext();
        public FormAddSession()
        {
            InitializeComponent();

        }
        private void LoadToCmbSaloons()
        {
            var Saloons = db.Saloons.ToList();
            if (Saloons != null)
            {
                foreach (var s in Saloons)
                {
                    cmbSaloons.Items.Add(s.Name);
                }
            }
            else
            {
                MessageBox.Show("Eklenmiş Salon Bulunmamaktadır.");
            }
        }

        private void LoadToCmbMovies()
        {
            var Movies = db.Movies.ToList();
            if(Movies!=null)
            {
                foreach (var m in Movies)
                {
                    cmbMovies.Items.Add(m.Name);
                }
            }
            else
            {
                MessageBox.Show("Eklenmiş Film Bulunmamaktadır.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void Insert()
        {
            Movie _movie = new Movie();
       
            //Movie movie = cmbMovies.SelectedItem as Movie;
            //Saloon saloon = cmbSaloons.SelectedItem as Saloon;
            DateTime date = dtpdate.Value; 
            string time = dtpTime.Value.ToShortTimeString();
            TimeSpan time_ = Convert.ToDateTime(time).TimeOfDay;

            
            Session session = new Session()
            {
                DayDate = date,
                StartTime = time_
              
            };
            //db.Sessions.Add(session);

            IEnumerable<Movie> Movies = db.Movies;

            foreach (var m in Movies)
            {
                if (m.Name == cmbMovies.SelectedItem.ToString())
                {
                    m.Sessions.Add(session);
                    _movie = m;
                    break;
                }
            }
           
            IEnumerable<Saloon> Saloons = db.Saloons;

            foreach (var s in Saloons)
            {
                if (s.Name == cmbSaloons.SelectedItem.ToString())
                {
                    s.Sessions.Add(session);
                    s.Movies.Add(_movie);
                    _movie.Saloons.Add(s);
               
                    break;
                }
            }
            db.SaveChanges();

            MessageBox.Show("Kaydedildi");
        }

        private void FormAddSession_Load(object sender, EventArgs e)
        {
            LoadToCmbMovies();
            LoadToCmbSaloons();
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            Insert();
            FormTicketSales frm = new FormTicketSales();
            this.Hide();
            frm.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpdate.Value = DateTime.Now.Date;
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = " ";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDeleteSession frm = new FormDeleteSession();
            frm.Show();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }
    }
}
