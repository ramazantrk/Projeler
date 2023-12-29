using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degereler19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int sayı;
            for(int i = 0; i < 20; i++)
            {
                sayı = r.Next(0, 1000);
               listBox1.Items.Add(sayı);
            }
            


        }
    }
}
