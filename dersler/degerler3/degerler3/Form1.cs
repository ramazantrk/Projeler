using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say = (Convert.ToInt32(textBox1.Text));

            if (say <= 44)
            {
                MessageBox.Show("1");
            }
            else if (say <= 55)
            {
                MessageBox.Show("2");
            }
            else if (say <= 65)
            {
                MessageBox.Show("3");
            }
            else if (say <= 84)
            {
                MessageBox.Show("4");
            }
            else if (say <= 100)
            {
                MessageBox.Show("5");
            }
            else
            {
                MessageBox.Show("0 ile 100 arasında ni sayı giriniz");
            }
        }

        }
    }

