using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metodlar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesap(int x,int y)
        {
            label3.Text = (x * y).ToString(); ;

        }
     private void button1_Click(object sender, EventArgs e)
        {
            hesap(int.Parse(textBox1.Text),int.Parse(textBox2.Text));
        }
    }
}
