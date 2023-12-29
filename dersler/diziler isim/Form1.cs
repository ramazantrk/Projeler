using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler_isim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        int[] notlar = new int[5];

        int i=0;
        private void button1_Click(object sender, EventArgs e)
        {
            isimler[i] = textBox1.Text;
            notlar[i] = int.Parse(textBox2.Text);
            i++;
            textBox1.Text = " ";
            textBox2.Text = " ";
               
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                listBox1.Items.Add(isimler[i]+" "+notlar[i]);
            }
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (notlar[1] > notlar[0] || notlar[1] > notlar[2] || notlar[1] > notlar[3] || notlar[1] > notlar[4])
            {
                textBox3.Text = notlar[1].ToString();
            }
            if (notlar[2] > notlar[0] || notlar[2] > notlar[1] || notlar[2] > notlar[3] || notlar[2] > notlar[4])
            {
                textBox3.Text = notlar[2].ToString();
            }
            if (notlar[3] > notlar[0] || notlar[3] > notlar[1] || notlar[0] > notlar[2] || notlar[3] > notlar[4])
            {
                textBox3.Text = notlar[3].ToString();
            }
            if (notlar[4] > notlar[0] || notlar[4] > notlar[1] || notlar[4] > notlar[2] || notlar[4] > notlar[3])
            {
                textBox3.Text = notlar[4].ToString();
            }
            if (notlar[0] > notlar[1] || notlar[0] > notlar[2] || notlar[0] > notlar[3] || notlar[0] > notlar[4])
            {
                textBox3.Text = notlar[0].ToString();
            }

        }
    }
}
