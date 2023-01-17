using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamWork.Connection;


namespace TeamWork
{
    public partial class ImportForm : Form
    {
        TeamSqlConnection connect; //sql connection class = sql bağlantısı ayrı bir class teamsqlconnection üstüne sol tık sonra go to definition

        public ImportForm()
        {
            InitializeComponent();
        }

        private void btnSelectExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            SqlDataAdapter daInsert = new SqlDataAdapter();
            connect = new TeamSqlConnection("WorkTeam");
            string path = "";
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;//Ücretsiz Lisans

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string command = "";
                    string tabloAd = tablolarCB.Text;
                    if (String.IsNullOrWhiteSpace(tabloAd))
                    {
                        MessageBox.Show("Tablo Adı Seçin!");
                        return;
                    }
                    path = openFileDialog1.FileName;
                    FileInfo existingFile = new FileInfo(path);
                    using (ExcelPackage package = new ExcelPackage(existingFile))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        int colCount = worksheet.Dimension.End.Column;  //get Column Count
                        int rowCount = worksheet.Dimension.End.Row;     //get row count
                        for (int row = 2; row <= rowCount; row++)
                        {
                            switch (tabloAd)
                            {
                                case "personel":
                                    command = ($"INSERT INTO personel (personel_ad, personel_soyad, kullanici_adi, kullanici_sifre) VALUES ('{worksheet.Cells[row, 2].Value}', '{worksheet.Cells[row, 3].Value}', '{worksheet.Cells[row, 4].Value}', {worksheet.Cells[row, 5].Value})");
                                    break;
                                case "siparis":
                                    command = ($"INSERT INTO siparis (toplam_fiyat,  siparis_zamani, siparis_durumu,Musteri_id,personel_id,icecek_id) VALUES ('{worksheet.Cells[row, 2].Value}', '{DateTime.Today.ToString("yyyy-MM-dd")}', 1,{worksheet.Cells[row, 6].Value},{worksheet.Cells[row, 7].Value},{worksheet.Cells[row, 8].Value})");
                                    break;
                                case "Istek_pizza":
                                    command = ($"INSERT INTO personel (personel_ad, personel_soyad, kullanici_adi, kullanici_sifre) VALUES ('{worksheet.Cells[row, 2].Value}', '{worksheet.Cells[row, 3].Value}', '{worksheet.Cells[row, 4].Value}', {worksheet.Cells[row, 5].Value})");
                                    break;
                                case "musteri":
                                    command = ($"INSERT INTO personel (personel_ad, personel_soyad, kullanici_adi, kullanici_sifre) VALUES ('{worksheet.Cells[row, 2].Value}', '{worksheet.Cells[row, 3].Value}', '{worksheet.Cells[row, 4].Value}', {worksheet.Cells[row, 5].Value})");
                                    break;
                                case "odeme":
                                    command = ($"INSERT INTO personel (personel_ad, personel_soyad, kullanici_adi, kullanici_sifre) VALUES ('{worksheet.Cells[row, 2].Value}', '{worksheet.Cells[row, 3].Value}', '{worksheet.Cells[row, 4].Value}', {worksheet.Cells[row, 5].Value})");
                                    break;
                                case "icecek":
                                    command = ($"INSERT INTO personel (personel_ad, personel_soyad, kullanici_adi, kullanici_sifre) VALUES ('{worksheet.Cells[row, 2].Value}', '{worksheet.Cells[row, 3].Value}', '{worksheet.Cells[row, 4].Value}', {worksheet.Cells[row, 5].Value})");
                                    break;
                                case "icindekiler":
                                    command = ($"INSERT INTO personel (personel_ad, personel_soyad, kullanici_adi, kullanici_sifre) VALUES ('{worksheet.Cells[row, 2].Value}', '{worksheet.Cells[row, 3].Value}', '{worksheet.Cells[row, 4].Value}', {worksheet.Cells[row, 5].Value})");
                                    break;
                                case "pizza":
                                    command = ($"INSERT INTO personel (personel_ad, personel_soyad, kullanici_adi, kullanici_sifre) VALUES ('{worksheet.Cells[row, 2].Value}', '{worksheet.Cells[row, 3].Value}', '{worksheet.Cells[row, 4].Value}', {worksheet.Cells[row, 5].Value})");
                                    break;
                                default:
                                    break;
                            }

                            daInsert.InsertCommand = new SqlCommand(command, connect.Connect());
                            daInsert.InsertCommand.ExecuteNonQuery();//yazılan sorgu çalıştırıldı

                            MessageBox.Show("Başarılı!");
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Excel Dosyası Seçiniz!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            MusteriEkrani frm = new MusteriEkrani();
            frm.Show();
            this.Hide();
        }

        private void tablolarCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ImportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
