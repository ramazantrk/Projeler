using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yılanoyunu
{
    public partial class Yılan_Oyunu : Form
    {
        private Label yılan_kafası;
        private int yılanparcasıarasımesafe = -2;
        private int yılanparcasayısı;
        private int yılanboyutu = 20;
        private int yemboyutu = 20;
        private Label yem;
        private Random random;
        private Hareketyönü yon;
        public Yılan_Oyunu()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Yılan_Oyunu_Load(object sender, EventArgs e)
        {

            sıfırlar();


        }
        private void yenidenBaslat()
        {
            label3.Text = "0";
            label5.Text = "0";
            sıfırlar();

        }
        private void sıfırlar()
        {
            panel1.Controls.Clear();
            yılanparcasayısı = 0;
            yılanparcasayısı = 0;
            yemolustur();
            yem_yer_degis();
            yılan_yerlestir();
            yon = Hareketyönü.Saga;
            timeryılan_hareket.Enabled = true;
            sure.Enabled = true;
        }


        private Label yılanparcasıolustur(int locationX, int locationY)
        {
            yılanparcasayısı++;
            Label lbl = new Label()
            {
                Name = "yılanParca" + yılanparcasayısı,
                BackColor = Color.Red,
                Width = yılanboyutu,
                Height = yılanboyutu,


            };
            this.panel1.Controls.Add(lbl);
            return lbl;
        }
        private void yılan_yerlestir()
        {
            yılan_kafası = yılanparcasıolustur(0, 0);
            yılan_kafası.Text = ":";
            yılan_kafası.TextAlign = ContentAlignment.MiddleCenter;
            yılan_kafası.ForeColor = Color.White;
            var locationX = (panel1.Width / 2) - (yılan_kafası.Width / 2);
            var locationY = (panel1.Height / 2) - (yılan_kafası.Height / 2);
            yılan_kafası.Location = new Point(locationX, locationY);
        }
        private void yemolustur()
        {
            Label lbl = new Label()
            {
                Name = "yem" + yılanparcasayısı,
                BackColor = Color.Yellow,
                Width = yemboyutu,
                Height = yemboyutu,

            };
            this.panel1.Controls.Add(lbl);
            yem = lbl;
        }
        private void yem_yer_degis()
        {
            var locationX = 0;
            var locationY = 0;
            bool durum = false;
            do
            {
                durum = false;
                locationX = random.Next(0, panel1.Width - yemboyutu);
                locationY = random.Next(0, panel1.Height - yemboyutu);
                var rect1 = new Rectangle(new Point(locationX, locationY), yem.Size);
                foreach (Control control in panel1.Controls)
                {
                    if (control is Label && control.Name.Contains("Yılanparca"))
                    {
                        var rect2 = new Rectangle(control.Location, control.Size);
                        if (rect1.IntersectsWith(rect2))
                        {
                            durum = true;
                            break;
                        }
                    }
                }
            } while (durum);

            yem.Location = new Point(locationX, locationY);
        }
        private enum Hareketyönü
        {
            Yukari,
            Asagi,
            Sola,
            Saga,
        }

        private void Yılan_Oyunu_KeyDown(object sender, KeyEventArgs e)
        {
            var keycode = e.KeyCode;
            if (yon == Hareketyönü.Sola && keycode == Keys.Right
                && yon == Hareketyönü.Saga && keycode == Keys.Left
                 && yon == Hareketyönü.Yukari && keycode == Keys.Up
                  && yon == Hareketyönü.Asagi && keycode == Keys.Down)
            {
                return;
            }
            switch (keycode)
            {
                case Keys.Up:
                    yon = Hareketyönü.Yukari;
                    break;
                case Keys.Down:
                    yon = Hareketyönü.Asagi;
                    break;
                case Keys.Left:
                    yon = Hareketyönü.Sola;
                    break;
                case Keys.Right:
                    yon = Hareketyönü.Saga;
                    break;
                case Keys.P:
                    timeryılan_hareket.Enabled = false;
                    sure.Enabled = false;
                    break;
                case Keys.C:
                    timeryılan_hareket.Enabled = true;
                    sure.Enabled = true;
                    break;
                default:
                    break;




            }
        }

        private void timeryılan_hareket_Tick(object sender, EventArgs e)
        {
            YılankafasınıTakipet();
            yılanıyurut();
            OyunBittimi();
            Yılanyemiyedimi();

        }



        private void yılanıyurut()
        {
            var locationX = yılan_kafası.Location.X;
            var locationY = yılan_kafası.Location.Y;
            switch (yon)
            {
                case Hareketyönü.Yukari:
                    yılan_kafası.Location = new Point(locationX, locationY - (yılan_kafası.Width - yılanparcasıarasımesafe));
                    break;
                case Hareketyönü.Asagi:
                    yılan_kafası.Location = new Point(locationX, locationY + (yılan_kafası.Width - yılanparcasıarasımesafe));
                    break;
                case Hareketyönü.Sola:
                    yılan_kafası.Location = new Point(locationX - (yılan_kafası.Width - yılanparcasıarasımesafe), locationY);
                    break;
                case Hareketyönü.Saga:
                    yılan_kafası.Location = new Point(locationX + (yılan_kafası.Width - yılanparcasıarasımesafe), locationY);
                    break;
                default:
                    break;
            }
        }
        private void OyunBittimi()
        {
            bool Oyunbittimi = false;

            var rect1 = new Rectangle(yılan_kafası.Location, yılan_kafası.Size);

            foreach (Control control in panel1.Controls)
            {
                if (control is Label && control.Name.Contains("yılanParca") && control.Name != yılan_kafası.Name)
                {
                    var rect2 = new Rectangle(control.Location, control.Size);
                    if (rect1.IntersectsWith(rect2))
                    {
                        Oyunbittimi = true;
                        break;
                    }
                }
            }
            if (yılan_kafası.Bounds.IntersectsWith(label6.Bounds)||
                yılan_kafası.Bounds.IntersectsWith(label7.Bounds)||
                yılan_kafası.Bounds.IntersectsWith(label8.Bounds) ||
                yılan_kafası.Bounds.IntersectsWith(label9.Bounds))
            {
                Oyunbittimi = true;
                

            }
            if (Oyunbittimi)
            {
                timeryılan_hareket.Enabled = false;
                sure.Enabled = false;
                DialogResult sonuc = MessageBox.Show("Puanınız :" + label3.Text, "Oyun Bitti", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (sonuc == DialogResult.OK)
                {
                    yenidenBaslat();
                }
            }
        }



        private void Yılanyemiyedimi()
        {
            var rect1 = new Rectangle(yılan_kafası.Location, yılan_kafası.Size);
            var rect2 = new Rectangle(yem.Location, yem.Size);

            if (rect1.IntersectsWith(rect2))
            {
                label3.Text = (Convert.ToInt32(label3.Text) + 10).ToString();
                yem_yer_degis();
                yılanparcasıolustur(-yılanboyutu, -yılanboyutu);
            }
        }
        private void YılankafasınıTakipet()
        {
            if (yılanparcasayısı <= 1) return;
            for (int i = yılanparcasayısı; i > 1; i--)
            {
                var sonrakiParça = (Label)panel1.Controls[i];
                var oncekiParça = (Label)panel1.Controls[i - 1];

                sonrakiParça.Location = oncekiParça.Location;
            }
        }

        private void sure_Tick(object sender, EventArgs e)
        {
            label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
