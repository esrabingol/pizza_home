namespace TeamWork
{
    partial class SiparislerForm
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
            this.siparisDGW = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.istekPizzaDGW = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.siparisDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.istekPizzaDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // siparisDGW
            // 
            this.siparisDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siparisDGW.Location = new System.Drawing.Point(7, 41);
            this.siparisDGW.Name = "siparisDGW";
            this.siparisDGW.RowTemplate.Height = 25;
            this.siparisDGW.Size = new System.Drawing.Size(781, 180);
            this.siparisDGW.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(323, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Siparişler";
            // 
            // istekPizzaDGW
            // 
            this.istekPizzaDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.istekPizzaDGW.Location = new System.Drawing.Point(7, 271);
            this.istekPizzaDGW.Name = "istekPizzaDGW";
            this.istekPizzaDGW.RowTemplate.Height = 25;
            this.istekPizzaDGW.Size = new System.Drawing.Size(780, 167);
            this.istekPizzaDGW.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(301, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sipariş İçeriği";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(712, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bilgi Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.istekPizzaDGW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siparisDGW);
            this.Name = "Siparisler";
            this.Text = "Siparisler";
            ((System.ComponentModel.ISupportInitialize)(this.siparisDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.istekPizzaDGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView siparisDGW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView istekPizzaDGW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}