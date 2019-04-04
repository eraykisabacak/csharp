using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmStrongSayisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = (int)numericUpDown1.Value;

            for(int  j= 1; j <= sayi; j++)
            {
                string strSayi = j.ToString();
                int bs = strSayi.Length;
                int toplam = 0;
                for (int i = 0; i < bs; i++)
                {
                    toplam += (int)Math.Pow(strSayi[i] - '0', bs);
                }
                if(toplam == j)
                {
                    textBox1.Text += j + " ";
                }
            } 
        }
    }
}
