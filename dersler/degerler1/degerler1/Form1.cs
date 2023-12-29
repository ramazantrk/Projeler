using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2;
            int toplam;
            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);
            toplam = sayı1 + sayı2;
            label3.Text=toplam.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2;
            int toplam;
            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);
            toplam = sayı1 - sayı2;
            label3.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2;
            int toplam;
            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);
            toplam = sayı1 * sayı2;
            label3.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float sayı1, sayı2;
            float toplam;
            sayı1 = Convert.ToSingle(textBox1.Text);
            sayı2 = Convert.ToSingle(textBox2.Text);
            toplam = sayı1 + sayı2;
            label3.Text = toplam.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float sayı1, sayı2;
            float toplam;
            sayı1 = Convert.ToSingle(textBox1.Text);
            sayı2 = Convert.ToSingle(textBox2.Text);
            toplam = sayı1 - sayı2;
            label3.Text = toplam.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            float sayı1, sayı2;
            float toplam;
            sayı1 = Convert.ToSingle(textBox1.Text);
            sayı2 = Convert.ToSingle(textBox2.Text);
            toplam = sayı1 * sayı2;
            label3.Text = toplam.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string metin1, metin2, toplam;
            metin1 = textBox1.Text;
            metin2 = textBox2.Text;
            toplam = metin1 + metin2;
            MessageBox.Show(toplam);

        }
    }
}
