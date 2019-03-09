namespace HesapMakinesi
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonTopla = new System.Windows.Forms.RadioButton();
            this.radioButtonCikar = new System.Windows.Forms.RadioButton();
            this.radioButtonBölme = new System.Windows.Forms.RadioButton();
            this.radioButtonCarp = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayi 1:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayi 2:";
            // 
            // radioButtonTopla
            // 
            this.radioButtonTopla.AutoSize = true;
            this.radioButtonTopla.Checked = true;
            this.radioButtonTopla.Location = new System.Drawing.Point(16, 88);
            this.radioButtonTopla.Name = "radioButtonTopla";
            this.radioButtonTopla.Size = new System.Drawing.Size(52, 17);
            this.radioButtonTopla.TabIndex = 4;
            this.radioButtonTopla.TabStop = true;
            this.radioButtonTopla.Text = "Topla";
            this.radioButtonTopla.UseVisualStyleBackColor = true;
            // 
            // radioButtonCikar
            // 
            this.radioButtonCikar.AutoSize = true;
            this.radioButtonCikar.Location = new System.Drawing.Point(70, 88);
            this.radioButtonCikar.Name = "radioButtonCikar";
            this.radioButtonCikar.Size = new System.Drawing.Size(49, 17);
            this.radioButtonCikar.TabIndex = 5;
            this.radioButtonCikar.TabStop = true;
            this.radioButtonCikar.Text = "Çikar";
            this.radioButtonCikar.UseVisualStyleBackColor = true;
            // 
            // radioButtonBölme
            // 
            this.radioButtonBölme.AutoSize = true;
            this.radioButtonBölme.Location = new System.Drawing.Point(125, 88);
            this.radioButtonBölme.Name = "radioButtonBölme";
            this.radioButtonBölme.Size = new System.Drawing.Size(54, 17);
            this.radioButtonBölme.TabIndex = 6;
            this.radioButtonBölme.TabStop = true;
            this.radioButtonBölme.Text = "Bölme";
            this.radioButtonBölme.UseVisualStyleBackColor = true;
            // 
            // radioButtonCarp
            // 
            this.radioButtonCarp.AutoSize = true;
            this.radioButtonCarp.Location = new System.Drawing.Point(185, 88);
            this.radioButtonCarp.Name = "radioButtonCarp";
            this.radioButtonCarp.Size = new System.Drawing.Size(47, 17);
            this.radioButtonCarp.TabIndex = 7;
            this.radioButtonCarp.TabStop = true;
            this.radioButtonCarp.Text = "Çarp";
            this.radioButtonCarp.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 75);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 61);
            this.label3.TabIndex = 9;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 286);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonCarp);
            this.Controls.Add(this.radioButtonBölme);
            this.Controls.Add(this.radioButtonCikar);
            this.Controls.Add(this.radioButtonTopla);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonTopla;
        private System.Windows.Forms.RadioButton radioButtonCikar;
        private System.Windows.Forms.RadioButton radioButtonBölme;
        private System.Windows.Forms.RadioButton radioButtonCarp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

