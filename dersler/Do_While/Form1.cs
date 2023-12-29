using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            string ad = txtara.Text;
            int i = 0;
            do
            {
                if (lbliste.Items[i].ToString() == ad)
                {
                    MessageBox.Show(lbliste.Items[i].ToString() + " Adlı Müşteri Bulundu!");
                    break;
                }
                i++;
            } while (i < lbliste.Items.Count);
        }
    }
}
