using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Among_Us
{
    public partial class Form1 : Form
    {
        bool player1_left = true;
        bool player1_right = false;
        bool player1_Move_left = true;
        bool player1_Move_right = false;
        bool player1_Move_up = false;
        bool player1_Move_down = false;
        bool player1_stop = true;
        bool player1_first_movement = false;
        bool player1_this = false;
        bool player1_onile = false;
        bool player1_ready = false;
        bool player1_alive = false;



        bool player2_left = true;
        bool player2_right = false;
        bool player2_Move_left = true;
        bool player2_Move_right = false;
        bool player2_Move_up = false;
        bool player2_Move_down = false;
        bool player2_stop = true;
        bool player2_first_movement = false;
        bool player2_this = false;
        bool player2_onile = false;
        bool player2_ready = false;
        bool player2_alive = false;


       
        public Form1()
        {
            InitializeComponent();
            
        }
      
            


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                player1_stop = false;
                this_player_timer1.Enabled = true;

            }
            if (e.KeyCode == Keys.Right)
            {
                player1_right = true;
                player1_left = false;

                player1_Move_right = true;
                player1_Move_left = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                player1_left = true;
                player1_right = false;

                player1_Move_left = true;
                player1_Move_right = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                player1_Move_up = true;
                player1_Move_down = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                player1_Move_down = true;
                player1_Move_up = false;
            }

        

    }

   
            
        

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                player1_stop = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                player1_Move_right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                player1_Move_left = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                player1_Move_up = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                player1_Move_down = false;
            }
        }
        
            
        
        private void this_player_timer1_Tick(object sender, EventArgs e)
        {
            Image img = null;
            if (!player1_stop)
            {
                if (player1_first_movement)
                {
                    img = Properties.Resources.red_1;

                    player1_first_movement = false;
                }

                else
                {
                    img = Properties.Resources.red_2;

                    player1_first_movement = true;
                }
                if (player1_Move_right && !right_limits())
                {
                    Map_pictureBox1.Left = Map_pictureBox1.Left - 10;
                    
                }
                else if (player1_Move_left && !left_limits())
                {
                    Map_pictureBox1.Left = Map_pictureBox1.Left + 10;
        
                }
                else if (player1_Move_up && !up_limits())
                {
                    Map_pictureBox1.Top = Map_pictureBox1.Top + 10;
                 
                }
                else if (player1_Move_down && !down_limits())
                {
                    Map_pictureBox1.Top = Map_pictureBox1.Top - 10;
                  
                }
            }
            else
            {
                player1_first_movement = true;
                this_player_timer1.Enabled = false;

                img = Properties.Resources.red_stop; 
            }
            if (player1_right)
            {
                img.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
            player1_pictureBox1.BackgroundImage = img;

        }
        public bool right_limits()
        {
            bool limit = false;

            if ((Map_pictureBox1.Left == -10 && Map_pictureBox1.Top <= -120 && Map_pictureBox1.Top >= -290) ||
                (Map_pictureBox1.Left == -10 && Map_pictureBox1.Top <= -320 && Map_pictureBox1.Top >= -1090) ||
                (Map_pictureBox1.Left == -110 && Map_pictureBox1.Top <= 100 && Map_pictureBox1.Top >= 10) ||
                (Map_pictureBox1.Left == -110 && Map_pictureBox1.Top <= -20 && Map_pictureBox1.Top >= -110) ||
                (Map_pictureBox1.Left == -110 && Map_pictureBox1.Top <= -1100 && Map_pictureBox1.Top >= -1190) ||
                (Map_pictureBox1.Left == -110 && Map_pictureBox1.Top <= -1220 && Map_pictureBox1.Top >= -1310) ||
                (Map_pictureBox1.Left == -310 && Map_pictureBox1.Top <= -200 && Map_pictureBox1.Top >= -810) ||
                (Map_pictureBox1.Left == -410 && Map_pictureBox1.Top <= -1020 && Map_pictureBox1.Top >= -1090) ||
                (Map_pictureBox1.Left == -410 && Map_pictureBox1.Top <= -1120 && Map_pictureBox1.Top >= -1210) ||
                (Map_pictureBox1.Left == -510 && Map_pictureBox1.Top <= -20 && Map_pictureBox1.Top >= -190) ||
                (Map_pictureBox1.Left == -710 && Map_pictureBox1.Top <= -200 && Map_pictureBox1.Top >= -510) ||
                (Map_pictureBox1.Left == -710 && Map_pictureBox1.Top <= -700 && Map_pictureBox1.Top >= -1010) ||
                (Map_pictureBox1.Left == -1110 && Map_pictureBox1.Top <= -420 && Map_pictureBox1.Top >= -590) ||
                (Map_pictureBox1.Left == -1110 && Map_pictureBox1.Top <= -620 && Map_pictureBox1.Top >= -790) ||
                (Map_pictureBox1.Left == -1210 && Map_pictureBox1.Top <= -800 && Map_pictureBox1.Top >= -990) ||
                (Map_pictureBox1.Left == -1210 && Map_pictureBox1.Top <= -1020 && Map_pictureBox1.Top >= -1310) ||
                (Map_pictureBox1.Left == -1410 && Map_pictureBox1.Top <= -100 && Map_pictureBox1.Top >= 10) ||
                (Map_pictureBox1.Left == -1410 && Map_pictureBox1.Top <= -20 && Map_pictureBox1.Top >= -410) ||
                (Map_pictureBox1.Left == -1410 && Map_pictureBox1.Top <= -1000 && Map_pictureBox1.Top >= -1190) ||
                (Map_pictureBox1.Left == -1510 && Map_pictureBox1.Top <= -600 && Map_pictureBox1.Top >= -810) ||
                (Map_pictureBox1.Left == -1710 && Map_pictureBox1.Top <= -300 && Map_pictureBox1.Top >= -380) ||
                (Map_pictureBox1.Left == -1710 && Map_pictureBox1.Top <= -420 && Map_pictureBox1.Top >= -710) ||
                (Map_pictureBox1.Left == -1810 && Map_pictureBox1.Top <= -120 && Map_pictureBox1.Top >= -1090) ||
                (Map_pictureBox1.Left == -1910 && Map_pictureBox1.Top <= 100 && Map_pictureBox1.Top >= -1310))
            {
                limit = true;
            }

            return limit;
        }

        public bool left_limits()
        {
            bool limit = false;

            if ((Map_pictureBox1.Left == 100 && Map_pictureBox1.Top <= 100 && Map_pictureBox1.Top >= -1310) ||
                (Map_pictureBox1.Left == 0 && Map_pictureBox1.Top <= -120 && Map_pictureBox1.Top >= -1090) ||
                (Map_pictureBox1.Left == -200 && Map_pictureBox1.Top <= -200 && Map_pictureBox1.Top >= -290) ||
                (Map_pictureBox1.Left == -200 && Map_pictureBox1.Top <= -320 && Map_pictureBox1.Top >= -810) ||
                (Map_pictureBox1.Left == -400 && Map_pictureBox1.Top <= -200 && Map_pictureBox1.Top >= -510) ||
                (Map_pictureBox1.Left == -400 && Map_pictureBox1.Top <= -700 && Map_pictureBox1.Top >= -1190) ||
                (Map_pictureBox1.Left == -500 && Map_pictureBox1.Top <= -20 && Map_pictureBox1.Top >= -190) ||
                (Map_pictureBox1.Left == -800 && Map_pictureBox1.Top <= 100 && Map_pictureBox1.Top >= -410) ||
                (Map_pictureBox1.Left == -800 && Map_pictureBox1.Top <= -800 && Map_pictureBox1.Top >= -1090) ||
                (Map_pictureBox1.Left == -800 && Map_pictureBox1.Top <= -1120 && Map_pictureBox1.Top >= -1310) ||
                (Map_pictureBox1.Left == -1100 && Map_pictureBox1.Top <= -420 && Map_pictureBox1.Top >= -790) ||
                (Map_pictureBox1.Left == -1300 && Map_pictureBox1.Top <= -620 && Map_pictureBox1.Top >= -810) ||
                (Map_pictureBox1.Left == -1400 && Map_pictureBox1.Top <= -1020 && Map_pictureBox1.Top >= -1210) ||
                (Map_pictureBox1.Left == -1600 && Map_pictureBox1.Top <= -300 && Map_pictureBox1.Top >= -710) ||
                (Map_pictureBox1.Left == -1700 && Map_pictureBox1.Top <= 100 && Map_pictureBox1.Top >= 10) ||
                (Map_pictureBox1.Left == -1700 && Map_pictureBox1.Top <= -20 && Map_pictureBox1.Top >= -110) ||
                (Map_pictureBox1.Left == -1700 && Map_pictureBox1.Top <= -1100 && Map_pictureBox1.Top >= -1190) ||
                (Map_pictureBox1.Left == -1700 && Map_pictureBox1.Top <= -1220 && Map_pictureBox1.Top >= -1310) ||
                (Map_pictureBox1.Left == -1800 && Map_pictureBox1.Top <= -120 && Map_pictureBox1.Top >= -380) ||
                (Map_pictureBox1.Left == -1800 && Map_pictureBox1.Top <= -420 && Map_pictureBox1.Top >= -1090))
            {
                limit = true;
            }

            return limit;
        }
        public bool up_limits()
        {
            bool limit = false;

            if ((Map_pictureBox1.Top == 100 && Map_pictureBox1.Left <= 100 && Map_pictureBox1.Left >= -1910) ||
                (Map_pictureBox1.Top == 0 && Map_pictureBox1.Left <= -120 && Map_pictureBox1.Left >= -790) ||
                (Map_pictureBox1.Top == 0 && Map_pictureBox1.Left <= -1420 && Map_pictureBox1.Left >= -1690) ||
                (Map_pictureBox1.Top == -200 && Map_pictureBox1.Left <= -200 && Map_pictureBox1.Left >= -310) ||
                (Map_pictureBox1.Top == -200 && Map_pictureBox1.Left <= -400 && Map_pictureBox1.Left >= -490) ||
                (Map_pictureBox1.Top == -200 && Map_pictureBox1.Left <= -520 && Map_pictureBox1.Left >= -710) ||
                (Map_pictureBox1.Top == -300 && Map_pictureBox1.Left <= -20 && Map_pictureBox1.Left >= -190) ||
                (Map_pictureBox1.Top == -300 && Map_pictureBox1.Left <= -1600 && Map_pictureBox1.Left >= -1710) ||
                (Map_pictureBox1.Top == -390 && Map_pictureBox1.Left <= -1720 && Map_pictureBox1.Left >= -1790) ||
                (Map_pictureBox1.Top == -600 && Map_pictureBox1.Left <= -1120 && Map_pictureBox1.Left >= -1510) ||
                (Map_pictureBox1.Top == -700 && Map_pictureBox1.Left <= -400 && Map_pictureBox1.Left >= -710) ||
                (Map_pictureBox1.Top == -800 && Map_pictureBox1.Left <= -800 && Map_pictureBox1.Left >= -1090) ||
                (Map_pictureBox1.Top == -800 && Map_pictureBox1.Left <= -1120 && Map_pictureBox1.Left >= -1210) ||
                (Map_pictureBox1.Top == -1000 && Map_pictureBox1.Left <= -1120 && Map_pictureBox1.Left >= -1410) ||
                (Map_pictureBox1.Top == -1100 && Map_pictureBox1.Left <= 100 && Map_pictureBox1.Left >= 10) ||
                (Map_pictureBox1.Top == -1100 && Map_pictureBox1.Left <= -20 && Map_pictureBox1.Left >= -110) ||
                (Map_pictureBox1.Top == -1100 && Map_pictureBox1.Left <= -420 && Map_pictureBox1.Left >= -790) ||
                (Map_pictureBox1.Top == -1100 && Map_pictureBox1.Left <= -1700 && Map_pictureBox1.Left >= -1790) ||
                (Map_pictureBox1.Top == -1100 && Map_pictureBox1.Left <= -1810 && Map_pictureBox1.Left >= -1910) ||
                (Map_pictureBox1.Top == -1200 && Map_pictureBox1.Left <= -120 && Map_pictureBox1.Left >= -390) ||
                (Map_pictureBox1.Top == -1200 && Map_pictureBox1.Left <= -1420 && Map_pictureBox1.Left >= -1690))
            {
                limit = true;
            }

            return limit;
        }
        public bool down_limits()
        {
            bool limit = false;

            if ((Map_pictureBox1.Top == -10 && Map_pictureBox1.Left <= -120 && Map_pictureBox1.Left >= -490) ||
                (Map_pictureBox1.Top == -10 && Map_pictureBox1.Left <= -520 && Map_pictureBox1.Left >= -790) ||
                (Map_pictureBox1.Top == -10 && Map_pictureBox1.Left <= -1420 && Map_pictureBox1.Left >= -1690) ||
                (Map_pictureBox1.Top == -110 && Map_pictureBox1.Left <= 100 && Map_pictureBox1.Left >= 10) ||
                (Map_pictureBox1.Top == -110 && Map_pictureBox1.Left <= -20 && Map_pictureBox1.Left >= -110) ||
                (Map_pictureBox1.Top == -110 && Map_pictureBox1.Left <= -1700 && Map_pictureBox1.Left >= -1790) ||
                (Map_pictureBox1.Top == -110 && Map_pictureBox1.Left <= -1820 && Map_pictureBox1.Left >= -1910) ||
                (Map_pictureBox1.Top == -310 && Map_pictureBox1.Left <= -20 && Map_pictureBox1.Left >= -190) ||
                (Map_pictureBox1.Top == -410 && Map_pictureBox1.Left <= -800 && Map_pictureBox1.Left >= -1090) ||
                (Map_pictureBox1.Top == -410 && Map_pictureBox1.Left <= -1120 && Map_pictureBox1.Left >= -1410) ||
                (Map_pictureBox1.Top == -410 && Map_pictureBox1.Left <= -1720 && Map_pictureBox1.Left >= -1790) ||
                (Map_pictureBox1.Top == -510 && Map_pictureBox1.Left <= -400 && Map_pictureBox1.Left >= -710) ||
                (Map_pictureBox1.Top == -610 && Map_pictureBox1.Left <= -1120 && Map_pictureBox1.Left >= -1290) ||
                (Map_pictureBox1.Top == -710 && Map_pictureBox1.Left <= -1600 && Map_pictureBox1.Left >= -1710) ||
                (Map_pictureBox1.Top == -810 && Map_pictureBox1.Left <= -200 && Map_pictureBox1.Left >= -310) ||
                (Map_pictureBox1.Top == -810 && Map_pictureBox1.Left <= -1300 && Map_pictureBox1.Left >= -1510) ||
                (Map_pictureBox1.Top == -1010 && Map_pictureBox1.Left <= -420 && Map_pictureBox1.Left >= -710) ||
                (Map_pictureBox1.Top == -1010 && Map_pictureBox1.Left <= -1220 && Map_pictureBox1.Left >= -1390) ||
                (Map_pictureBox1.Top == -1110 && Map_pictureBox1.Left <= -420 && Map_pictureBox1.Left >= -790) ||
                (Map_pictureBox1.Top == -1210 && Map_pictureBox1.Left <= -120 && Map_pictureBox1.Left >= -390) ||
                (Map_pictureBox1.Top == -1210 && Map_pictureBox1.Left <= -1400 && Map_pictureBox1.Left >= -1690) ||
                (Map_pictureBox1.Top == -1310 && Map_pictureBox1.Left <= 100 && Map_pictureBox1.Left >= -1690))

            {
                limit = true;
            }

            return limit;
        }

       
       
    }
   
}
