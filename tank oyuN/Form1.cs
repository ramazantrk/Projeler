using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tank_oyuN
{
    public partial class Form1 : Form
    {


        bool tank_up = true;
        bool tank_down = false;
        bool tank_left = false;
        bool tank_right = false;

        bool bullet_up = false;
        bool bullet_down = false;
        bool bullet_left = false;
        bool bullet_right = false;
        bool bullet_shooder = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!bullet_shooder)
                {
                    bullet_shooder = true;
                    tank_shoot();
                    
                }
                
            }
            Image up = Properties.Resources.tank_up;
            Image down= Properties.Resources.tank_down;
            Image Left= Properties.Resources.tank_left;
            Image right = Properties.Resources.tank_rigtl;
            if (e.KeyCode==Keys.Up||e.KeyCode==Keys.Down||e.KeyCode==Keys.Left||e.KeyCode==Keys.Right)
            {

                
                if (e.KeyCode == Keys.Up)
                {
                   tank_down = false;
                   tank_left = false;
                   tank_right = false;
                   tank_up = true;
                    tank.Image = up;
                    if (!uplimit())
                    {
                        tank.Top = tank.Top - 5;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    tank_up = false; ;
                    tank_left = false;
                    tank_right = false;
                    tank_down = true;
                    tank.Image = down;
                    if (!downlimit())
                    {

                        tank.Top = tank.Top + 5;
                    }
                }
                if (e.KeyCode == Keys.Left)
                {
                    tank_up = false; ;
                    tank_down = false;
                    tank_right = false;
                    tank_left = true;
                    tank.Image = Left;
                    if (!leftlimit())
                    {
                        tank.Left = tank.Left - 5;
                    }
                }
                if (e.KeyCode == Keys.Right)
                {
                    tank_up = false;
                    tank_down = false;
                    tank_left = false;
                    tank_right = true ;
                    tank.Image = right;
                
                    if (!rightlimit())
                    {
                        tank.Left = tank.Left + 5;
                    }
                   
                }
               
            }
        }

        public bool uplimit()
        {
            bool limit = false;
            if (tank.Top<1)
            {
                limit = true;
            }
            if (!limit)
            {
                foreach (Control c in panel1.Controls)
                {
                    if (c.GetType() == typeof(PictureBox))
                    {
                        PictureBox pb = c as PictureBox;
                        if (pb.Visible && pb.BackColor == Color.OrangeRed
                            && tank.Location.X < pb.Location.X +25 && tank.Location.X > pb.Location.X - 50
                            && tank.Location.Y == pb.Location.Y + 25)
                        {
                            limit = true;
                        }
                    }
                }
            }
            return limit;
        }
        public bool downlimit()
        {
            bool limit = false;
            if (tank.Top > 599)
            {
                limit = true;
            }
            if (!limit)
            {


                foreach (Control c in panel1.Controls)
                {
                    if (c.GetType() == typeof(PictureBox))
                    {
                        PictureBox pb = c as PictureBox;
                        if (tank.Location.Y<pb.Location.Y&&tank.Location.Y>pb.Location.Y
                            &&tank.Location.X==pb.Location.X)
                        {
                            limit = true;
                        }
                    }
                }
            }
            return limit;
        }

        public bool leftlimit()
        {
            bool limit = false;
            if (tank.Left < 1)
            {
                limit = true;
            }
          
            return limit;
        }
        public bool rightlimit()
        {
            bool limit = false;
            if (tank.Left > 599)
            {
                limit = true;
            }
            return limit;
        }
        public void tank_shoot()
        {
            PictureBox bullet_pitrbox = new PictureBox();
            Image img = Properties.Resources.meri;

            bullet_up = false ;
            bullet_down = false;
            bullet_left = false;
            bullet_right = false;

            if (tank_up)
            {
                bullet_pitrbox.Size = new Size(6, 10);
                bullet_pitrbox.Location = new Point(tank.Left + 22,tank.Top - 8);
                bullet_up = true;
                
            }
            if (tank_down)
            {
                bullet_pitrbox.Size = new Size(6, 10);
                bullet_pitrbox.Location = new Point(tank.Left + 22, tank.Top + 50);
                bullet_down = true;
                img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            if (tank_left)
            {
                bullet_pitrbox.Size = new Size(10, 6);
                bullet_pitrbox.Location = new Point(tank.Left -8, tank.Top +22);
                bullet_left = true;
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            if (tank_right)
            {
                bullet_pitrbox.Size = new Size(10, 6);
                bullet_pitrbox.Location = new Point(tank.Left + 50, tank.Top + 22);
                bullet_right = true;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            bullet_pitrbox.BackgroundImage = img;
            bullet_pitrbox.BackgroundImageLayout = ImageLayout.Stretch;
            bullet_pitrbox.Name = "tank_bullet";
            bullet_pitrbox.BackColor = Color.Silver;
            panel1.Controls.Add(bullet_pitrbox);

            Timer tank_timer_bulleet = new Timer();
            tank_timer_bulleet.Interval = 40;
            tank_timer_bulleet.Tick += new EventHandler(tank_timer_bulleet_tick);
            tank_timer_bulleet.Start();
        }
        public void tank_timer_bulleet_tick(object sender,EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c.GetType()==typeof(PictureBox))
                {
                    PictureBox pb = c as PictureBox;
                    if (pb.BackColor==Color.Silver)
                    {
                        if (bullet_up)
                        {
                            pb.Top = pb.Top - 10;
                        }
                        if (bullet_down)
                        {
                            pb.Top = pb.Top + 10;
                        }
                        if (bullet_left)
                        {
                            pb.Left = pb.Left - 10;
                        }
                        if (bullet_right)
                        {
                            pb.Left = pb.Left + 10;
                        }
                        if (pb.Top<0||pb.Top>642|| pb.Left < 0 || pb.Left > 642)
                        {
                            bullet_up = false; 
                            bullet_down = false;
                            bullet_left = false;
                            bullet_right = false;
                            bullet_shooder = false;

                            Timer tm = (Timer)sender;
                            tm.Dispose();
                            pb.Dispose();
                        }
                    }
                }
            }
        }
        
    }
}
