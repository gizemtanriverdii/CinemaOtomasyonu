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
    public partial class FormDeleteSaloon : Form
    {
        public FormDeleteSaloon()
        {
            InitializeComponent();
        }
        DatabaseContext db = new DatabaseContext();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbSaloons.SelectedIndex > -1)
            {
                Saloon saloon = cmbSaloons.SelectedItem as Saloon;

                var seats = saloon.Seats.ToList();

                foreach (var seat in seats)
                {
                    db.Seats.Remove(seat);
                }
                db.SaveChanges();

                db.Saloons.Remove(saloon);
                db.SaveChanges();


                MessageBox.Show("Salon silme işleminiz başarıyla gerçekleşti", "İnfo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
                FormAddSaloon frm = new FormAddSaloon();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Salon seçiniz", "İnfo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadToSaloons();
        }

        private void FormDeleteSaloon_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Cinematorium.Properties.Resources.salon2jpg;
            LoadToSaloons();
        }

        private void LoadToSaloons()
        {
            cmbSaloons.DisplayMember = "Name";
            cmbSaloons.DataSource = db.Saloons.ToList();
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddSaloon frm = new FormAddSaloon();
            frm.Show();

        }
    }
}
