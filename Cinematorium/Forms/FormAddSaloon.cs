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
    public partial class FormAddSaloon : Form
    {
        public User LoginUser { get; set; }
        private TableLayoutPanel tlp = new TableLayoutPanel();
        private Panel screenPanel = new Panel();
        private Label lblScreenText = new Label();
    
        string[] alphapets = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z" };
        public FormAddSaloon()
        {
          
            InitializeComponent();
        }
        public int rowNumber { get; set; }
        public int collumnNumber { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Cinematorium.Properties.Resources.salon3;
        }

        #region Koltuk oluşturma

        public void CreateSeat(int row, int collumn)
        {
            //Koltukların ve sinema ekranının gösterileceği en dış panel ve onun içerisinde koltukların gösterileceği bir table panel oluşturuldu.
            //Her oluştura basıldığında bu panellerin içerisindeki controller temizlenir.
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

            //Koltukların olacağı table panel düzenlenir.
            tlp.Dock = DockStyle.None;
            tlp.ColumnCount = Convert.ToInt32(nudCollumn.Value) + 1;
            tlp.RowCount = Convert.ToInt32(nudRow.Value) + 1;
            tlp.Size = new Size((58 * Convert.ToInt32(nudCollumn.Value)) + 10, 70 * Convert.ToInt32(nudRow.Value));
              bool IsSameRow = false;
            //Koltuklar button şeklinde oluşturulur ve table panele eklenir.
            for (int i = 0; i < row; i++)
            {
                IsSameRow = false;

                for (int j = 0; j < collumn; j++)
                {
                    if (IsSameRow == false)
                    { 
                        Label lbl = new Label();
                        lbl.Location = new Point(i * 50 - 10, j * 60 );
                        lbl.Size = new Size(15, 60);
                        lbl.Text = alphapets[i];
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        IsSameRow = true;
                        tlp.Controls.Add(lbl, 0, i);
                        lbl.BackColor = Color.LightGray;
                    }

                    Button btn = new Button();

                    btn.Size = new Size(50, 60);
                    btn.Location = new Point(i * 50 + 20, j * 60 + 20);
                    btn.Text = (j + 1).ToString();

                    btn.ContextMenuStrip = contextMenuStrip1;
                    btn.MouseEnter += Btn_MouseEnter;
                    btn.BackColor = Color.Aqua;
                    btn.Image = Properties.Resources.seat;
                    btn.ImageAlign = ContentAlignment.TopCenter;
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.TextImageRelation = TextImageRelation.ImageAboveText;
                    btn.Anchor = AnchorStyles.None;

                    tlp.Controls.Add(btn, j + 1, i);
                }
            }

            pnlSeat.Controls.Add(tlp);
           
            //Table panel dış panele göre tam ortaya konumlandırılır.
            tlp.Location = new Point((pnlSeat.Width - tlp.Width) / 2 + 5, 60);
        }

        private void btnCreateSaloon_Click(object sender, EventArgs e)
        {
            rowNumber = Convert.ToInt32(nudRow.Value);
            collumnNumber = Convert.ToInt32(nudCollumn.Value);
            if (txtSaloonName.Text != "" && nudCollumn.Value > 0 && nudRow.Value > 0)
            {
                CreateSeat(rowNumber, collumnNumber);
            }

            else if (txtSaloonName.Text == "" && nudCollumn.Value > 0 && nudCollumn.Value > 0)
            {
                MessageBox.Show("Lütfen Salon Adını Giriniz!", "Hay Aksi Bir Sorun Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nudCollumn.Value == 0 && nudCollumn.Value < 0)
            {
                MessageBox.Show("Lütfen Sütun Sayısını 0 dan büyük giriniz!", "Hay Aksi Bir Sorun Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nudRow.Value == 0 && nudRow.Value < 0)
            {
                MessageBox.Show("Lütfen Satır Sayısını 0 dan büyük giriniz!", "Hay Aksi Bir Sorun Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nudRow.Value > 0 && nudCollumn.Value <= 0)
            {
                MessageBox.Show("Lütfen Sütun Sayısını 0 dan büyük giriniz!", "Hay Aksi Bir Sorun Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nudRow.Value <= 0 && nudCollumn.Value > 0)
            {
                MessageBox.Show("Lütfen Satır Sayısını 0 dan büyük giriniz!", "Hay Aksi Bir Sorun Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSaloonName.Text == "" && nudCollumn.Value <= 0 && nudCollumn.Value <= 0)
            {
                MessageBox.Show("Lütfen Salon Adını ,Satır Sayısını ve Sütun Sayısını Giriniz!", "Hay Aksi Bir Sorun Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSaloonName.Text != "" && nudCollumn.Value <= 0 && nudCollumn.Value <= 0)
            {
                MessageBox.Show("Lütfen Satır Sayısını ve Sütun Sayısını 0' dan büyük giriniz!", "Hay Aksi Bir Sorun Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Resize Fonksiyonları

        private void pnlSeat_Resize(object sender, EventArgs e)
        {
            screenPanel.Width = (pnlSeat.Width / 5) * 3;
            screenPanel.Location = new Point((pnlSeat.Width - screenPanel.Width) / 2, 0);

            lblScreenText.Location = new Point((screenPanel.Width - lblScreenText.Width) / 2 + (lblScreenText.Width / 4), (screenPanel.Height - lblScreenText.Height) / 2);

            tlp.Location = new Point((pnlSeat.Width - tlp.Width) / 2, 60);
        }

        private void FormAddSaloon_Resize(object sender, EventArgs e)
        {
            pnlControls.Location = new Point((this.Width - pnlControls.Width) / 2, pnlControls.Location.Y);
        }

        #endregion

        #region Menu Fonksiyonları
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            silToolStripMenuItem.Tag = btn;
            engelliKoltuğuYapToolStripMenuItem.Tag = btn;
            bozukKoltukYapToolStripMenuItem.Tag = btn;
        }
        private void engelliKoltuğuYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            Button handicap = (Button)item.Tag;
            Seat seat = new Seat();
            if (seat.X == handicap.Location.X && seat.Y == handicap.Location.Y)
            {
                seat.SeatHandicap = true;

            }
            handicap.Image = null;
            handicap.BackColor = Color.Yellow;
            handicap.BackgroundImageLayout = ImageLayout.Zoom;
            handicap.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.if_Wheelchair_Accessible_751069));
        }

        private void bozukKoltukYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            Button temp = (Button)item.Tag;

            temp.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FormDeleteSaloon frm = new FormDeleteSaloon();
            frm.Show();
            this.Hide();
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            Button temp = (Button)item.Tag;

            temp.Visible = false;
            bool IsFind = false;
            string SeatNo = "";
            int Y = temp.Location.Y;
            int X = temp.Location.X;
            foreach (Control buton in tlp.Controls)
            {
                if (IsFind == true && buton.Location.Y == Y)
                {
                    buton.Text = SeatNo;
                    int No = Convert.ToInt32(SeatNo);
                    No++;
                    SeatNo = No.ToString();
                    if (buton.Text == rowNumber.ToString())
                    {
                        IsFind = false;
                    }
                }

                if (buton.Location.Y == Y && buton.Location.X == X)
                {
                    IsFind = true;
                    SeatNo = buton.Text;
                }

            }
        }

        private void pnlSeat_MouseEnter(object sender, EventArgs e)
        {
            pnlSeat.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nudCollumn.Value = 0;
            nudRow.Value = 0;
            pnlSeat.Controls.Clear();
            txtSaloonName.Text = "";
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            Save();
            this.Hide();
            FormManager frm = new FormManager();
            frm.Show();
        }

        public void Save()
        {
            Saloon saloon = new Saloon();
            saloon.Name = txtSaloonName.Text;
            saloon.columnnumber = collumnNumber;
            saloon.rownumber = rowNumber;
            DatabaseContext db = new DatabaseContext();
            
                  var name = db.Saloons.Where(x => x.Name == saloon.Name).Select(x => x.Name).FirstOrDefault();
            if (string.IsNullOrEmpty(name))
            {
                db.Saloons.Add(saloon);
                db.SaveChanges();
                foreach (Control btn in tlp.Controls)
                {
                    if (btn.GetType() == typeof(Button))
                    {
                        Seat seat = new Seat();
                        if (btn.Enabled == true)
                        {
                            seat.SeatBroken = false;
                        }
                        else
                        {
                            seat.SeatBroken = true;
                        }
                        //string seatchar = CreateSeatChar(seat);
                        //string[] gg = { seatchar };/*'a';Convert.ToChar(gg[0]);*/
                        if (btn.Visible == false)
                        {
                            seat.Wiped_Seat = true;
                        }
                        else
                        {
                            seat.Wiped_Seat = false;
                        }
                        seat.SeatChar = alphapets[Convert.ToInt32(btn.Text) - 1];
                        seat.SeatNo = Convert.ToInt32(btn.Text);
                        if (btn.BackColor == Color.Yellow)
                        {
                            seat.SeatHandicap = true;
                        }
                        else
                        {
                            seat.SeatHandicap = false;
                        }
                        seat.X = btn.Location.X;
                        seat.Y = btn.Location.Y;
                        seat.Saloon = saloon;

                        db.Seats.Add(seat);
                    }

                }
                db.SaveChanges();
                MessageBox.Show("Salon kaydetme işleminiz başarıyla gerçekleşti", "İnfo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else 
            {
                MessageBox.Show("Bu salon mevcuttur");
                
            }
          
        }

        #endregion
        public string CreateSeatChar(Seat seat)
        {
            string labeltext=null;
            foreach (Control contr in tlp.Controls)
            {
                if (contr.GetType() == typeof(Label))
                {  
                    if (contr.Location.X == seat.X)
                    {
                        labeltext = (contr.Text);
                    }
                }
            }
            return labeltext;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }
    }

}
