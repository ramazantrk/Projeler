using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deger,sayı = Convert.ToInt32(textBox1.Text);
            deger = sayı % 2;
            if (deger == 1)
            {
                
                listBox1.Items.Add(sayı);
                
                
            }
            
            else
            {
                listBox2.Items.Add(sayı);
            }
            int teksayi = listBox1.Items.Count;
            label4.Text = teksayi.ToString();
            int ciftsayi = listBox2.Items.Count;
            label5.Text = ciftsayi.ToString();
            

            
        }
    }
}
