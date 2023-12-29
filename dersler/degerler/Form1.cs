using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                label1.Text = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                label1.Text = radioButton3.Text;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                double not1 = double.Parse(textBox1.Text), not2 = double.Parse(textBox2.Text), devamsızlık = double.Parse(textBox3.Text), not = (not1 + not2) / 2;
                label3.Text = not.ToString();
                if (not < 50 || devamsızlık > 10)
                {
                    label2.Text = "Sınıfda KAldınınız";
                }
                else if (not > 5 && devamsızlık < 10)
                {
                    label2.Text = "Sınıfı Geçtiniz";
                }
            }
            catch
            {
                MessageBox.Show("Hatalı İşlem", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
    }
}
