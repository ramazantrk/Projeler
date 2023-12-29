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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adı = Convert.ToInt32(textBox1.Text);
            int soyadı = Convert.ToInt32(textBox2.Text);
            int kullanıcıadı = Convert.ToInt32(textBox3.Text);
            int sifre = Convert.ToInt32(textBox4.Text);
            int eposta = Convert.ToInt32(textBox5.Text);
            int adres = Convert.ToInt32(textBox5.Text);
        }
    }
}
