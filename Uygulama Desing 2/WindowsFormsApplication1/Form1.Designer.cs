namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.topla = new System.Windows.Forms.CheckBox();
            this.cikar = new System.Windows.Forms.CheckBox();
            this.bol = new System.Windows.Forms.CheckBox();
            this.carp = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_sayi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_sayi1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_islem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.azalt = new System.Windows.Forms.RadioButton();
            this.artir = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // topla
            // 
            this.topla.AutoSize = true;
            this.topla.Location = new System.Drawing.Point(12, 25);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(49, 17);
            this.topla.TabIndex = 0;
            this.topla.Text = "topla";
            this.topla.UseVisualStyleBackColor = true;
            this.topla.CheckedChanged += new System.EventHandler(this.topla_CheckedChanged);
            // 
            // cikar
            // 
            this.cikar.AutoSize = true;
            this.cikar.Location = new System.Drawing.Point(67, 25);
            this.cikar.Name = "cikar";
            this.cikar.Size = new System.Drawing.Size(49, 17);
            this.cikar.TabIndex = 1;
            this.cikar.Text = "çıkar";
            this.cikar.UseVisualStyleBackColor = true;
            this.cikar.CheckedChanged += new System.EventHandler(this.cikar_CheckedChanged);
            // 
            // bol
            // 
            this.bol.AutoSize = true;
            this.bol.Location = new System.Drawing.Point(175, 25);
            this.bol.Name = "bol";
            this.bol.Size = new System.Drawing.Size(40, 17);
            this.bol.TabIndex = 3;
            this.bol.Text = "böl";
            this.bol.UseVisualStyleBackColor = true;
            this.bol.CheckedChanged += new System.EventHandler(this.bol_CheckedChanged);
            // 
            // carp
            // 
            this.carp.AutoSize = true;
            this.carp.Location = new System.Drawing.Point(122, 25);
            this.carp.Name = "carp";
            this.carp.Size = new System.Drawing.Size(47, 17);
            this.carp.TabIndex = 2;
            this.carp.Text = "çarp";
            this.carp.UseVisualStyleBackColor = true;
            this.carp.CheckedChanged += new System.EventHandler(this.carp_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(1, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sayı 1 =";
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox_sayi2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_sayi1);
            this.panel1.Controls.Add(this.topla);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cikar);
            this.panel1.Controls.Add(this.bol);
            this.panel1.Controls.Add(this.carp);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 79);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_sayi2
            // 
            this.textBox_sayi2.Location = new System.Drawing.Point(192, 47);
            this.textBox_sayi2.Name = "textBox_sayi2";
            this.textBox_sayi2.Size = new System.Drawing.Size(83, 20);
            this.textBox_sayi2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(139, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sayı 2 =";
            // 
            // textBox_sayi1
            // 
            this.textBox_sayi1.Location = new System.Drawing.Point(56, 47);
            this.textBox_sayi1.Name = "textBox_sayi1";
            this.textBox_sayi1.Size = new System.Drawing.Size(83, 20);
            this.textBox_sayi1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.textBox_islem);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 173);
            this.panel2.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(140, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "sonuç";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(140, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "temizle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(140, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Çıkar >>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "<< Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 108);
            this.listBox1.TabIndex = 8;
            // 
            // textBox_islem
            // 
            this.textBox_islem.Location = new System.Drawing.Point(60, 19);
            this.textBox_islem.Name = "textBox_islem";
            this.textBox_islem.Size = new System.Drawing.Size(152, 20);
            this.textBox_islem.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "işlem =";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Location = new System.Drawing.Point(233, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 173);
            this.panel3.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(28, 129);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "sonuç";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "topla",
            "cikar",
            "carp",
            "bol"});
            this.comboBox1.Location = new System.Drawing.Point(3, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(28, 100);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "temizle";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(28, 71);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 14;
            this.button8.Text = "Çıkar >>";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(28, 42);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 13;
            this.button9.Text = "<< Ekle";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.progressBar1);
            this.panel4.Controls.Add(this.button10);
            this.panel4.Controls.Add(this.azalt);
            this.panel4.Controls.Add(this.artir);
            this.panel4.Location = new System.Drawing.Point(12, 286);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(346, 73);
            this.panel4.TabIndex = 8;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(122, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(90, 25);
            this.button10.TabIndex = 2;
            this.button10.Text = "Başla";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // azalt
            // 
            this.azalt.AutoSize = true;
            this.azalt.Location = new System.Drawing.Point(69, 23);
            this.azalt.Name = "azalt";
            this.azalt.Size = new System.Drawing.Size(47, 17);
            this.azalt.TabIndex = 1;
            this.azalt.TabStop = true;
            this.azalt.Text = "azalt";
            this.azalt.UseVisualStyleBackColor = true;
            // 
            // artir
            // 
            this.artir.AutoSize = true;
            this.artir.Location = new System.Drawing.Point(12, 23);
            this.artir.Name = "artir";
            this.artir.Size = new System.Drawing.Size(42, 17);
            this.artir.TabIndex = 0;
            this.artir.TabStop = true;
            this.artir.Text = "artır";
            this.artir.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(0, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sonuc =";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(0, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sonuc =";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 46);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(331, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Panel 1";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(346, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Panel 4";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Panel 2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Panel 3";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(370, 371);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox topla;
        private System.Windows.Forms.CheckBox cikar;
        private System.Windows.Forms.CheckBox bol;
        private System.Windows.Forms.CheckBox carp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_islem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.RadioButton azalt;
        private System.Windows.Forms.RadioButton artir;
        public System.Windows.Forms.TextBox textBox_sayi2;
        public System.Windows.Forms.TextBox textBox_sayi1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

