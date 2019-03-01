namespace Sag_Sol_Yukari_Asagi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.yukari = new System.Windows.Forms.Button();
            this.asagi = new System.Windows.Forms.Button();
            this.sol = new System.Windows.Forms.Button();
            this.sag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yukari
            // 
            this.yukari.Location = new System.Drawing.Point(357, 107);
            this.yukari.Name = "yukari";
            this.yukari.Size = new System.Drawing.Size(131, 41);
            this.yukari.TabIndex = 0;
            this.yukari.Text = "Yukari";
            this.yukari.UseVisualStyleBackColor = true;
            this.yukari.Click += new System.EventHandler(this.yukari_Click);
            // 
            // asagi
            // 
            this.asagi.Location = new System.Drawing.Point(357, 201);
            this.asagi.Name = "asagi";
            this.asagi.Size = new System.Drawing.Size(131, 41);
            this.asagi.TabIndex = 1;
            this.asagi.Text = "Aşağı";
            this.asagi.UseVisualStyleBackColor = true;
            this.asagi.Click += new System.EventHandler(this.asagi_Click);
            // 
            // sol
            // 
            this.sol.Location = new System.Drawing.Point(260, 154);
            this.sol.Name = "sol";
            this.sol.Size = new System.Drawing.Size(131, 41);
            this.sol.TabIndex = 3;
            this.sol.Text = "Sol";
            this.sol.UseVisualStyleBackColor = true;
            this.sol.Click += new System.EventHandler(this.sol_Click);
            // 
            // sag
            // 
            this.sag.Location = new System.Drawing.Point(453, 154);
            this.sag.Name = "sag";
            this.sag.Size = new System.Drawing.Size(131, 41);
            this.sag.TabIndex = 2;
            this.sag.Text = "Sağ";
            this.sag.UseVisualStyleBackColor = true;
            this.sag.Click += new System.EventHandler(this.sag_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sol);
            this.Controls.Add(this.sag);
            this.Controls.Add(this.asagi);
            this.Controls.Add(this.yukari);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yukari;
        private System.Windows.Forms.Button asagi;
        private System.Windows.Forms.Button sol;
        private System.Windows.Forms.Button sag;
    }
}

