using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            do
            {
                listBox1.Items.Add("Ramazan");
                i++;
            } while (i<=20);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int say = 1;
            do
            {
                richTextBox1.Text =richTextBox1.Text+ " "+say.ToString();
                say++;
            } while (say<=30);
        }
    }
}
