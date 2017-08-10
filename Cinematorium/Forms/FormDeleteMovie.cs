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
    public partial class FormDeleteMovie : Form
    {
        public FormDeleteMovie()
        {
            InitializeComponent();
        }
        DatabaseContext db = new DatabaseContext();
        private void LoadToMovies()
        {
            cmbMoviess.DataSource = null;
            var movies = db.Movies.ToList();
            cmbMoviess.DisplayMember = "Name";
            cmbMoviess.DataSource = movies;  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Movie movieId = cmbMoviess.SelectedItem as Movie;
            db.Movies.Remove(movieId);
            db.SaveChanges();
            LoadToMovies();
            MessageBox.Show("Film Başarıyla Silindi");
        }

        private void FormDeleteMovie_Load(object sender, EventArgs e)
        {
            LoadToMovies();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int movieId = (cmbMoviess.SelectedItem as Movie).Id;
            Movie mov = db.Movies.FirstOrDefault(x => x.Id == movieId);
            mov.Name = txtMovieName.Text;
            mov.PublishDate = dtpPublishDate.Value;
            mov.DueDate = dtpDueDate.Value;
            mov.Duration =Convert.ToInt32(nmuDuration.Value);
            mov.HasDubbing = chkHasDubbing.Checked;
            mov.Is3D = chkIs3D.Checked;
            mov.TrailerUrl = txtTrailerUrl.Text;
            mov.Description = txtDescription.Text;

            db.SaveChanges();
            LoadToMovies();
        }

        private void cmbMoviess_SelectedIndexChanged(object sender, EventArgs e)
        {
            int movieId = 0;
            if (cmbMoviess.SelectedIndex > -1)
            {
                movieId = (cmbMoviess.SelectedItem as Movie).Id;
                Movie mov = db.Movies.FirstOrDefault(x => x.Id == movieId);

                txtMovieName.Text = mov.Name;
                dtpPublishDate.Value = mov.PublishDate;
                dtpDueDate.Value = mov.DueDate;
                nmuDuration.Value = mov.Duration;
                chkHasDubbing.Checked = mov.HasDubbing;
                chkIs3D.Checked = mov.Is3D;
                txtTrailerUrl.Text = mov.TrailerUrl;
                txtDescription.Text = mov.Description;
            }
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }
    }
}
