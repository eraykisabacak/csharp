using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LREalgoritması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] txt = textBox1.Text.ToCharArray();
            int sayac = 1;
            
            for (int i = 0; i < txt.Length-1; i++)
            {
                        
                if (txt[i] == txt[i + 1])
                {
                    sayac++;
                }
                else
                {
                    label1.Text += " " + txt[i] + " " + sayac;
                    sayac = 1;
                }

            }



        }
    }
}
