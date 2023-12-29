using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler155
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 100; i <= 1000; i=i+5)
            {
                listBox1.Items.Add(i);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.E)
            {
                for (int ı =150;ı>10;ı=ı-10)
                {
                    listBox2.Items.Add(ı);
                }
            }
        }
    }
}
