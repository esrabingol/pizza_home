namespace TeamWork
{
    partial class ImportForm
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
            this.btnSelectExcel = new System.Windows.Forms.Button();
            this.tablolarCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectExcel
            // 
            this.btnSelectExcel.Location = new System.Drawing.Point(344, 37);
            this.btnSelectExcel.Name = "btnSelectExcel";
            this.btnSelectExcel.Size = new System.Drawing.Size(143, 23);
            this.btnSelectExcel.TabIndex = 1;
            this.btnSelectExcel.Text = "Excel Seç";
            this.btnSelectExcel.UseVisualStyleBackColor = true;
            this.btnSelectExcel.Click += new System.EventHandler(this.btnSelectExcel_Click);
            // 
            // tablolarCB
            // 
            this.tablolarCB.FormattingEnabled = true;
            this.tablolarCB.Items.AddRange(new object[] {
            "personel",
            "siparis",
            "Istek_pizza",
            "musteri",
            "odeme",
            "icecek",
            "icindekiler",
            "pizza"});
            this.tablolarCB.Location = new System.Drawing.Point(12, 37);
            this.tablolarCB.Name = "tablolarCB";
            this.tablolarCB.Size = new System.Drawing.Size(326, 23);
            this.tablolarCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tablo Adı Seçin";
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 90);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablolarCB);
            this.Controls.Add(this.btnSelectExcel);
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectExcel;
        private System.Windows.Forms.ComboBox tablolarCB;
        private System.Windows.Forms.Label label1;
    }
}