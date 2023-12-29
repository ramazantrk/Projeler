using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double  not1, not2,not;
            not1 = Convert.ToDouble(textBox3.Text);
            not2 = Convert.ToInt32(textBox4.Text);
            not = (not1 + not2) / 2;
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(not1);
            listBox4.Items.Add(not2);
            listBox5.Items.Add(not);
            if (not < 50)
            {
                listBox6.Items.Add("Kaldı");
            }
            else
            {
                listBox6.Items.Add("Geçti");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
        }
    }
}
