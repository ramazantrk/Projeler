using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KONYA_ÖDM
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-20ON3GR\\SQLEXPRESS;Initial Catalog=odm;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        SqlDataReader dr;
        Random rnd = new Random();
        Random rnd2 = new Random();


        private void Form8_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut = new SqlCommand("insert into ogrencı_kayıt(ad,soyad,tc,okuladi,okulno,sınıf,sube,sifre) Values (@ad,@soyad,@tc,@okuladi,@okulno,@sınıf,@sube,@sifre)", baglan);
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@tc", textBox3.Text);
            komut.Parameters.AddWithValue("@okuladi", textBox4.Text);
            komut.Parameters.AddWithValue("@okulno", textBox5.Text);
            komut.Parameters.AddWithValue("@sınıf", comboBox4.Text);
            komut.Parameters.AddWithValue("@sube", comboBox1.Text);
            komut.Parameters.AddWithValue("@sifre", textBox8.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Ögrenciniz Başarıyla Kayıt Edilmiştir");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kod = rnd.Next(65, 91);
            char karakter = Convert.ToChar(kod);
            textBox8.Text = karakter+ rnd2.Next(0, 10) + karakter.ToString() + rnd2.Next(0, 10)+rnd2.Next(0, 10);
        }
    }
}
