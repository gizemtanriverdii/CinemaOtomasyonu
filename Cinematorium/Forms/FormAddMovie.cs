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
using Microsoft.VisualBasic;
namespace Cinematorium.Forms
{
    public partial class FormAddMovie : Form
    {
        public FormAddMovie()
        {
            InitializeComponent();
        }
        DatabaseContext db = new DatabaseContext();

        private void btnTS_Click(object sender, EventArgs e)
        {
            FormDeleteMovie delete = new FormDeleteMovie();
            this.Hide();
            delete.ShowDialog();
            //this.Close();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            Movie mov = new Movie()
            {
                Name = txtMovieName.Text,
                PublishDate = dtpPublishDate.Value,
                DueDate = dtpDueDate.Value,
                Duration = Convert.ToInt32(nmuDuration.Value),
                HasDubbing = chkHasDubbing.Checked,
                Is3D = chkIs3D.Checked,
                TrailerUrl = txtTrailerUrl.Text,
                Description = txtDescription.Text,
                MovieKinds = (cmbmoviekinds.SelectedItem) as List<MovieKind>,
            };

            MovieKind kind = new MovieKind()
            {
                Name = cmbmoviekinds.SelectedItem.ToString()
            };
            DatabaseContext db = new DatabaseContext();

            kind.Movies.Add(mov);

            db.MovieKinds.Add(kind);

            db.Movies.Add(mov);

            db.SaveChanges();
            MessageBox.Show("Film Kaydedilme işlemi Başarı ile Gerçekleşti");
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            Save();
            this.Hide();
            FormTicketSales frm = new FormTicketSales();
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDeleteMovie frm = new FormDeleteMovie();
            frm.Show();
        }

        private void FormAddMovie_Load(object sender, EventArgs e)
        {      
            foreach (var m in db.Movies)
            {
                cmbmoviekinds.Items.Add(m.Name);
            }
        }

        private void btnMovieKindAdd_Click(object sender, EventArgs e)
        {
            string MovieKind = Interaction.InputBox(" Please Entry MovieKind ");
            MovieKind moviekind = new MovieKind
            {
                Name = MovieKind
            };

            db.MovieKinds.Add(moviekind);
            cmbmoviekinds.Items.Add(MovieKind);
            db.SaveChanges();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbmoviekinds.DataSource = null;
            cmbmoviekinds.DisplayMember = "Name";
            cmbmoviekinds.DataSource = db.MovieKinds.ToList();

            var moviekinds = db.MovieKinds.ToList();
            cmbmoviekinds.DataSource = moviekinds;
            cmbmoviekinds.DisplayMember = "Name";
            txtMovieName.Text = null;
            dtpPublishDate.Value = DateTime.Now.Date;
            dtpDueDate.Value = DateTime.Now.Date;
            nmuDuration.Value = 0;
            chkHasDubbing.Checked = false;
            chkIs3D.Checked = false;
            txtTrailerUrl.Text = null;
            txtDescription.Text = null;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }
    }
}
