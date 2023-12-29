﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaombi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool goup; 
        bool godown; 
        bool goleft; 
        bool goright; 
        string facing = "up"; 
        double playerHealth = 100;
        int speed = 10;
        int ammo = 10;
      
        int zombieSpeed = 3; 
        int score = 0;
        bool gameOver = false;
        Random rnd = new Random();
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameOver) return;

           
            if (e.KeyCode == Keys.Left)
            {
                goleft = true; 
                facing = "left";
                
                player.Image = Properties.Resources.left;
            }

          

          
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
              
                facing = "right"; 
                player.Image = Properties.Resources.right;
            }
        

            
            if (e.KeyCode == Keys.Up)
            {
                facing = "up";
                
                goup = true; 
                player.Image = Properties.Resources.up;
            }

        

          
            if (e.KeyCode == Keys.Down)
            {
                facing = "down";
               
                godown = true; 
                player.Image = Properties.Resources.down; 
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (gameOver) return; 

          
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
           
            if (e.KeyCode == Keys.Up)
            {
                goup = false; 
            }
          
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }

          
            if (e.KeyCode == Keys.Space && ammo > 0)

            {
                ammo--; 
                shoot(facing);
                               

                if (ammo < 1) 
                {
                    DropAmmo(); 
                }

            }
        }
        private void sifirla()
        {
            timer1.Enabled = true;
            playerHealth = 100;
            score = 0;
            ammo = 10;
            label2.Text = 0.ToString();  
            gameOver = false;
           
        }
        private void gameEngine(object sender, EventArgs e)
        {
            
            if (playerHealth > 1)
            {
                progressBar1.Value = Convert.ToInt32(playerHealth);
            }
            else
            {

                player.Image = Properties.Resources.dead;
                timer1.Stop();
                gameOver = true;
            }

            label1.Text = "   Ammo:  " + ammo;
            label2.Text = "Kills: " + score;


            if (playerHealth < 20)
            {
                progressBar1.ForeColor = System.Drawing.Color.Red;
            }

            if (goleft && player.Left > 0)
            {
                player.Left -= speed;

            }
            if (goright && player.Left + player.Width < 930)
            {
                player.Left += speed;

            }
            if (goup && player.Top > 60)
            {
                player.Top -= speed;

            }

            if (godown && player.Top + player.Height < 700)
            {
                player.Top += speed;

            }

            foreach (Control x in this.Controls)
            {


                if (x is PictureBox && x.Tag == "ammo")
                {


                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {


                        this.Controls.Remove(((PictureBox)x));

                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }
            


                foreach (Control b in this.Controls)
                {


                    if (b is PictureBox && b.Tag == "kit")
                    {


                        if (((PictureBox)b).Bounds.IntersectsWith(player.Bounds))
                        {


                            this.Controls.Remove(((PictureBox)b));

                           
                            playerHealth += 10;

                        }
                    }
                }



                



                if (x is PictureBox && x.Tag == "bullet")
                    {


                        if (((PictureBox)x).Left < 1 || ((PictureBox)x).Left > 930 || ((PictureBox)x).Top < 10 || ((PictureBox)x).Top > 700)
                        {
                            this.Controls.Remove(((PictureBox)x));
                            ((PictureBox)x).Dispose();
                        }
                    }



                    if (x is PictureBox && x.Tag == "zombie")
                    {



                        if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                        {
                           playerHealth -= 1;

                            
                        }



                        if (((PictureBox)x).Left > player.Left)
                        {
                            ((PictureBox)x).Left -= zombieSpeed;
                            ((PictureBox)x).Image = Properties.Resources.zleft;
                        }

                        if (((PictureBox)x).Top > player.Top)
                        {
                            ((PictureBox)x).Top -= zombieSpeed; 
                            ((PictureBox)x).Image = Properties.Resources.zup;
                        }
                        if (((PictureBox)x).Left < player.Left)
                        {
                            ((PictureBox)x).Left += zombieSpeed;
                            ((PictureBox)x).Image = Properties.Resources.zright;
                        }
                        if (((PictureBox)x).Top < player.Top)
                        {
                            ((PictureBox)x).Top += zombieSpeed;
                            ((PictureBox)x).Image = Properties.Resources.zdown;
                        }
                    }
               
                
                if (playerHealth==0)
                {
                  DialogResult sonuc= MessageBox.Show("GAME OVER "+label2.Text,"Oyun Bitti",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                    timer1.Enabled = false;
                    if (sonuc == DialogResult.Retry)
                    {
                        player.Image = Properties.Resources.up;
                        sifirla();

                    }
                }

                    foreach (Control j in this.Controls)
                    {


                        if ((j is PictureBox && j.Tag == "bullet") && (x is PictureBox && x.Tag == "zombie"))
                        {

                            if (x.Bounds.IntersectsWith(j.Bounds))
                            {
                                score++;
                                this.Controls.Remove(j);
                                j.Dispose();
                                this.Controls.Remove(x);
                                x.Dispose();
                                makeZombies();
                            }
                        }
                    }
                }
            }
        
        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox(); 
            ammo.Image = Properties.Resources.ammo_Image; 
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = rnd.Next(10, 890);
            ammo.Top = rnd.Next(50, 600); 
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            ammo.BringToFront();
            player.BringToFront();

            PictureBox kit = new PictureBox();
            kit.Image = Properties.Resources.can_kiti;
            kit.SizeMode = PictureBoxSizeMode.StretchImage;
            kit.Left = rnd.Next(10, 890);
            kit.Top = rnd.Next(50, 600);
            kit.Tag = "kit";
            this.Controls.Add(kit);
            kit.BringToFront();
            player.BringToFront();
           

        }
        private void kitlan()
        {
       

        }

        private void shoot(string direct)
        {
            bullet shoot = new bullet(); 
            shoot.direction = direct; 
            shoot.bulletLeft = player.Left + (player.Width / 2);
            shoot.bulletTop = player.Top + (player.Height / 2); 
            shoot.mkBullet(this);
         
            
        }
        Form2 frm2 = new Form2();

        private void makeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie"; 
            zombie.Image = Properties.Resources.zdown; 
            zombie.Left = rnd.Next(0, 900); 
            zombie.Top = rnd.Next(0, 800); 
            zombie.SizeMode = PictureBoxSizeMode.AutoSize; 
            this.Controls.Add(zombie); 
            player.BringToFront();

          


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            timer1.Start();
        }
       

    }
}
