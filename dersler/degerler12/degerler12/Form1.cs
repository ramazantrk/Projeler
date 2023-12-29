using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Paraları_koy()
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2,sonuc;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            sonuc = (sayı1 * sayı1) / sayı2;
            if (sonuc < 18.49)
            {
                MessageBox.Show("İdeal Kilonun Altındasınız", "İdeal", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);

            }
            else if(sonuc>18.05 && sonuc < 24.99)
            {
                MessageBox.Show("İdeal Kilodasınız","İdealin",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            }
            else if(sonuc>25 && sonuc < 29.99)
            {
                MessageBox.Show("İdeal Kilonun Üzerindesin","İdealin",MessageBoxButtons.OKCancel,MessageBoxIcon.Stop);
            }
            else if (sonuc > 30)
            {
                MessageBox.Show("İdeal Kilonun Çok üstündesin", "İdeal", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            

        
        }
    }
}
