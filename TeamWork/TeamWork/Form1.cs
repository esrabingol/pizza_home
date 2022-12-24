using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TeamWork.Connection;

namespace TeamWork
{
    public partial class PizzaHome : Form
    {
        public PizzaHome()
        {
            InitializeComponent();
        }

        private void PizzaHome_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //veritanından hangi tablodan veri çekmek istiyorsanız o tabloyu yazacaksınız.
            SqlDataAdapter da = new SqlDataAdapter("Select * from Projects", TeamSqlConnection.Connect());
            da.Fill(dataTable: dt);
            dataGridView1.DataSource = dt;
            TeamSqlConnection.Connect().Close();
        }
    }
}
