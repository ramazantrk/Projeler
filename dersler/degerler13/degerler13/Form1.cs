using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı=0;
            sayı = Convert.ToInt32(textBox1.Text);
            sayı = sayı + 1;
            textBox1.Text = sayı.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayı;
            sayı = Convert.ToInt32(textBox1.Text);
            sayı = sayı - 1;
            textBox1.Text = sayı.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
