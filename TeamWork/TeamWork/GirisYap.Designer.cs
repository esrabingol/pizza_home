namespace TeamWork
{
    partial class GirisYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisYap));
            this.KullaniciAdiTB = new System.Windows.Forms.TextBox();
            this.SifreTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GirisYapButton = new System.Windows.Forms.Button();
            this.KayitOlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KullaniciAdiTB
            // 
            this.KullaniciAdiTB.Location = new System.Drawing.Point(167, 58);
            this.KullaniciAdiTB.Name = "KullaniciAdiTB";
            this.KullaniciAdiTB.Size = new System.Drawing.Size(205, 23);
            this.KullaniciAdiTB.TabIndex = 0;
            // 
            // SifreTB
            // 
            this.SifreTB.Location = new System.Drawing.Point(167, 115);
            this.SifreTB.Name = "SifreTB";
            this.SifreTB.Size = new System.Drawing.Size(205, 23);
            this.SifreTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // GirisYapButton
            // 
            this.GirisYapButton.Location = new System.Drawing.Point(196, 157);
            this.GirisYapButton.Name = "GirisYapButton";
            this.GirisYapButton.Size = new System.Drawing.Size(147, 23);
            this.GirisYapButton.TabIndex = 4;
            this.GirisYapButton.Text = "Giriş Yap";
            this.GirisYapButton.UseVisualStyleBackColor = true;
            this.GirisYapButton.Click += new System.EventHandler(this.GirisYapButton_Click);
            // 
            // KayitOlButton
            // 
            this.KayitOlButton.Location = new System.Drawing.Point(196, 199);
            this.KayitOlButton.Name = "KayitOlButton";
            this.KayitOlButton.Size = new System.Drawing.Size(147, 23);
            this.KayitOlButton.TabIndex = 5;
            this.KayitOlButton.Text = "KayıtOl";
            this.KayitOlButton.UseVisualStyleBackColor = true;
            this.KayitOlButton.Click += new System.EventHandler(this.KayitOlButton_Click);
            // 
            // GirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(523, 324);
            this.Controls.Add(this.KayitOlButton);
            this.Controls.Add(this.GirisYapButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SifreTB);
            this.Controls.Add(this.KullaniciAdiTB);
            this.Name = "GirisYap";
            this.Text = "GirisYap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KullaniciAdiTB;
        private System.Windows.Forms.TextBox SifreTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GirisYapButton;
        private System.Windows.Forms.Button KayitOlButton;
    }
}