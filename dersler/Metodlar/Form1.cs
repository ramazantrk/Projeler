using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toplamaIslemi()
        {
            int sayi1,sayi2;
            sayi1 = int.Parse(textBox1.Text);
            sayi2 = int.Parse(textBox2.Text);
            label4.Text = (sayi1 + sayi2).ToString();
            textBox1.Clear();
            textBox2.Clear();
           
        }
        private void cıkarmaIslemi()
        {
            int sayi1, sayi2;
            sayi1 = int.Parse(textBox1.Text);
            sayi2 = int.Parse(textBox2.Text);
            label4.Text = (sayi1 - sayi2).ToString();
            textBox1.Clear();
            textBox2.Clear();

        }
        private void carpmaIslemi()
        {
            int sayi1, sayi2;
            sayi1 = int.Parse(textBox1.Text);
            sayi2 = int.Parse(textBox2.Text);
            label4.Text = (sayi1 * sayi2).ToString();
            textBox1.Clear();
            textBox2.Clear();

        }
        private void bolmeIslemi()
        {
            int sayi1, sayi2;
            sayi1 = int.Parse(textBox1.Text);
            sayi2 = int.Parse(textBox2.Text);
            label4.Text = (sayi1 / sayi2).ToString();
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cıkarmaIslemi();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toplamaIslemi();

          


        }

        private void button3_Click(object sender, EventArgs e)
        {
            carpmaIslemi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bolmeIslemi();
        }
    }
}
