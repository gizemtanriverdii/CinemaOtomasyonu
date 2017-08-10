using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinematorium.DataAccessLayer;
using Cinematorium.Entities;

namespace Cinematorium.Forms
{
    public partial class FormUserProcesses : Form
    {
        public FormUserProcesses()
        {
            InitializeComponent();
        }

        public DatabaseContext db = new DatabaseContext();
        User user = new User();

        private void UserProcesses_Load(object sender, EventArgs e)
        {
            var users = from u in db.User
                        select u;

            dgvUsers.DataSource = users.ToList();
        }

        private void cmbKind_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string employeeKinds = cmbKind.SelectedItem.ToString();

            var users = from u in db.User
                        where u.EmployeeKind == employeeKinds
                        select u;

            dgvUsers.DataSource = users.ToList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormAddUser addUser = new FormAddUser();
            addUser.DgvUsers = dgvUsers;
            addUser.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete the selected item?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                if (dgvUsers.CurrentRow == null)
                    return;

                int userId = (dgvUsers.CurrentRow.DataBoundItem as User).Id;

                user = db.User.FirstOrDefault(x => x.Id == userId);

                if (user == null) return;

                db.User.Remove(user);
                db.SaveChanges();

                dgvUsers.DataSource = db.User.ToList();
            }
            else
            {
                dgvUsers.DataSource = db.User.ToList();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvUsers.DataSource = db.User.ToList();
        }
    }
}
