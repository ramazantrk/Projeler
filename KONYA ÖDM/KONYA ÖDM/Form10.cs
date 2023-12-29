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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-20ON3GR\\SQLEXPRESS;Initial Catalog=odm;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;

        void verigetir()
        {
            baglan.Open();
            da = new SqlDataAdapter("Select * From ogrencı_kayıt where tc='" + Form1.tc + "'", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("Update ogrencı_kayıt set sifre='"+textBox4.Text+"'"+"where tc='" + textBox3.Text + "'",baglan);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Şifreniz Başarıyla Güncellendi");
            verigetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            verigetir();
           

        }
    }
}
