using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }           
         
         

        private void button1_Click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(textBox_sayi1.Text);
            double s2 = Convert.ToDouble(textBox_sayi2.Text);
            double sonuc = 0;

            if(textBox_sayi1.Text.Trim() == "" || textBox_sayi1.Text.Trim() == "")
            {
                MessageBox.Show("önce sayıları girin", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (topla.Checked)
            {
                
                sonuc = s1 + s2;
                MessageBox.Show(s1 + " + " + s2 + " = " + sonuc);
                label4.Text = (s1 + s2).ToString();
            }
            if (cikar.Checked)
            {
                
                label4.Text = (s1 - s2).ToString();
                sonuc = s1 - s2;
                MessageBox.Show(s1 + " - " + s2 + " = " + sonuc);
            }
            if (carp.Checked)
            {
                
                label4.Text = (s1 * s2).ToString();
                sonuc = s1 * s2;
                MessageBox.Show(s1 + " * " + s2 + " = " + sonuc);
            }
            if (bol.Checked)
            {
                
                label4.Text = (s1 / s2).ToString();
                sonuc = s1 / s2;
                MessageBox.Show(s1 + " / " + s2 + " = " + sonuc);
            }
        }

        private void topla_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cikar_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void carp_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void bol_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int secim = listBox1.SelectedIndex;
            if(secim != -1)
            {
                listBox1.Items.RemoveAt(secim);
            }
            else{
                MessageBox.Show("Seçim Yapınız!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        
    
        private void button10_Click(object sender, EventArgs e)
        {
            if (artir.Checked)
            {
                timer1.Enabled = true;
            }

            else if (azalt.Checked)
            {
                progressBar1.Value = 0;
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            timer1.Interval = 100;

            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Enabled = false;           
            }
            if(progressBar1.Value != 100)          
            {
                progressBar1.Value += 1;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox_islem.Text);
            textBox_islem.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string secim = listBox1.SelectedItem.ToString();
            

            if(secim.Equals("topla"))
            {
                double sayi1 = Convert.ToDouble(textBox_sayi1.Text);
                double sayi2 = Convert.ToDouble(textBox_sayi2.Text);

                double sonuc2 = (sayi1 + sayi2);

                label4.Text = "Sonuc = " + sonuc2.ToString();
                             
            }
            if (secim.Equals("cikar"))
            {
                double sayi1 = Convert.ToDouble(textBox_sayi1.Text);
                double sayi2 = Convert.ToDouble(textBox_sayi2.Text);

                double sonuc2 = (sayi1 - sayi2);

                label4.Text = "Sonuc " + sonuc2.ToString();

            }
            if (secim.Equals("carp"))
            {
                double sayi1 = Convert.ToDouble(textBox_sayi1.Text);
                double sayi2 = Convert.ToDouble(textBox_sayi2.Text);

                double sonuc2 = (sayi1 * sayi2);

                label4.Text = "Sonuc " + sonuc2.ToString();

            }
            if (secim.Equals("bol"))
            {
                double sayi1 = Convert.ToDouble(textBox_sayi1.Text);
                double sayi2 = Convert.ToDouble(textBox_sayi2.Text);

                double sonuc2 = (sayi1 / sayi2);

                label4.Text = "Sonuc " + sonuc2.ToString();

            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox1.Text); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string secim = comboBox1.SelectedItem.ToString();


            if (secim.Equals("topla"))
            {
                double sayi1 = Convert.ToDouble(textBox_sayi1.Text);
                double sayi2 = Convert.ToDouble(textBox_sayi2.Text);

                double sonuc2 = (sayi1 + sayi2);

                label5.Text = "Sonuc " + sonuc2.ToString();

            }
            if (secim.Equals("cikar"))
            {
                double sayi1 = Convert.ToDouble(textBox_sayi1.Text);
                double sayi2 = Convert.ToDouble(textBox_sayi2.Text);

                double sonuc2 = (sayi1 - sayi2);

                label5.Text = "Sonuc " + sonuc2.ToString();

            }
            if (secim.Equals("carp"))
            {
                double sayi1 = Convert.ToDouble(textBox_sayi1.Text);
                double sayi2 = Convert.ToDouble(textBox_sayi2.Text);

                double sonuc2 = (sayi1 * sayi2);

                label5.Text = "Sonuc " + sonuc2.ToString();

            }
            if (secim.Equals("bol"))
            {
                double sayi1 = Convert.ToDouble(textBox_sayi1.Text);
                double sayi2 = Convert.ToDouble(textBox_sayi2.Text);

                double sonuc2 = (sayi1 / sayi2);

                label5.Text = "Sonuc " + sonuc2.ToString();

            }
        }
    }
}
