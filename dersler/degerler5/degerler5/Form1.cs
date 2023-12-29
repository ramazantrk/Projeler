using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ort1, ort2, sozl1, soz2, not;
            ort1 = Convert.ToInt32(textBox1.Text);
            ort2 = Convert.ToInt32(textBox2.Text);
            sozl1 = Convert.ToInt32(textBox3.Text);
            soz2 = Convert.ToInt32(textBox4.Text);
            not=(ort1+ort2+sozl1+soz2) / 4;
            label5.Text=not.ToString();

            if (not>50)
            {
                label7.Text = "GEÇTİ";
            }
            else
            {
                label7.Text = "KALDI";
            }

        }
    }
}
