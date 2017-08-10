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
    public partial class FormDeleteSession : Form
    {
        public FormDeleteSession()
        {
            InitializeComponent();
        }
        DatabaseContext db = new DatabaseContext();
        private void FormDeleteSession_Load(object sender, EventArgs e)
        {
            LoadToSessions();
        }

        private void LoadToSessions()
        {
            cmbSessions.DataSource = null;
            var session = db.Sessions.ToList();
            cmbSessions.DisplayMember = "StartTime";
            cmbSessions.DataSource = session;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Session session = cmbSessions.SelectedItem as Session;
            db.Sessions.Remove(session);
            db.SaveChanges();
            LoadToSessions();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }
    }
}
