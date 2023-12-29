using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int sayı=0;
            sayı = Convert.ToInt32(trackBar1.Value);
            if (sayı==0)
            {
                label1.Text = "Ses seviyesi yok";
                label1.ForeColor = Color.Green;
            }
            else if(sayı<10)
            {
                label1.Text = "Orta seviye";
                label1.ForeColor = Color.Blue;
            }
            else if (sayı < 15)
            {
                label1.Text = "Yüksek seviye";
                label1.ForeColor = Color.Red;
            }
        }
    }
}
