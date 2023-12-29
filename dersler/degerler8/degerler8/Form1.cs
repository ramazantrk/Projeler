using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sayı1;
            sayı1 = Convert.ToInt32(comboBox1.Text);
            if (sayı1 > 0 && sayı1 < 5)
            {
                MessageBox.Show("İlkokul");
            }
            else if (sayı1 > 6 && sayı1 < 9)
            {
                MessageBox.Show("Ortaokul");
            }
            else if (sayı1 > 8 && sayı1 < 13)
            {
                MessageBox.Show("Lise");
            }
        }
    }
}
