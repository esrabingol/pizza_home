using System.Data.SqlClient;

namespace TeamWork.Connection
{
    public static class TeamSqlConnection
    {
        public static SqlConnection Connect()
        {
            //DataSource yerine kendi veri tabanı adınızı 
            //Initial Catalog yerine baglanmak istediğiniz veri tabanı adını gireceksiniz

            string connectionString = @"Data Source=DESKTOP-KB74JGP\SQLEXPRESS;Initial Catalog=Deneme;Integrated Security=True";

            SqlConnection baglan = new SqlConnection(connectionString);
            baglan.Open();
            return baglan;
        }
    }
}
