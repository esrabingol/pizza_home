using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamWork.Connection;

namespace TeamWork
{
    public partial class KayitOl : Form
    {
        TeamSqlConnection connect; //sql connection class = sql bağlantısı ayrı bir class teamsqlconnection üstüne sol tık sonra go to definition

        public KayitOl()
        {
            InitializeComponent();
        }

        private void KayitOlButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(isimTB.Text)) //eğer null deseydik " " yani boş stringi veri kabul eder ve null olmazdı. Nulll olması için isNullOr..olur.
                MessageBox.Show("İsim Alanı Boş Olamaz!");
            else if (String.IsNullOrWhiteSpace(soyisimTB.Text))
                MessageBox.Show("Soyisim Alanı Boş Olamaz!");
            else if (String.IsNullOrWhiteSpace(KullaniciAdiTB.Text))
                MessageBox.Show("Kullanıcı Adı Alanı Boş Olamaz!");
            else if (String.IsNullOrWhiteSpace(SifreTB.Text))
                MessageBox.Show("Şifre Alanı Boş Olamaz!");
            else
            {               
                connect = new TeamSqlConnection("WorkTeam");
                DataTable personelDataT = new DataTable();//veri görüntülemek için datatable oluşturulur
                //sql deki tablonun c deki karşılığı bu tabloda olacaktır.
                SqlDataAdapter da = new SqlDataAdapter($"Select * from personel Where kullanici_adi = '{KullaniciAdiTB.Text}'", connect.Connect()); // sql connection dan connect() fonk çağrılır

                //ezber kullanım sqldataadapter 
                da.Fill(dataTable: personelDataT); //personelDataT doldurmak(fill) için 
                if (personelDataT.Rows.Count > 0)//personelDataT getirilen satır sayısı >0 ise demek ki önceden kayıt oluşturulmuş demektir
                {
                    MessageBox.Show("Girdiğiniz kullanıcı adı ile kayıt mevcut başka kullanıcı adı deneyin!");
                }
                else
                {
                    try
                    {
                        SqlDataAdapter daInsert = new SqlDataAdapter();
                        string command = ($"INSERT INTO personel (personel_ad, personel_soyad, kullanici_adi, kullanici_sifre) VALUES ('{isimTB.Text}', '{soyisimTB.Text}', '{KullaniciAdiTB.Text}', {SifreTB.Text})");
                        daInsert.InsertCommand = new SqlCommand(command,connect.Connect());
                        daInsert.InsertCommand.ExecuteNonQuery();//yazılan sorgu çalıştırıldı
                        MessageBox.Show("Kayıt Başarılı, Giriiş Yapabilirsiniz.");
                        GirisYap frm = new GirisYap();
                        frm.Show();
                        this.Hide();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }      
                }
            }
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {
            GirisYap frm = new GirisYap();
            frm.Show();
            this.Hide();
        }
    }
}
