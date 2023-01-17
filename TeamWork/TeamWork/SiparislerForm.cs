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
    public partial class SiparislerForm : Form
    {
        TeamSqlConnection connect;

        public SiparislerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect = new TeamSqlConnection("WorkTeam");
            DataTable dt = new DataTable();
            //veritanından hangi tablodan veri çekmek istenirse o tabloyu yazacaksınız.
            SqlDataAdapter da = new SqlDataAdapter("Select * from siparis", connect.Connect());
            da.Fill(dataTable: dt);
            siparisDGW.DataSource = dt;
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Istek_pizza", connect.Connect());
            da1.Fill(dataTable: dt1);
            istekPizzaDGW.DataSource = dt1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirisYap frm = new GirisYap();
            frm.Show();
            this.Hide();
        }
    }
}
