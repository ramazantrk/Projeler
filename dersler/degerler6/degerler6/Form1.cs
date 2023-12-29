using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double  hesap = 0;
            if (checkBox1.Checked)
                hesap= + 1;
            if (checkBox2.Checked)
                hesap = hesap + 5;   
            if (checkBox3.Checked)            
                hesap = hesap + 10;            
            if (checkBox4.Checked)           
                hesap = hesap + 5;      
            if (checkBox5.Checked)            
                hesap = hesap + 1.5;            
            if (checkBox6.Checked)           
                hesap=hesap+7;
            label2.Text = hesap.ToString();
            
               

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
