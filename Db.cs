using System.Configuration;
using System.Data.SqlClient;

namespace Bus_Seat_Reservation_System  // make sure this matches your project namespace
{
    public static class Db
    {
        private static readonly string ConnString =
            ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnString);
        }
    }
}