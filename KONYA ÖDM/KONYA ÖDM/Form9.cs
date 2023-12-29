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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        
        public static string sorular;
        private void Form9_Load(object sender, EventArgs e)
        {
            
            baglan.Open();
            da = new SqlDataAdapter("Select sınav_adı,sınav_acıklama,sınıf,ders,sorular From Sınav where durum='Aktif'", baglan);
            DataTable tablo2 = new DataTable();
            da.Fill(tablo2);
            dataGridView2.DataSource = tablo2;
            baglan.Close();


          


        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-20ON3GR\\SQLEXPRESS;Initial Catalog=odm;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        private void button2_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show();
             
        }
       
    

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox3.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            sorular = textBox1.Text;
            Form11 frm11 = new Form11();
            frm11.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sonsil = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            string bassil = textBox1.Text.Substring(1, textBox1.Text.Length - 1);
            string bassil2 = textBox2.Text.Substring(1, textBox2.Text.Length - 2);

            if (textBox1.Text.Substring(textBox1.Text.Length - 1) == ",")
                textBox1.Text= textBox1.Text.Remove(textBox1.Text.Length - 1, 1) + " ";
            if (textBox2.Text.Substring(textBox2.Text.Length - 1) == ",")
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1) + " ";
            if (textBox3.Text.Substring(textBox3.Text.Length - 1) == ",")
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1, 1) + " ";
            if (textBox4.Text.Substring(textBox4.Text.Length - 1) == ",")
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1, 1) + " ";

            if (textBox1.Text.Length > 2)
            {
                textBox1.Text = bassil;
            }



           
        }
    }
}
