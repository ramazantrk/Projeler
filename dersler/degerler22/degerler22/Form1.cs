using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hesap = Convert.ToInt32(textBox1.Text);
            switch (hesap)
            {
                case 1:
                    MessageBox.Show("1 TL");break;
                case 2:
                    MessageBox.Show("2TL");break;
                case 3:
                    MessageBox.Show("3TL");break;
                default:
                    MessageBox.Show("Elimizde ole bi urun yok");break;




            }
        }
    }
}
