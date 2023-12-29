using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degerler24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string say =  comboBox1.Text;
            switch (say)
            {
                case "Mavi":
                    label1.ForeColor = Color.Blue;break;
                case "Kırmızı":
                    label1.ForeColor = Color.Red;break;
                case "Yeşil":
                    label1.ForeColor = Color.Green;break;
            }
        }
    }
}
