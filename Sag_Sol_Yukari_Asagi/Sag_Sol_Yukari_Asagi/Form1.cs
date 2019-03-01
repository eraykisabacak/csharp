using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sag_Sol_Yukari_Asagi
{
    public partial class Form1 : Form
    {
        Form2 fr2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            fr2.Show();


        }

        private void yukari_Click(object sender, EventArgs e)
        {
            fr2.Top -= 25;
        }

        private void sol_Click(object sender, EventArgs e)
        {
            fr2.Left -= 25;
        }

        private void sag_Click(object sender, EventArgs e)
        {
            fr2.Left += 25;
        }

        private void asagi_Click(object sender, EventArgs e)
        {
            fr2.Top += 25;
        }
    }
}
