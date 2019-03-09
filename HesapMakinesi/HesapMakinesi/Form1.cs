using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);

            if (radioButtonTopla.Checked)
            {
                label3.Text = (sayi1 + sayi2).ToString();
            }
            else if (radioButtonCikar.Checked)
            {
                label3.Text = (sayi1 - sayi2).ToString();
            }
            else if (radioButtonCarp.Checked)
            {
                label3.Text = (sayi1 * sayi2).ToString();
            }
            else if (radioButtonBölme.Checked)
            {
                label3.Text = (sayi1 / sayi2).ToString();
            }


        }
    }
}
