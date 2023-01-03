using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TeamWork.Connection;

namespace TeamWork
{
    public partial class PizzaHome : Form
    {
        TeamSqlConnection connect;
        public PizzaHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect = new TeamSqlConnection("master");
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string directoryPath = dialog.SelectedPath;

                    string backUpName = textBox1.Text;//kullanıcıdan yedeklenen dosyanın adını girmesi istenir
                    if(string.IsNullOrWhiteSpace(backUpName))
                    {
                        MessageBox.Show("Yedekleme yapabilmek için lütfen backup alınacak dosya ismi giriniz.","Uyarı", MessageBoxButtons.OK);
                        return;
                    }

                    using (SqlCommand command = new SqlCommand($"BACKUP DATABASE WebSiteDB TO DISK = '{directoryPath}\\{backUpName}.bak'", connect.Connect()))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KB74JGP\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"))
            {
                connection.Open();

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "SQL Server database backup files|*.bak";

                    openFileDialog.DefaultExt = "bak"; //klasör ve dosyalar içinde .bak uzantılı dosyaları araması için filtreleme yapıldı

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName; //.bak uzantılı yedeklenen backup dosyasının dizini alınır

                        using (SqlCommand command = connection.CreateCommand())
                        {
                            //runtime esnasında baglantı koparılmadan yedek dosyanın veri tabanına aktarılması saglanır
                            command.CommandText = "USE [master] Alter Database WebSiteDB SET SINGLE_USER With ROLLBACK IMMEDIATE RESTORE DATABASE HappyWebSiteDB FROM DISK = @backupFile WITH REPLACE";
                            command.Parameters.AddWithValue("@backupFile", filePath);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connect = new TeamSqlConnection("WebSiteDB");
            DataTable dt = new DataTable();
            //veritanından hangi tablodan veri çekmek istiyorsanız o tabloyu yazacaksınız.
            SqlDataAdapter da = new SqlDataAdapter("Select * from Projects", connect.Connect());
            da.Fill(dataTable: dt);
            dataGridView1.DataSource = dt;
        }
    }
}
