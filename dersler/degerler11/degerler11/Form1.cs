using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String giris = listBox1.SelectedItem.ToString();
            if (giris=="Maouse" || giris=="Klavye" || giris=="kamera"||giris=="tarayıcı")
            {
                MessageBox.Show("Girişdir", "Girişmi çıkışmı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("Çıkışdır", "Girişmi çıkışmı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            
        }
    }
}
