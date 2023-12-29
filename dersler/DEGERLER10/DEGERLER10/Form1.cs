using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEGERLER10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void name_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı;
            sayı = Convert.ToDouble(textBox1.Text);

            if (radioButton1 .Checked)
            {
               MessageBox.Show(sayı.ToString());

            }
            else if(radioButton2.Checked || radioButton3.Checked)
            {
                sayı = (sayı * 5) / 100+sayı;
                MessageBox.Show(sayı.ToString());
            }
            else if(radioButton4.Checked || radioButton5.Checked)
            {
                sayı = (sayı * 10) / 100+sayı;
                MessageBox.Show(sayı.ToString(),"Bilmem",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
