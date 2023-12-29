using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gun = Convert.ToInt32(DateTime.Now.DayOfWeek);
            switch (gun)
            {
                case 0:
                    MessageBox.Show("pazar");break;
                case 1:
                    MessageBox.Show("Pazartesi");break;
                case 2:
                    MessageBox.Show("Salı");break;
                case 3:
                    MessageBox.Show("Çarşanba"); break;
                case 4:
                    MessageBox.Show("Perşenme"); break;
                case 5:
                    MessageBox.Show("Cuma");break;
                case 6:
                    MessageBox.Show("Cumartes");break;
                default:
                    MessageBox.Show("hatalı");break;



            }
        }
    }
}
