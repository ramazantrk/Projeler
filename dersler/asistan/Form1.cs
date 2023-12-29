using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asistan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            





            
            
            if (textBox1.Text=="yutubu aç"||textBox1.Text=="yutubuac"||textBox1.Text=="youtubeaç"||textBox1.Text=="yutubuaç"|| textBox1.Text == "yutubuac"|| textBox1.Text == "youtube ac"|| textBox1.Text == "youtube aç")
            {
                webBrowser1.Navigate("https://www.youtube.com/");
            }




        }
    }
}
