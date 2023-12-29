using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sıcaklık;
            sıcaklık = Convert.ToInt32(textBox1.Text);
            if (sıcaklık<=10)
            {
                MessageBox.Show("Hava Soğuk");
            }
            else if (sıcaklık<25)
            {
                MessageBox.Show("Hava Hafif Sıcak");
            }
            else if (sıcaklık>25)
            {
                MessageBox.Show("Hava Sıcak");
            }
        }
    }
}
