namespace TeamWork
{
    partial class AdminEkrani
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
            this.PizzaCEkleLabel = new System.Windows.Forms.Label();
            this.EklenenCtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.icecekCTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PizzaCEkleLabel
            // 
            this.PizzaCEkleLabel.AutoSize = true;
            this.PizzaCEkleLabel.Location = new System.Drawing.Point(276, 70);
            this.PizzaCEkleLabel.Name = "PizzaCEkleLabel";
            this.PizzaCEkleLabel.Size = new System.Drawing.Size(92, 15);
            this.PizzaCEkleLabel.TabIndex = 0;
            this.PizzaCEkleLabel.Text = "Pizza Çeşidi Ekle";
            // 
            // EklenenCtB
            // 
            this.EklenenCtB.Location = new System.Drawing.Point(401, 67);
            this.EklenenCtB.Name = "EklenenCtB";
            this.EklenenCtB.Size = new System.Drawing.Size(100, 23);
            this.EklenenCtB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "İçecek Çeşidi Ekle";
            // 
            // icecekCTB
            // 
            this.icecekCTB.Location = new System.Drawing.Point(401, 121);
            this.icecekCTB.Name = "icecekCTB";
            this.icecekCTB.Size = new System.Drawing.Size(100, 23);
            this.icecekCTB.TabIndex = 3;
            this.icecekCTB.TextChanged += new System.EventHandler(this.icecekCTB_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Admin User";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(675, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sipariş Ekranı";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Çıkış";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.icecekCTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EklenenCtB);
            this.Controls.Add(this.PizzaCEkleLabel);
            this.Name = "AdminEkrani";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AdminEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PizzaCEkleLabel;
        private System.Windows.Forms.TextBox EklenenCtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox icecekCTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}