namespace TeamWork
{
    partial class KayitOl
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
            this.isimTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.soyisimTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KullaniciAdiTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SifreTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.KayitOlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isimTB
            // 
            this.isimTB.AcceptsTab = true;
            this.isimTB.Location = new System.Drawing.Point(423, 191);
            this.isimTB.Name = "isimTB";
            this.isimTB.Size = new System.Drawing.Size(306, 31);
            this.isimTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // soyisimTB
            // 
            this.soyisimTB.AcceptsTab = true;
            this.soyisimTB.Location = new System.Drawing.Point(423, 254);
            this.soyisimTB.Name = "soyisimTB";
            this.soyisimTB.Size = new System.Drawing.Size(306, 31);
            this.soyisimTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // KullaniciAdiTB
            // 
            this.KullaniciAdiTB.AcceptsTab = true;
            this.KullaniciAdiTB.Location = new System.Drawing.Point(423, 317);
            this.KullaniciAdiTB.Name = "KullaniciAdiTB";
            this.KullaniciAdiTB.Size = new System.Drawing.Size(306, 31);
            this.KullaniciAdiTB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre";
            // 
            // SifreTB
            // 
            this.SifreTB.AcceptsTab = true;
            this.SifreTB.Location = new System.Drawing.Point(423, 380);
            this.SifreTB.Name = "SifreTB";
            this.SifreTB.Size = new System.Drawing.Size(306, 31);
            this.SifreTB.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(761, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Happiness Pizza";
            // 
            // KayitOlButton
            // 
            this.KayitOlButton.Location = new System.Drawing.Point(371, 481);
            this.KayitOlButton.Name = "KayitOlButton";
            this.KayitOlButton.Size = new System.Drawing.Size(112, 34);
            this.KayitOlButton.TabIndex = 9;
            this.KayitOlButton.Text = "Kayıt Ol";
            this.KayitOlButton.UseVisualStyleBackColor = true;
            this.KayitOlButton.Click += new System.EventHandler(this.KayitOlButton_Click);
            // 
            // KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 622);
            this.Controls.Add(this.KayitOlButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SifreTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KullaniciAdiTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soyisimTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isimTB);
            this.Name = "KayitOl";
            this.Text = "KayitOl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox isimTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox soyisimTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox KullaniciAdiTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SifreTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button KayitOlButton;
    }
}