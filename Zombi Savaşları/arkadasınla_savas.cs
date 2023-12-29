using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombi_Savaşları
{
    public partial class arkadasınla_savas : Form
    {
        public arkadasınla_savas()
        {
            InitializeComponent();
        }
        public static string user1;
        public static string user2;
        public static bool oynuc1_k1;
        public static bool oynuc1_k2;
        public static bool oynuc1_k3;
        public static bool oynuc1_k4;
        public static bool oynuc1_k5;

        public static bool oynuc2_k1;
        public static bool oynuc2_k2;
        public static bool oynuc3_k3;
        public static bool oynuc4_k4;
        public static bool oynuc5_k5;

        form3 frm3 = new form3();

        private void button1_Click(object sender, EventArgs e)
        {
            oynuc1_k1 = radioButton1.Checked;
            oynuc1_k2 = radioButton2.Checked;
            oynuc1_k3 = radioButton3.Checked;
            oynuc1_k4 = radioButton4.Checked;
            oynuc1_k5 = radioButton5.Checked;

            oynuc2_k1 = radioButton6.Checked;
            oynuc2_k2 = radioButton7.Checked;
            oynuc3_k3 = radioButton8.Checked;
            oynuc4_k4 = radioButton9.Checked;
            oynuc5_k5 = radioButton10.Checked;

            user1 = textBox1.Text;
         

            oyucu_ısk.BackColor = Color.Lime;


            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;

            textBox1.Enabled = false;





            if (textBox1.Text == textBox2.Text)
            {
                
                MessageBox.Show("Aynı İsim kullanamassınız", "HATA", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;

                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton5.Enabled = true;

                textBox1.Enabled = true;
                oyucu_ısk.BackColor = Color.Red;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bu alan Boş Bırakılamaz", "HATA", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;

                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton5.Enabled = true;

                textBox1.Enabled = true;
                oyucu_ısk.BackColor = Color.Red;
            }
            if (oyucu_ısk.BackColor ==Color.Lime&& oyuncu2_ısık.BackColor==Color.Lime)
            {
                
                frm3.Show();
                this.Hide();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oynuc2_k1 = radioButton10.Checked;
            oynuc2_k2 = radioButton9.Checked;
            oynuc3_k3 = radioButton8.Checked;
            oynuc4_k4 = radioButton7.Checked;
            oynuc5_k5 = radioButton6.Checked;



            user2 = textBox2.Text;
            oyuncu2_ısık.BackColor = Color.Lime;

            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;

            radioButton6.Enabled = false;
            radioButton7.Enabled = false;
            radioButton8.Enabled = false;
            radioButton9.Enabled = false;
            radioButton10.Enabled = false;

            textBox2.Enabled = false;





            if (textBox1.Text == textBox2.Text)
            {
                MessageBox.Show("Aynı İsim kullanamassınız", "HATA", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;

                radioButton6.Enabled = true;
                radioButton7.Enabled = true;
                radioButton8.Enabled = true;
                radioButton9.Enabled = true;
                radioButton10.Enabled = true;

                textBox2.Enabled = true;
                oyuncu2_ısık.BackColor = Color.Red;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Bu alan Boş Bırakılamaz", "HATA", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;

                radioButton6.Enabled = true;
                radioButton7.Enabled = true;
                radioButton8.Enabled = true;
                radioButton9.Enabled = true;
                radioButton10.Enabled = true;

                textBox2.Enabled = true;
                oyuncu2_ısık.BackColor = Color.Red;
            }
            if (oyucu_ısk.BackColor ==Color.Lime&& oyuncu2_ısık.BackColor==Color.Lime)
            {
                
                frm3.Show();
                this.Hide();
            }
            

        }
        
        private void arkadasınla_savas_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;

            textBox1.Enabled = true;
            oyucu_ısk.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;

            radioButton6.Enabled = true;
            radioButton7.Enabled = true;
            radioButton8.Enabled = true;
            radioButton9.Enabled = true;
            radioButton10.Enabled = true;

            textBox2.Enabled = true;
            oyuncu2_ısık.BackColor = Color.Red;
        }
    }
}
