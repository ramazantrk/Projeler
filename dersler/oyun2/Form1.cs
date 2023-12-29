using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun2
{
    public partial class Form1 : Form
    {
        int pipespeed = 0;
        int gravity = 5;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gametimerevent(object sender, EventArgs e)
        {
            
            
            
            label1.Text = "score" + score.ToString();



            
            if (maryo.Bounds.IntersectsWith(engel1.Bounds) ||
                maryo.Bounds.IntersectsWith(engel2.Bounds) )
                endgame();

                
       
        }

        private void gamekeyidown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                maryo.Top += -50;
                
            }
        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                maryo.Top += 50;
            }
            else if (e.KeyCode == Keys.Right)
            {
                maryo.Left += 50;
                engel1.Left += 15;
                engel2.Left += 15;
                yol.Left += 15;

              

            }
            else if (e.KeyCode == Keys.Left)
            {
                maryo.Left += -50;
            }
            else if (e.KeyCode == Keys.Right&&e.KeyCode==Keys.Up)
            {
                maryo.Left += 50;
                maryo.Left += 50;
                maryo.Top += 50;
            }
        }
        private void endgame()
        { gametimer.Stop();

          label1.Text += "!!!GAME OVER!!";
        }

       
    }
}
