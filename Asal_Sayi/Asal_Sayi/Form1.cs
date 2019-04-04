using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asal_Sayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("LÜTFEN SAYI GİRİNİZ");
            }
            else
            {

                int sayi1 = Convert.ToInt16(textBox1.Text);
                int sayac = 0;
                for (int i = 2; i < sayi1; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            sayac = sayac + 1;
                        }
                    }
                    if (sayac == 2)
                    {
                        listBox1.Items.Add(i);
                    }
                    sayac = 0;
                }
            }
        }
    }
}
