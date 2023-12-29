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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-20ON3GR\\SQLEXPRESS;Initial Catalog=odm;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        SqlDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            baglan.Open();
            da = new SqlDataAdapter("Select * From ogrencı_kayıt", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                da = new SqlDataAdapter("Select * From ogrencı_kayıt where ad='" + textBox1.Text + "' or okulno='" + textBox1.Text + "'  or soyad='" + textBox1.Text + "'", baglan);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglan.Close();
            }
            catch 
            {

                MessageBox.Show("Böyle Bir Ögrenci Bulunamadı");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                da = new SqlDataAdapter("Select * From ogrencı_kayıt where ad='" + textBox1.Text + "' or okulno='" + textBox1.Text + "'  or soyad='" + textBox1.Text + "'", baglan);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglan.Close();
            }
            catch
            {

                MessageBox.Show("Böyle Bir Ögrenci Bulunamadı");
            }
        }
    }
}
