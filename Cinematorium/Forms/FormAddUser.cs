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
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

        DatabaseContext db = new DatabaseContext();
        public DataGridView DgvUsers;

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please Enter the Name");
            }
            else if (txtSurname.Text == "")
            {
                MessageBox.Show("Please Enter the Surname");
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Please Enter the Username");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter the Password");
            }
            else if (cmbKind.SelectedIndex < 0)
            {
                MessageBox.Show("Please Choose the Employee kind");
            }
            else
            {
                List<User> Users = db.User.ToList();
                foreach (User u in Users)
                {
                    if (u.UserName.ToLower() == txtUsername.Text.ToLower() && u.Password == txtPassword.Text)
                    {
                        txtUsername.Clear();
                        txtPassword.Clear();

                        MessageBox.Show("The Username and The Password you entered already exists in the system.Please enter again.");

                        return;
                    }
                    else if (u.Password == txtPassword.Text)
                    {
                        txtPassword.Clear();

                        MessageBox.Show("The Password you entered already exists in the system.Please enter again.");

                        return;
                    }
                    else if (u.UserName.ToLower() == txtUsername.Text.ToLower())
                    {
                        txtUsername.Clear();

                        MessageBox.Show("The Username you entered already exists in the system.Please enter again.");

                        return;
                    }
                }

                User user = new User()
                {
                    Name = txtName.Text.Trim(),
                    Surname = txtSurname.Text.Trim(),
                    UserName = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    EmployeeKind = cmbKind.SelectedItem.ToString()
                    //StartWorkDate = dtpStartWorkDate,
                    //Salary = numSalary,
                    //IsWorking = chbIsWorking
                };

                db.User.Add(user);
                db.SaveChanges();

                MessageBox.Show("Your registration came true successfully.");
                this.Close();
                DgvUsers.DataSource = null;
                DgvUsers.DataSource = db.User.ToList();
            }
        }
        private void btnGetData_Click(object sender, EventArgs e)
        {
            txtName.Text = DgvUsers.CurrentRow.Cells[4].Value.ToString();
            txtSurname.Text = DgvUsers.CurrentRow.Cells[2].Value.ToString();
            txtUsername.Text = DgvUsers.CurrentRow.Cells[0].Value.ToString();
            txtPassword.Text = DgvUsers.CurrentRow.Cells[3].Value.ToString();
            cmbKind.Text = DgvUsers.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DgvUsers.CurrentRow == null) return;

            int UserID = (DgvUsers.CurrentRow.DataBoundItem as User).Id;
            User u = new User();
            u = db.User.FirstOrDefault(x => x.Id == UserID);

            if (u == null) return;

            u.UserName = txtUsername.Text;
            u.Name = txtName.Text;
            u.Surname = txtSurname.Text;
            u.Password = txtPassword.Text;
            u.EmployeeKind = cmbKind.SelectedItem.ToString();
            db.SaveChanges().ToString();
            DgvUsers.DataSource = db.User.ToList();

            MessageBox.Show("Your registration came true successfully.");

            this.Close();
            FormUserProcesses frm = (FormUserProcesses)Application.OpenForms["UserProcesses"];
            frm.db = db;
        }
    }
}
