using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace girdiginsayıkadaryazdır
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                int yas = int.Parse(textBox1.Text), i = 0; ;
                string ad = textBox2.Text;

                while (i < yas)
                {
                    listBox1.Items.Add(ad);
                    i++;
                    progressBar1.Value = i;
                    timer1.Stop();

                }

                if (progressBar1.Value >= 100)
                {
                    MessageBox.Show("Alan doldu daha fazla alamam", "hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Alan doldu daha fazla alamam", "hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
                  
                listBox1.Items.Clear();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            progressBar1.Value = 0;


        }
    }
}
