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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-20ON3GR\\SQLEXPRESS;Initial Catalog=odm;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        SqlDataReader dr;
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
        }

   
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            label2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();


        }

     
        int soru = 0;
        

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            soru = 0;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            soru = 0;
        }

        
        private void Form3_Load(object sender, EventArgs e)
        {
            baglan.Open();
            da = new SqlDataAdapter("Select * From kayit where eposta='"+Form1.eposta+"'", baglan);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            dataGridView3.DataSource = tablo3;
            baglan.Close();

            if (dataGridView3.CurrentRow.Cells[7].Value.ToString()=="Müdür"|| dataGridView3.CurrentRow.Cells[7].Value.ToString() == "Müdür Yardımcısı")
            {
                button4.Visible = true;
            }
            else
            {
                button4.Visible = false;
            }


            baglan.Open();
            da = new SqlDataAdapter("Select * From Sınav where durum='Pasif'", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglan.Close();

            baglan.Open();
            da = new SqlDataAdapter("Select * From Sınav where durum='Aktif'", baglan);
            DataTable tablo2 = new DataTable();
            da.Fill(tablo2);
            dataGridView3.DataSource = tablo2;
            baglan.Close();

        }
        void verilerigetir()
        {
            baglan.Open();
            da = new SqlDataAdapter("Select * From Sınav where durum='Pasif'", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglan.Close();

            baglan.Open();
            da = new SqlDataAdapter("Select * From Sınav where durum='Aktif'", baglan);
            DataTable tablo2 = new DataTable();
            da.Fill(tablo2);
            dataGridView3.DataSource = tablo2;
            baglan.Close();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
         
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabPage4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("Update Sınav set durum='Aktif' "+ "where durum='" + dataGridView2.CurrentRow.Cells[7].Value.ToString() +"'", baglan);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Sınava İzin verildi");
            verilerigetir();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Green;
            pictureBox2.BackColor = Color.White;


            if (pictureBox1.BackColor == Color.Green)
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
            if (comboBox3.Text == "Rastgele" && comboBox4.Text == "Rastgele")
            {
                da = new SqlDataAdapter("Select * From sorular where soru_sayısı =" + soru, baglan);
            }
            else if (comboBox3.Text == "Rastgele")
            {
                da = new SqlDataAdapter("Select * From sorular where soru_sayısı =" + soru + "and sınıf='" + comboBox4.Text + "'", baglan);
            }
            else if (comboBox4.Text == "Rastgele")
            {
                da = new SqlDataAdapter("Select * From sorular where soru_sayısı =" + soru + "and ders='" + comboBox3.Text + "'", baglan);
            }
            else
            {
                da = new SqlDataAdapter("Select * From sorular where soru_sayısı =" + soru + "and ders='" + comboBox3.Text + "'" + "and sınıf='" + comboBox4.Text + "'", baglan);
            }

            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

            baglan.Close();
            // comvo3 ders
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Green;
            pictureBox1.BackColor = Color.White;
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
            if (comboBox3.Text == "Rastgele" && comboBox4.Text == "Rastgele")
            {
                da = new SqlDataAdapter("Select * From sorular where soru_sayısı =" + soru, baglan);
            }
            else if (comboBox3.Text == "Rastgele")
            {
                da = new SqlDataAdapter("Select * From sorular where soru_sayısı =" + soru + "and sınıf='" + comboBox4.Text + "'", baglan);
            }
            else if (comboBox4.Text == "Rastgele")
            {
                da = new SqlDataAdapter("Select * From sorular where soru_sayısı =" + soru + "and ders='" + comboBox3.Text + "'", baglan);
            }
            else
            {
                da = new SqlDataAdapter("Select * From sorular where soru_sayısı =" + soru + "and ders='" + comboBox3.Text + "'" + "and sınıf='" + comboBox4.Text + "'", baglan);
            }
            da = new SqlDataAdapter("Select * From sorular where soru_sayısı =" + soru, baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

            baglan.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
