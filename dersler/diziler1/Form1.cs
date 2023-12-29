using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[];

        private void button1_Click(object sender, EventArgs e)
        {
          

            for (int i = 0; i <5 ; i++)
            {
                isimler[i] = textBox1.Text;
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                listBox1.Items.Add(isimler[i]);
            }

            
        }
    }
}
