using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kendin_yap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkontrol_Click(object sender, EventArgs e)
        {
            string aktar = txtyazdir.Text;

            if (rb1.Checked == true)
            {
                lbliste1.Items.Add(aktar);
            }
            else if (rb2.Checked== true)
            {
                lbliste2.Items.Add(aktar);
            }
        }

    }
}
