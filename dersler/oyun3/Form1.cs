using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String ad = "ramazan";
        string sifre = "123456";
        int sayac = 0;
        Form2 frm2 = new Form2();
        Form3 frm3 = new Form3();

        private void button1_Click(object sender, EventArgs e)
        {
            if (frm3.)
            {

            }


            else if (textBox1.Text == ad && textBox2.Text == sifre)
            {

                frm2.Show();
                this.Hide();

            }
            else
            {
                sayac++;
                MessageBox.Show("kullanıcı adı veya sifre hatalı kalan deneme hakkınız: " + (3 - sayac), "hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (sayac == 3)
                {
                    MessageBox.Show("Başka deneme hakkınız kalmadı program sonlandırılıyor", "hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    Application.Exit();

                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }
    }
}
