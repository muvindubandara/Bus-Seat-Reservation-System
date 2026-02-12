using System.Data.SqlClient;

namespace Bus_Seat_Reservation_System   // <-- use your project namespace
{
    public static class UserStore
    {
        // Main login method (SQL)
        public static User FindUser(string phone, string password)
        {
            using (SqlConnection con = Db.GetConnection())
            {
                string sql =
                    "SELECT Id, FullName, PhoneNumber, [Password], IsAdmin " +
                    "FROM Users WHERE PhoneNumber = @phone AND [Password] = @pass";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@pass", password);

                    con.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            User u = new User();
                            u.Id = (int)r["Id"];
                            u.FullName = (string)r["FullName"];
                            u.PhoneNumber = (string)r["PhoneNumber"];
                            u.Password = (string)r["Password"];
                            u.IsAdmin = (bool)r["IsAdmin"];
                            return u;
                        }
                    }
                }
            }
            return null;
        }

        // ==== compatibility for old code ====
        // Now LoginForm can still call UserStore.FindByPhoneAndPassword(...)
        public static User FindByPhoneAndPassword(string phone, string password)
        {
            return FindUser(phone, password);
        }

        public static bool PhoneExists(string phone)
        {
            using (SqlConnection con = Db.GetConnection())
            {
                string sql = "SELECT COUNT(*) FROM Users WHERE PhoneNumber = @phone";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@phone", phone);
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static void AddCounterUser(string fullName, string phone, string password)
        {
            using (SqlConnection con = Db.GetConnection())
            {
                string sql =
                    "INSERT INTO Users (FullName, PhoneNumber, [Password], IsAdmin) " +
                    "VALUES (@name, @phone, @pass, 0)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@name", fullName);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@pass", password);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}