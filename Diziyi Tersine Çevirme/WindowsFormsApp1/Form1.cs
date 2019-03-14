using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int i = -1;
        int[] dizi = new int[3];


        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            dizi[i] = Convert.ToInt16(textBox1.Text);
            if (i == 2)
            {
                button1.Enabled = false;
            }

            textBox1.Text = "";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int bellek;

            for (int i = 0; i < dizi.Length / 2; i++)
            {
                //dizinin ilk elemanını belleğe attık
                bellek = dizi[i];
                //dizinin son değerini ilk değerine eşitledik
                dizi[i] = dizi[dizi.Length - i - 1];
                //dizinin ilk değerini en sona attık
                dizi[dizi.Length - i - 1] = bellek;
            }

            for (int a = 0; a < dizi.Length; a++)
            {
                label2.Text += dizi[a].ToString() + "-";
                
            }

            Array.Clear(dizi, 0, dizi.Length);
            i = -1;
            button1.Enabled = true;
            label2.Text += "\n";

        }
    }
}
