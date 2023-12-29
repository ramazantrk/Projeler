using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arbaoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
        }
        int yol_hiz = 2;
        int araba_hiz=-5;
        int sure = 0;
        int score = 0;

        Image[]arabalar = new Image[5] { (Properties.Resources.araba1),
         (Properties.Resources.araba2),
        (Properties.Resources.araba3),
        (Properties.Resources.araba4),
        (Properties.Resources.araba5),};
       
        Random rnd = new Random();
        Random degis = new Random();
        Random a1 = new Random();
        Random a2 = new Random();
        Random a3 = new Random();
      
        private void arabalar_haraket()
        {

          

            



            araba1.Top = araba1.Top - araba_hiz;
            araba2.Top = araba2.Top - araba_hiz;
            araba3.Top = araba3.Top - araba_hiz;
           

            if (araba1.Bottom>panel1.Bottom&&araba1.Bottom > 702)
            {
                
                araba1.Top = -rnd.Next( 100,200);
                araba1.Left = a1.Next(1,300);
                araba1.Image = arabalar[degis.Next(1,5)];
            }
            if (araba2.Bottom > panel1.Bottom &&araba2.Bottom>702)
            {
               
                araba2.Top = -rnd.Next(100, 200);
                araba2.Left = a2.Next(1, 200);
                araba2.Image = arabalar[degis.Next(1, 5)];
            }
            if (araba3.Bottom > panel1.Bottom&& araba3.Bottom>702)
            {
            
                araba3.Top = -rnd.Next(100, 200);
                araba3.Left = a3.Next(1, 500);
                araba3.Image = arabalar[degis.Next(1, 5)];
            }
            oyunbitti();
           


        }
        private void arabalaryon()
        {
            if (araba1.Bounds.IntersectsWith(araba2.Bounds) || araba1.Bounds.IntersectsWith(araba3.Bounds))
            {
                araba1.Top = araba1.Top + 250;
                araba1.Left = araba1.Left +100;

            }
            if (araba2.Bounds.IntersectsWith(araba1.Bounds) || araba2.Bounds.IntersectsWith(araba3.Bounds))
            {
                araba2.Top = araba2.Top + 250;
                araba2.Left = araba2.Left + 100;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            arabalar_haraket();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
          
            timer1.Start();
            timersure.Start();
            arabalaryon();
            button1.Enabled = false;
           
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                bool limit = false;
                if (player.Right < 450)
                {
                    limit = true;
                    player.Left = player.Left + 25;
                }

            }
            if (e.KeyCode == Keys.Left)
            {
                bool limit = false;
                if (player.Left > 3)
                {
                    limit = true;
                    player.Left = player.Left - 25;
                }

            }
        }

        private void timersure_Tick(object sender, EventArgs e)
        {
          
            label2.Text = sure.ToString();
            label3.Text = score.ToString();
            for (int i = 0; i < 1; i++)
            {
                sure = sure + 1;
                
            }
            if (sure==10||sure==20 || sure == 30 || sure == 40 || sure == 50 || sure == 60 || sure == 70 || sure == 80 || sure == 90 || sure == 100 || sure == 110 || sure == 120)
            {
                score = score + 1;
            }
            if (score==1||score==2 || score == 3 || score == 4 || score == 5 || score == 6 || score == 7 || score == 8 || score == 9 || score == 10 || score == 12 || score == 14 || score == 16)
            {
                araba_hiz = araba_hiz - 1;
            }
        }
        private void oyunbitti()
        {
           
            if (player.Bounds.IntersectsWith(araba1.Bounds) ||
                player.Bounds.IntersectsWith(araba2.Bounds) ||
                player.Bounds.IntersectsWith(araba3.Bounds))
            {
               
                
                
                timer1.Stop();
                timersure.Stop();
                label2.Text = 0.ToString();
                label3.Text = 0.ToString();
                sure = 0;
                score = 0;
                DialogResult soru= MessageBox.Show("GAME OVER Puanınız :"+label3.Text,"Oyun Bitti",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                if (soru==DialogResult.OK)
                {
                    yenidenbasla();
                }
                button1.Enabled = true;

            }
        }
        private void yenidenbasla()
        {
            araba1.Location = new Point(199,106);
            araba2.Location = new Point(75, 268);
            araba3.Location = new Point(374, 336);
            player.Location = new Point(199, 428);

            araba_hiz = -5;
            timer1.Start();
            timersure.Start();
            arabalaryon();
            button1.Enabled = false;
            
        }

      
    }
}
