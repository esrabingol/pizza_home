using Azure;
using OfficeOpenXml;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web;
using System.Windows.Forms;

using TeamWork.Connection;

namespace TeamWork
{
    public partial class ExportFrom : Form
    {
        TeamSqlConnection connect;
        DataTable dt = new DataTable();
        public ExportFrom()
        {
            InitializeComponent();
        }

        private void btnBilgiGetir_Click(object sender, EventArgs e)
        {
            string tabloAdi = TabloAdiTB.Text;
            if (!String.IsNullOrWhiteSpace(tabloAdi))
            {
                connect = new TeamSqlConnection("WorkTeam");
              
                //veritanından hangi tablodan veri çekmek istiyorsanız o tabloyu yazacaksınız.
                SqlDataAdapter da = new SqlDataAdapter($"Select * from {tabloAdi}", connect.Connect());
                da.Fill(dataTable: dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Tablo adı girilmeli.");
            }
        }

        private void ExportAlBtn_Click(object sender, EventArgs e)
        {
            string tabloAdi = TabloAdiTB.Text;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;//Ücretsiz Lisans

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })//Dosya adı ve yolu seçme 
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var fileInfo = new FileInfo(sfd.FileName);
                    using (ExcelPackage excelPackage = new ExcelPackage(fileInfo))
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("export");
                        worksheet.Cells.LoadFromDataTable(dt, true);//Data Table excel hücrelerine aktarma
                        excelPackage.Save();
                    }
                }
            }
        }
    }
}
