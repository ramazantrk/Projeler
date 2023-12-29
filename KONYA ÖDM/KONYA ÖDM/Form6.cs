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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-20ON3GR\\SQLEXPRESS;Initial Catalog=odm;Integrated Security=True");
        SqlCommand komut;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Brown;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
           
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.ForeColor = Color.Black;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
           

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.Text = "S";
            }
            if (checkBox2.Checked)
            {
                textBox2.Text = "A";
            }
            if (checkBox3.Checked)
            {
                textBox2.Text = "B";
            }
            if (checkBox4.Checked)
            {
                textBox2.Text = "C";
            }
            if (checkBox5.Checked)
            {
                textBox2.Text = "D";
            }
            richTextBox6.Text = richTextBox1.Text + Environment.NewLine + Environment.NewLine + Environment.NewLine + "A)" + richTextBox2.Text + Environment.NewLine + Environment.NewLine + "B)" + richTextBox3.Text + Environment.NewLine + Environment.NewLine + "C)" + richTextBox4.Text + Environment.NewLine + Environment.NewLine + "D)" + richTextBox5.Text;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult lan = fontDialog1.ShowDialog();
            if (lan == DialogResult.OK)
            {
                richTextBox1.Font= fontDialog1.Font;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    
                    baglan.Open();
                    string sql = "INSERT INTO sorular(tam_soru,sınıf,ders,soru,a,b,c,d,dogru_cevap,resim,resim_yeri)VALUES (@tam_soru,@sınıf,@ders,@soru,@a,@b,@c,@d,@dogru_cevap,@resim,@resim_yeri)";
                    komut = new SqlCommand(sql, baglan);
                    komut.Parameters.AddWithValue("@tam_soru", richTextBox6.Text);
                    komut.Parameters.AddWithValue("@sınıf", comboBox4.Text);
                    komut.Parameters.AddWithValue("@ders", comboBox3.Text);
                    komut.Parameters.AddWithValue("@soru", richTextBox1.Text);
                    komut.Parameters.AddWithValue("@a", richTextBox2.Text);
                    komut.Parameters.AddWithValue("@b", richTextBox3.Text);
                    komut.Parameters.AddWithValue("@c", richTextBox4.Text);
                    komut.Parameters.AddWithValue("@d", richTextBox5.Text);
                    komut.Parameters.AddWithValue("@dogru_cevap", comboBox1.Text);
                    komut.Parameters.AddWithValue("@resim", textBox1.Text);
                    komut.Parameters.AddWithValue("@resim_yeri", textBox2.Text);                   
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Başarıyla Kayıt Edilmiştir", "KAYIT", MessageBoxButtons.OK);
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu" + hata.Message);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.ForeColor = Color.Black;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.ForeColor = Color.Black;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Close();
        
       }
    }
}
