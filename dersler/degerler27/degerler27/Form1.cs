using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı;
           
            sayı = Convert.ToInt32(textBox2.Text);
           

            int i =1;
            while (i < sayı)
            {
                listBox1.Items.Add(textBox1.Text);
                i++;
            }
        }
    }
}
