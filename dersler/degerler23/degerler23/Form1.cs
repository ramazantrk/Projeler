using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt32(textBox1.Text);
            switch (ay)
            {
                case 1:
                    MessageBox.Show("Kış"); break;
                case 2:
                    MessageBox.Show("Kış"); break;
                case 3:
                    MessageBox.Show("İlk bahar"); break;
                case 4:
                    MessageBox.Show("ilk bahar"); break;
                case 5:
                    MessageBox.Show("ilk bahar"); break;
                case 6:
                    MessageBox.Show("Yaz"); break;
                case 7:
                    MessageBox.Show("Yaz"); break;
                case 8:
                    MessageBox.Show("Yaz"); break;
                case 9:
                    MessageBox.Show("Son bahar"); break;
                case 10:
                    MessageBox.Show("Son bahar"); break;
                case 11:
                    MessageBox.Show("Son bahar"); break;
                case 12:
                    MessageBox.Show("Kış"); break;
                default:
                    MessageBox.Show("1_12 arası sayı girin");break;


            }
        }
    }
}
