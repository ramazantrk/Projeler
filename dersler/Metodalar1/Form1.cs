using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodalar1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
           
            InitializeComponent();
        }
       
        private void ekle(long tc,string adsoyad,string telefon,string adres,string email)
        {
            textBox1.Text = tc.ToString();
            textBox2.Text = adsoyad;
            textBox3,.Text = telefon;
            textBox4.Text = adres;
            textBox5.Text = email; ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekle(11235639144,"Ramazan Türk","0551637462","garipler sokak","rtue");
        }
    }
}
