﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5e_Bolunen_7ye_Bolunmeyen_Sayilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt16(textBox1.Text);
            int sayi2 = Convert.ToInt16(textBox2.Text);
            int i;
            for (i = sayi1; i < sayi2; i++)
            {
                if ((i % 5 == 0) && (i % 7 != 0))
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
