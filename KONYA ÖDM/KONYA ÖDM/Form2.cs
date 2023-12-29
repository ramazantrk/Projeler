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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-20ON3GR\\SQLEXPRESS;Initial Catalog=odm;Integrated Security=True");
        SqlCommand komut;

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State==ConnectionState.Closed)
                {
                    baglan.Open();
                    string sql = "INSERT INTO kayit(id,ad,soyad,eposta,sifre,tel,okuladi,mevki)VALUES (@id,@ad,@soyad,@eposta,@sifre,@tel,@okuladi,@mevki)";
                    komut = new SqlCommand(sql, baglan);
                    komut.Parameters.AddWithValue("@id", textBox7.Text);
                    komut.Parameters.AddWithValue("@ad", textBox1.Text);
                    komut.Parameters.AddWithValue("@soyad", textBox2.Text);
                    komut.Parameters.AddWithValue("@eposta", textBox3.Text);
                    komut.Parameters.AddWithValue("@sifre", textBox4.Text);
                    komut.Parameters.AddWithValue("@tel", textBox5.Text);
                    komut.Parameters.AddWithValue("@okuladi", textBox6.Text);
                    komut.Parameters.AddWithValue("@mevki", comboBox1.Text);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Başarıyla Kayıt Edilmiştir", "KAYIT", MessageBoxButtons.OK);
                }
                
            }
            catch(Exception hata)
            {
                MessageBox.Show("Bir hata oluştu"+ hata.Message);
            }
           
        }
    }
}
