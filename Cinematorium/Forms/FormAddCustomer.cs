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
    public partial class FormAddCustomer : Form
    {
        public FormAddCustomer()
        {
            InitializeComponent();
        }
        DatabaseContext db = new DatabaseContext();
  
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Age = Convert.ToInt32(nduAge.Value),
                Gender = Convert.ToChar(txtGender.Text),
                Email = txtEmail.Text,
                Phone = mskPhone.Text

            };
            db.Customers.Add(customer);
            db.SaveChanges();
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }
    }
}
