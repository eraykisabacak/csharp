using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            int sayac = 0;
            int sayi = Convert.ToInt32(textBox1.Text);
            for(int i = 2; i < sayi; i++)
            {
                 for(int j = 2;j < i; j++)
                {
                    if (i%j == 0)
                    {
                        sayac++;                       
                    }
                }
                if(sayac == 0)
                {
                    textBox2.Text += i + " "; //System.Environment.NewLine
                }
                sayac = 0;
            }
            textBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            int s1 = Convert.ToInt32(textBox1.Text);
            int toplam = 0;
            int sayac = 0;
            for(int sayi = 1;; sayi++)
            {
                toplam = 0;
                for (int i = 1; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        toplam += i;
                    }
                }
                if (toplam == sayi)
                {
                    textBox2.Text += sayi + " ";
                    sayac++;
                }
                if(sayac == s1) { return; }
            }
           textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            int sayi = Convert.ToInt16(textBox1.Text);
            for(int j = 1; j <= sayi; j++)
            {
                string strsayi = j.ToString();
                int boyut = strsayi.Length;
                int toplam = 0;
                for(int i = 0; i < boyut; i++)
                {
                    toplam += (int)Math.Pow(strsayi[i] - '0', boyut); 
                }
                if(toplam == j)
                {
                    textBox2.Text += j + " ";
                }
            }
           textBox1.Clear();
        }
    }
}
