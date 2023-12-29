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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }
        
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-20ON3GR\\SQLEXPRESS;Initial Catalog=odm;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        SqlDataReader dr;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        Form7 frm7 = new Form7();
        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.ForeColor == Color.Blue)
            {
                frm7.Show();
                this.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            baglan.Open();
            da = new SqlDataAdapter("Select id,ad,soyad From kayit", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
            baglan.Open();
            da = new SqlDataAdapter("Select * From Sınav", baglan);
            DataTable tablola = new DataTable();
            da.Fill(tablola);
            dataGridView3.DataSource = tablola;
            baglan.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); 
            
        }
        int soru = 0;

      

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox2.Text = dataGridView2.CurrentRow.Cells[10].Value.ToString();
            label5.Text = "Dogru Cevap =" + dataGridView2.CurrentRow.Cells[7].Value.ToString();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Green;
            pictureBox2.BackColor = Color.White;


            if (pictureBox3.BackColor == Color.Green)
            {
                soru = soru + 1;
            }
            else
            {
                soru = soru - 1;
            }
            if (soru < 0)
            {
                soru = 1;
            }
            baglan.Open();
            if (comboBox1.Text == "Rastgele" && comboBox2.Text == "Rastgele")
            {
                da = new SqlDataAdapter("Select * From sorular where soru_sayısı =" + soru, baglan);
            }
            else if (comboBox1.Text == "Rastgele")
            {
                da = new SqlDataAdapter("Select * From sorular where soru_sayısı =" + soru + "and sınıf='" + comboBox2.Text + "'", baglan);
            }
            else if (comboBox2.Text == "Rastgele")
            {
                da = new SqlDataAdapter("Select * From sorular where soru_sayısı =" + soru + "and ders='" + comboBox1.Text + "'", baglan);
            }
            else
            {
                da = new SqlDataAdapter("Select * From sorular where soru_sayısı =" + soru + "and ders='" + comboBox1.Text + "'" + "and sınıf='" + comboBox2.Text + "'", baglan);
            }

            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;

            baglan.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Green;
            pictureBox3.BackColor = Color.White;
            if (pictureBox2.BackColor == Color.Green)
            {
                soru = soru - 1;
            }
            else
            {
                soru = soru + 1;
            }
            if (soru < 0)
            {
                soru = 1;
            }
            baglan.Open();
            if (comboBox1.Text == "Rastgele" && comboBox2.Text == "Rastgele")
            {
                da = new SqlDataAdapter("Select * From sorular where soru_sayısı =" + soru, baglan);
            }
            else if (comboBox1.Text == "Rastgele")
            {
                da = new SqlDataAdapter("Select * From sorular where soru_sayısı =" + soru + "and sınıf='" + comboBox2.Text + "'", baglan);
            }
            else if (comboBox2.Text == "Rastgele")
            {
                da = new SqlDataAdapter("Select * From sorular where soru_sayısı =" + soru + "and ders='" + comboBox1.Text + "'", baglan);
            }
            else
            {
                da = new SqlDataAdapter("Select * From sorular where soru_sayısı =" + soru + "and ders='" + comboBox1.Text + "'" + "and sınıf='" + comboBox2.Text + "'", baglan);
            }

            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;

            baglan.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            soru = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            soru = 0;
        }


        private void button4_Click(object sender, EventArgs e)
        {

            baglan.Open();
            komut = new SqlCommand("INSERT INTO Sınav(sınav_adı,sınav_acıklama,yetkililer,sınıf,sorular,ders,no,durum)VALUES (@sınav_adı,@sınav_acıklama,@yetkililer,@sınıf,@sorular,@ders,@no,@durum)",baglan);
            komut.Parameters.AddWithValue("@sınav_adı", textBox1.Text);
            komut.Parameters.AddWithValue("@sınav_acıklama", richTextBox1.Text);
            komut.Parameters.AddWithValue("@yetkililer", id.Text);
            komut.Parameters.AddWithValue("@sınıf", comboBox2.Text);
            komut.Parameters.AddWithValue("@sorular", textBox4.Text);
            komut.Parameters.AddWithValue("@ders", comboBox1.Text);
            komut.Parameters.AddWithValue("@no",textBox2.Text);
            komut.Parameters.AddWithValue("@durum", "Pasif");
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Sınavınız Başarıyla Kayıt Edilmiştir", "KAYIT", MessageBoxButtons.OK);




            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Blue;
            label1.Text = textBox1.Text;
        }

        string yetkili;
        private void button3_Click(object sender, EventArgs e)
        {
            yetkili = yetkili + dataGridView1.CurrentRow.Cells[0].Value.ToString()+ ",";
            id.Text = yetkili;
        }
        string soru_ekle;
        
        private void button5_Click(object sender, EventArgs e)
        {
            soru_ekle = soru_ekle + dataGridView2.CurrentRow.Cells[11].Value.ToString();
            textBox4.Text = soru_ekle;
            textBox3.Text = textBox4.Text;
            if (textBox3.Text == textBox4.Text)
            {
                textBox4.Text = "";

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string sınav;
        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            sınav = sınav + dataGridView3.CurrentRow.Cells[0].Value.ToString();
            label1.Text = sınav;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
