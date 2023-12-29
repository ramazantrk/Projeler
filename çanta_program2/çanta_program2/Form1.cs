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

namespace çanta_program2
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Form1()
        {
           
            InitializeComponent();
        }
        void Ürüngetir()
        {
            baglanti = new SqlConnection("Data Source=OGR-12\\SQLEXPRESS;Initial Catalog=veriler;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM ürünler", baglanti);
            DataTable table  = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ürüngetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();
          

            textBox6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() +" "+dataGridView1.CurrentRow.Cells[2].Value.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO ürünler(ürün_adi,ürün_miktari,ürün_birimi) VALUES (@ürün_adi,@ürün_miktarı,@ürün_birimi)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ürün_Adi", textBox1.Text);
            komut.Parameters.AddWithValue("@ürün_miktarı", textBox2.Text);
            komut.Parameters.AddWithValue("@ürün_birimi", comboBox1.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Ürüngetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM ürünler WHERE ürün_adi=@ürün_adi";
            komut = new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@ürün_adi", textBox4.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Ürüngetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE ürünler SET ürün_miktari=ürün_miktari-@ürün_miktarı WHERE ürün_adi=@ürün_adi";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ürün_adi",textBox4.Text);
            komut.Parameters.AddWithValue("@ürün_miktarı",textBox3.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Ürüngetir();
            MessageBox.Show("Güncellendi");
            textBox3.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE ürünler SET ürün_miktari=ürün_miktari+@ürün_miktarı WHERE ürün_adi=@ürün_adi";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ürün_adi", textBox6.Text);
            komut.Parameters.AddWithValue("@ürün_miktarı", textBox8.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Ürüngetir();
            MessageBox.Show("Güncellendi");
            textBox8.Text = "";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            da = new SqlDataAdapter("select * from ürünler where ürün_adi like '%" + textBox9.Text + "%' ", baglanti);
            da.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }
    }
}
