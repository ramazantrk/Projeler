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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-20ON3GR\\SQLEXPRESS;Initial Catalog=odm;Integrated Security=True");

        public static string eposta;
        private void button1_Click(object sender, EventArgs e)
        {
            eposta = textBox1.Text;
            
                try
                {

                    baglanti.Open();
                    string sql = "SELECT * FROM kayit where eposta=@eposta AND sifre=@sifre";
                    SqlCommand komut = new SqlCommand(sql, baglanti);
                    SqlParameter prm1 = new SqlParameter("@eposta", textBox1.Text.Trim());
                    SqlParameter prm2 = new SqlParameter("@sifre", textBox2.Text.Trim());
                   
                    komut.Parameters.Add(prm1);
                    komut.Parameters.Add(prm2);
                    DataTable tablo = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    da.Fill(tablo);


                    if (tablo.Rows.Count > 0)
                    {
                        Form3 frm3 = new Form3();
                        frm3.Show();
                        this.Hide();
                    }
                }
                catch
                {

                    MessageBox.Show("Kullanıcı adı veya sifre hatalı", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
        }
        
       

        private void label4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide(); 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
        public static string tc;
        public static string sifre;
        private void button2_Click(object sender, EventArgs e)
        {
            tc = ogrtextBoxtc.Text;
            sifre = ogrtextBoxsifre.Text;
            try
            {
                baglanti.Open();
                string sql = "Select * From ogrencı_kayıt where tc=@tc and sifre=@sifre";
                SqlCommand komut = new SqlCommand(sql, baglanti);
                SqlParameter prm1 = new SqlParameter("@tc", ogrtextBoxtc.Text.Trim());
                SqlParameter prm2 = new SqlParameter("@sifre", ogrtextBoxsifre.Text.Trim());

                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable tablo = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(tablo);

                if (tablo.Rows.Count > 0)
                {
                    Form9 frm9 = new Form9();
                    frm9.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Tc Kimlik No veya sifre hatalı", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       
        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                ogrtextBoxsifre.UseSystemPasswordChar = false;
            }
            else
            {
                ogrtextBoxsifre.UseSystemPasswordChar = true;
            }
        }
      
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           
                
    
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
