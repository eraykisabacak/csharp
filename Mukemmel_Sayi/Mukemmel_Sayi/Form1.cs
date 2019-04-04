using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mukemmel_Sayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int verilensayi = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();
            int toplam;
            for(int sayi = 1;sayi < verilensayi; sayi++)
            {
                toplam = 0;
                
                for (int islem = 1; islem < sayi; islem++)
                {
                    if (sayi % islem == 0)
                    {
                        toplam = toplam + islem;
                    }

                }
                if (sayi == toplam)
                {
                    listBox1.Items.Add(sayi);
                }


            }
            textBox1.Text = "";
            




        }
    }
}
