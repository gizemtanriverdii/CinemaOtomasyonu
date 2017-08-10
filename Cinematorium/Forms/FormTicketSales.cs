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

    public partial class FormTicketSales : Form
    {

        private TableLayoutPanel tlp = new TableLayoutPanel();
        private Panel screenPanel = new Panel();
        private Label lblScreenText = new Label();
        string[] alphapets = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z" };
        public Seat _seat;
        public Session _session;
        public Movie _movie;
        public Saloon _saloon;
        public int price1;
        public FormTicketSales()
        {
            InitializeComponent();
        }
        public FormTicketSales(int t)
        {
            dtpsellbyy.Format = DateTimePickerFormat.Custom;
            dtpsellbyy.CustomFormat = "";
        }

        private void CreateSEAt()
        {
            DatabaseContext db = new DatabaseContext();

            int counter = 0;
            //Koltukların ve sinema ekranının gösterileceği en dış panel ve onun içerisinde koltukların gösterileceği bir table panel oluşturulu.
            //Her oluştura basıldığında bu panellerin içerisindekicontroller temizlenir.
            pnlSeat.Controls.Clear();
            tlp.Controls.Clear();

            //Sinema ekranının paneli düzenlenir.
            screenPanel.Width = (pnlSeat.Width / 5) * 3;
            screenPanel.Height = 40;
            screenPanel.BackColor = Color.White;
            screenPanel.BorderStyle = BorderStyle.FixedSingle;

            //Ekran paneli koltukların gösterildiği panele eklenir. Ve lokasyonu belirlenir.
            pnlSeat.Controls.Add(screenPanel);
            screenPanel.Location = new Point((pnlSeat.Width - screenPanel.Width) / 2, 0);

            //Sinema ekranının yazısı label içerisine yazılır ve label düzenlenir.
            lblScreenText.ForeColor = Color.Black;
            lblScreenText.Text = "Screen";

            //Label, Sinema ekranı paneline eklenir. Ve lokasyonu belirlenir.
            screenPanel.Controls.Add(lblScreenText);
            lblScreenText.Location = new Point((screenPanel.Width - lblScreenText.Width) / 2 + (lblScreenText.Width / 4), (screenPanel.Height - lblScreenText.Height) / 2);
            List<Seat> seat_ = null;
            seat_ = DatabaseSeat();
            //Koltukların olacağı table panel düzenlenir.
            tlp.Dock = DockStyle.None;
            Saloon saloon = new Saloon();
            foreach (var s in seat_)
            {
                saloon = s.Saloon;
                _saloon = saloon;
                break;
            }

            tlp.Dock = DockStyle.None;

            tlp.ColumnCount = saloon.columnnumber + 1;

            tlp.RowCount = saloon.rownumber + 1;

            tlp.Size = new Size((58 * saloon.columnnumber + 10), 70 * saloon.rownumber);

            bool IsSameRow = false;
            //Koltuklar button şeklinde oluşturulur ve table panele eklenir.
            for (int i = 0; i < saloon.rownumber; i++)
            {
                IsSameRow = false;

                for (int j = 0; j < saloon.columnnumber; j++)
                {
                    if (IsSameRow == false)
                    {
                        Label lbl = new Label();
                        lbl.Location = new Point(seat_[counter].X - 30, seat_[counter].Y + 20);
                        lbl.Size = new Size(15, 60);
                        lbl.Text = alphapets[i];
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        IsSameRow = true;
                        tlp.Controls.Add(lbl, 0, i);
                        lbl.BackColor = Color.LightGray;
                    }
                    Button btn = new Button();

                    btn.Size = new Size(50, 60);
                    btn.Location = new Point(seat_[counter].X, seat_[counter].Y);
                    btn.Text = seat_[counter].SeatNo.ToString();

                    btn.Click += Btn_Click; ;
                    btn.BackColor = Color.LightGreen;
                    btn.Image = Properties.Resources.seat;
                    btn.ImageAlign = ContentAlignment.TopCenter;
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.TextImageRelation = TextImageRelation.ImageAboveText;
                    btn.Anchor = AnchorStyles.None;
                    if (seat_[counter].SeatBroken == true)
                    {
                        btn.Enabled = false;
                    }
                    else if (seat_[counter].SeatHandicap == true)
                    {
                        btn.Image = null;
                        btn.BackColor = Color.Yellow;
                        btn.BackgroundImageLayout = ImageLayout.Zoom;
                        btn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.if_Wheelchair_Accessible_751069));

                    }
                    else if (seat_[counter].Wiped_Seat == true)
                    {
                        btn.Visible = false;

                    }
                    if (db.Tickets != null)
                    {
                        IEnumerable<Ticket> tickets = db.Tickets;

                        foreach (var tickt in tickets)
                        {
                            if (tickt.Seat.Id == seat_[counter].Id)
                            {
                                btn.BackColor = Color.Red;
                                break;
                            }
                        }
                    }
                    tlp.Controls.Add(btn, j + 1, i);
                    counter++;
                }
            }
            pnlSeat.Controls.Add(tlp);

            //Table panel dış panele göre tam ortaya konumlandırılır.
            tlp.Location = new Point((pnlSeat.Width - tlp.Width) / 2 + 5, 60);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button selected_btn = (Button)sender;

            selected_btn.BackColor = Color.DarkRed;

            DatabaseContext db = new DatabaseContext();

            IEnumerable<Seat> seats = db.Seats;

            foreach (var seat in seats)
            {
                if (seat.SeatNo == Convert.ToInt32(selected_btn.Text))
                {
                    _seat = seat;

                    selected_seat.Text = seat.SeatChar + " - " + seat.SeatNo;
                }
            }
        }

        public List<Seat> DatabaseSeat()
        {
            DatabaseContext db = new DatabaseContext();

            string saloon = cmbSaloonname.SelectedItem.ToString();

            List<Seat> seats = null;
            List<Seat> sess = db.Seats.ToList();
            if (saloon != null)
            {
                var Seatss = (from s in sess
                              where s.Saloon.Name == saloon
                              select s);
                seats = Seatss.ToList();
            }

            return seats;
        }

        private void LoadToCmbMovie()
        {

            DateTime ticketdate = dtpsellbyy.Value.Date;
            cmbmovies.DataSource = null;
            DatabaseContext db = new DatabaseContext();
            var movies = db.Movies.Where(x => x.PublishDate <= ticketdate && x.DueDate >= ticketdate).Select(x => x.Name).Distinct().ToList();
            cmbmovies.DataSource = movies;
        }

        private void dtpsellby_ValueChanged(object sender, EventArgs e)
        {
            LoadToCmbMovie();
        }

        private void LoadToCmbSaloons()
        {
            DatabaseContext db = new DatabaseContext();
            if (cmbmovies.SelectedIndex > -1 && cmbsessions.SelectedIndex > -1)
            {
                cmbSaloonname.DataSource = null;
                string moviename = cmbmovies.SelectedItem.ToString();

                string session = cmbsessions.SelectedItem.ToString();

                TimeSpan s = Convert.ToDateTime(session).TimeOfDay;
                if (moviename != "" & session != null)
                {
                    var query = from p in db.Movies
                                from ed in p.Sessions
                                from r in p.Saloons
                                where p.Name == moviename && ed.StartTime == s
                                select r.Name;
                    cmbSaloonname.DataSource = query.ToList();
                }
            }
        }

        private void cmbmovies_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //LoadToSessions();
            List<Session> sessions = new List<Session>();
            cmbsessions.DataSource = null;

            DatabaseContext db = new DatabaseContext();

            string movieName = cmbmovies.SelectedItem.ToString();
            DateTime date = dtpsellbyy.Value.Date;

            if (cmbmovies.SelectedIndex > -1)
            {
                if (movieName != "")
                {
                    IEnumerable<Movie> movies = db.Movies;
                    foreach (var m in movies)
                    {
                        if (m.Name == movieName)
                        {
                            _movie = m;
                            sessions = m.Sessions;
                        }
                    }
                    cmbsessions.DataSource = sessions.Select(x => x.StartTime).Distinct().ToList();
                }
            }
        }


        private void cmbsessions_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadToCmbSaloons();
        }

        private void cmbSaloonname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CreateSeat();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            DatabaseContext db = new DatabaseContext();

            FormLogin frm = new FormLogin();
            string price = cmbprice.SelectedItem.ToString();

            if (price == "TAM: 5₺")
            {
                price1 = 5;
            }
            else if (price == "ÖĞRENCİ: 3₺")
            {
                price1 = 3;
            }
            
            IEnumerable<Session> sessions = db.Sessions;

            foreach (var session in sessions)
            {
                if (session.StartTime == Convert.ToDateTime(cmbsessions.SelectedItem.ToString()).TimeOfDay)
                {
                    _session = session;
                }
            }
            Movie moviee = new Movie();
            Saloon saloon = new Saloon();
            Seat seat = new Seat();

            IEnumerable<Saloon> slnns = db.Saloons;

            foreach (var slnn in slnns)
            {
                if (slnn.Id == _saloon.Id)
                {
                    saloon = slnn;
                    break;
                }
            }

            IEnumerable<Movie> movies = db.Movies;

            foreach (var movie in movies)
            {
                if (movie.Id == _movie.Id)
                {
                    moviee = movie;
                    break;
                }
            }
            IEnumerable<Seat> seats = db.Seats;

            foreach (var st in seats)
            {
                if (st.Id == _seat.Id)
                {
                    seat = st;
                    break;
                }
            }


            if (db.Tickets != null)
            {
                IEnumerable<Ticket> tickets = db.Tickets;

                foreach (var tickt in tickets)
                {
                    if (tickt.Seat.Id == _seat.Id)
                    {
                        MessageBox.Show("Bu koltuk Satılmıştır.Başka koltuk seçiniz.");
                        break;
                    }
                }
            }

            Ticket ticket = new Ticket()
            {
                Id = Guid.NewGuid(),
                SellBy = DateTime.Now.Date,
                MovieDay = dtpsellbyy.Value,
                Price = price1,
                Movie = moviee,
                Saloon = saloon,
                Seat = seat,
                Session = _session
            };

            db.Tickets.Add(ticket);

            db.SaveChanges();
            MessageBox.Show("Bilet Satış İşlemi başarıyla gerçekleştirilmiştir.", "Bilet Satışı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbsessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadToCmbSaloons();
        }

        private void dtpsellbyy_ValueChanged(object sender, EventArgs e)
        {

            LoadToCmbMovie();
        }

        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddMovie frm = new FormAddMovie();
            frm.Show();
            this.Hide();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddCustomer frm = new FormAddCustomer();
            frm.Show();
            this.Hide();
        }

        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormAddSession frm = new FormAddSession();
            frm.Show();
            this.Hide();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();

        }
    }
}

