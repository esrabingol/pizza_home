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
    public partial class GirisYap : Form
    {
        TeamSqlConnection connect; //sql connection class = sql bağlantısı ayrı bir class teamsqlconnection üstüne sol tık sonra go to definition
        public GirisYap()
        {
            InitializeComponent();
            SifreTB.PasswordChar = '*';
        }

        private void KayitOlButton_Click(object sender, EventArgs e)
        {
            KayitOl formKayit = new KayitOl();
            formKayit.Show();
            this.Hide();
        }

        private void GirisYapButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(KullaniciAdiTB.Text))
            {
                MessageBox.Show("Kullanıcı Adı Alanı Boş Olamaz!");
                return;
            }
            if (String.IsNullOrWhiteSpace(SifreTB.Text))
            {
                MessageBox.Show("Şifre Alanı Boş Olamaz!");
                return;
            }

            connect = new TeamSqlConnection("WorkTeam");
            DataTable kullaniciDataT = new DataTable();//veri görüntülemek için datatable oluşturulur
                                                       //sql deki tablonun c deki karşılığı bu tabloda olacaktır.
            SqlDataAdapter da = new SqlDataAdapter($"Select * from personel Where kullanici_adi = '{KullaniciAdiTB.Text}'", connect.Connect()); // sql connection dan connect() fonk çağrılır

            da.Fill(dataTable: kullaniciDataT); //kullaniciDataT doldurmak(fill) için 

            if (kullaniciDataT.Rows.Count > 0)//kullaniciDataT getirilen satır sayısı >0 ise kullanıcı adı doğru
            {
                var sifre = kullaniciDataT.Rows[0]["kullanici_sifre"].ToString();

                if (KullaniciAdiTB.Text == "Admin") //admin girişi
                {
                    if (SifreTB.Text == sifre)
                    {

                        MessageBox.Show("Admin Giriş Başarılı, Hoşgeldiniz");
                        SiparislerForm frm = new SiparislerForm();
                        frm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // sıradan kullanıcı girişi
                {
                    if (SifreTB.Text == sifre)
                    {
                        MessageBox.Show("Giriş Başarılı, Hoşgeldiniz");
                        MusteriEkrani frm = new MusteriEkrani(); // sıradan kullanıcıyı kullanıcı ekranına yönlendirme
                        frm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            


        }
    }
}
