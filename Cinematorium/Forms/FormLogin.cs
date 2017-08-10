using Cinematorium.DataAccessLayer;
using Cinematorium.Entities;
using Cinematorium.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinematorium
{
    public partial class FormLogin : Form
    {
        public User user1 = new User();

        private Color hint = Color.FromArgb(97, 97, 97);
        private bool flagTxtUsername = false;
        private bool flagTxtPassword = false;


        public FormLogin()
        {
            InitializeComponent();
        }

        #region Username Hint Fonksiyonları

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (!flagTxtUsername)
                txtUsername.Clear();
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == string.Empty)
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = hint;
                flagTxtUsername = false;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.ForeColor = Color.Black;
            flagTxtUsername = true;
        }

        #endregion

        #region Password Hint Fonksiyonları

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';

            if (!flagTxtPassword)
                txtPassword.Clear();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == string.Empty)
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = hint;
                flagTxtPassword = false;
                txtPassword.PasswordChar = '\0';
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            flagTxtPassword = true;
        }

        #endregion

        private void FormLogin_Click(object sender, EventArgs e)
        {
            amacsiz.Focus();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!flagTxtUsername && !flagTxtPassword)
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!flagTxtUsername)
                MessageBox.Show("Lütfen kullanıcı adınızı boş bırakmayınız.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!flagTxtPassword)
                MessageBox.Show("Lütfen şifrenizi boş bırakmayınız.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string Username = txtUsername.Text.Trim();
                string Password = txtPassword.Text.Trim();
                DatabaseContext db = new DatabaseContext();

                List<User> Users = db.User.ToList();
                foreach (User user in Users)
                {
                    if (user.UserName.ToLower() == Username.ToLower() && user.Password == Password)
                    {
                        if (user.EmployeeKind == "Manager")
                        {
                            user1 = user;
                            FormManager frm = new FormManager();
                            frm.Show();
                            this.Hide();
                        }
                        else if (user.EmployeeKind == "Employee")
                        {
                            FormTicketSales frm = new FormTicketSales();
                            frm.Show();
                            this.Hide();
                        }
                        else if (user.EmployeeKind == "Account")
                        {
                            FormAccountant frm = new FormAccountant();
                            frm.Show();
                            this.Hide();
                        }

                        txtUsername.Clear();
                        txtPassword.Clear();
                        return;
                    }
                }

                MessageBox.Show("Hatalı kullanıcı adı ya da şifre.");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

            User admin = new User()
            {
                UserName = "admin",
                Password = "123",
                EmployeeKind = "Manager",
                Name = "Gizem",
                Surname = "Tanrıverdi",
                IsWorking = true,
                Salary = 10,
                StartWorkDate = DateTime.Now.Date
            };
            DatabaseContext db = new DatabaseContext();
            var name = db.User.Where(x => x.Name == admin.Name).Select(x => x.Name);
            if (name == null)
            {
                db.User.Add(admin);
                db.SaveChanges();
            }

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FormTicketSales frm = new FormTicketSales();
            frm.Show();
            this.Hide();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            FormManager frm = new FormManager();
            frm.Show();
            this.Hide();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            FormAccountant frm = new FormAccountant();
            frm.Show();
            this.Hide();
        }
    }
}
