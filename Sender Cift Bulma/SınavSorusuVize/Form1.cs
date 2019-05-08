using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SınavSorusuVize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int alt = (int)numericUpDown1.Value;
            int ust = (int)numericUpDown2.Value;
            if (ust - alt < 20) return; // Eğer 20 farklı sayı isteniyorsa arasında 20 farklı sayı olması lazım

            int[] dizi = new int[20];
            Random rnd = new Random();

            for(int i = 1;i <= 20; i++)
            {
                bool ctrl = false;
                int temp = -1;                
                do
                {
                    ctrl = false;
                    temp = rnd.Next(alt, ust);
                    for (int j = 0; j < i; j++)
                    {
                        if (dizi[j] == temp)
                        {
                            ctrl = true;
                            break;
                        }
                    }
                } while (ctrl);
               // MessageBox.Show(temp.ToString());

                dizi[i - 1] = temp;
                Button btn = (Button)this.Controls["button" + i];
                btn.BackColor = SystemColors.ControlLight;
                btn.Text = temp.ToString();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kontrol((Button)sender);
        }

        void Kontrol(Button btn)
        {
            if (int.Parse(btn.Text) % 2 != 0) return;
            int id = int.Parse(btn.Name.Substring(6));
            btn.BackColor = Color.White;

            Button[] komsu = new Button[4];
            komsu[0] = id > 5 ? (Button)this.Controls["button" + (id - 5)] : null;
            komsu[1] = id < 16 ? (Button)this.Controls["button" + (id + 5)] : null;
            komsu[2] = id % 5 != 1 ? (Button)this.Controls["button" + (id - 1)] : null;
            komsu[3] = id % 5 != 0 ? (Button)this.Controls["button" + (id + 1)] : null;

            for(int i = 0; i < komsu.Length; i++)
            {
                if(komsu[i] != null && komsu[i].BackColor != Color.White)
                {
                    Kontrol(komsu[i]);
                }
            }



        }
    }
}
