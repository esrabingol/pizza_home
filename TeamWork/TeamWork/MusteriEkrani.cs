using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TeamWork
{
    public partial class MusteriEkrani : Form
    {
        public MusteriEkrani()
        {
            InitializeComponent();
        }
        public string pizzacesidi { get; set; }
        public string icecekcesidi { get; set; }

        SqlConnection baglanti = new SqlConnection("Data Source = LAPTOP - IPQTP7GR; Initial Catalog = { dynamicConnectionString }; Integrated Security = True");
        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //müşteri ekle
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into musteri(isim,soyad,mail,telefon_nmrs,adres,sehir) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            komut.Parameters.AddWithValue("@p4", textBox4.Text);
            komut.Parameters.AddWithValue("@p5", textBox5.Text);
            komut.Parameters.AddWithValue("@p6", textBox6.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri eklendi");
        }

        public int fiyat = 30; //içecek ve hamur dahil
        public int sayac = 0;
        public int icecekucret = 0;
        public int iceceksayac = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            //fiyat
            int artis_degeri = Convert.ToInt32(numericUpDown1.Value);
            sayac += artis_degeri;
            int artis_degeri2 = Convert.ToInt32(numericUpDown2.Value);
            iceceksayac += artis_degeri2;

            if (comboBox2.Text == "Küçük")
            {
                fiyat += 10;
                if (comboBox3.Text == "İstemiyorum")
                {
                    fiyat -= 10;
                }
                else
                { // içecek boyutu belirleme
                    if (comboBox4.Text == "Küçük")
                    {
                        icecekucret = iceceksayac * 5;
                        fiyat = fiyat + icecekucret;
                    }
                    else if (comboBox4.Text == "Orta")
                    {
                        icecekucret = iceceksayac * 7;
                        fiyat = fiyat + icecekucret;
                    }
                    else if (comboBox4.Text == "Büyük")
                    {
                        icecekucret = iceceksayac * 10;
                        fiyat = fiyat + icecekucret;
                    }
                }
            }
            else if (comboBox2.Text == "Orta")
            {
                fiyat += 15;
                if (comboBox3.Text == "İstemiyorum") //içecek İstenmiyorsa ücretten azalt
                {
                    fiyat -= 10;

                }
                else
                {// içecek boyutu belirleme
                    if (comboBox4.Text == "Küçük")
                    {
                        icecekucret = iceceksayac * 5;
                        fiyat = fiyat + icecekucret;

                    }
                    else if (comboBox4.Text == "Orta")
                    {
                        icecekucret = iceceksayac * 7;
                        fiyat = fiyat + icecekucret;
                    }
                    else if (comboBox4.Text == "Büyük")
                    {
                        icecekucret = iceceksayac * 10;
                        fiyat = fiyat + icecekucret;
                    }
                }

            }
            else
            {
                fiyat += 20;
                if (comboBox3.Text == "İstemiyorum")
                {
                    fiyat -= 10;
                }
                else
                {// içecek boyutu belirleme
                    if (comboBox4.Text == "Küçük")
                    {
                        icecekucret = iceceksayac * 5;
                        fiyat = fiyat + icecekucret;
                    }
                    else if (comboBox4.Text == "Orta")
                    {
                        icecekucret = iceceksayac * 7;
                        fiyat = fiyat + icecekucret;
                    }
                    else if (comboBox4.Text == "Büyük")
                    {
                        icecekucret = iceceksayac * 10;
                        fiyat = fiyat + icecekucret;
                    }
                }

            }
            if (checkBox1.Checked == true)
            {
                fiyat += 5;
            }

            if (checkBox2.Checked == true)
            {
                fiyat += 3;
            }

            if (checkBox4.Checked == true)
            {
                fiyat += 5;
            }


            if (checkBox3.Checked == true)
            {
                fiyat += 3;
            }




            fiyat = fiyat * sayac;
            textBox7.Text = Convert.ToString(fiyat);
            fiyat = 30;
            icecekucret = 0;
            iceceksayac = 0;
            sayac = 0;
        }

        private void MusteriEkrani_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sipariş oluştur
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into pizza(pizza_ad,pizza_boyut,fiyat,pizza_adedi,ekstra) values(@a1,@a2,@a3,@a4,@a5)", baglanti);
            komut.Parameters.AddWithValue("@a1", comboBox1.Text);
            komut.Parameters.AddWithValue("@a2", comboBox2.Text);
            komut.Parameters.AddWithValue("@a3", textBox7.Text);
            komut.Parameters.AddWithValue("@a4", numericUpDown1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into icecek(İcecek_byt,İcecek_ad,icecek_adedi) values(@b1,@b2,@b3)", baglanti);
            komut2.Parameters.AddWithValue("@b1", comboBox3.Text);
            komut2.Parameters.AddWithValue("@b2", comboBox4.Text);
            komut2.Parameters.AddWithValue("@b3", numericUpDown2.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Siparişiniz alındı.");
        }

        private void TemizleButton_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //yedekleme ve inport export için 

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //import export bağlantısı buttonu 
            if (comboBox5.Text == "Yedekleme")
            {
                PizzaHome frm = new PizzaHome();
                frm.Show();
                this.Hide();
            }
            if (comboBox5.Text == "Export")
            {
                ExportFrom frm = new ExportFrom();
                frm.Show();
                this.Hide();
            }
            if (comboBox5.Text == "İmport ")
            {
                ImportForm frm = new ImportForm();
                frm.Show();
                this.Hide();
            }

        }

        private void RButton_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(pizzacesidi);
            comboBox3.Items.Add(icecekcesidi);

        }
    }
}
