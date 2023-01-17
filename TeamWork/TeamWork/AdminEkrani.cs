using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamWork
{
    public partial class AdminEkrani : Form
    {
        
        public AdminEkrani()
        {
            InitializeComponent();
        }


        private void AdminEkrani_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ekle button 
            string pcesid;
            string icesid;
            pcesid = EklenenCtB.Text;
            icesid = icecekCTB.Text;

            MusteriEkrani frm = new MusteriEkrani();
            frm.pizzacesidi = pcesid;
            frm.icecekcesidi = icesid;
            frm.Show();



        }

        private void icecekCTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            GirisYap frm = new GirisYap();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MusteriEkrani frm = new MusteriEkrani();
            frm.Show();
            this.Hide();
        }
    }
}
