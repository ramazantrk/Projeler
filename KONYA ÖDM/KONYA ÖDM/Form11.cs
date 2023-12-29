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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-20ON3GR\\SQLEXPRESS;Initial Catalog=odm;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        SqlDataReader dr;
        private void Form11_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form9.sorular;

        }
        Form9 frm9 = new Form9();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            baglan.Open();
            da = new SqlDataAdapter("Select * From sorular where soru_sayısı='" + Form9.sorular + "'", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }
    }
}
