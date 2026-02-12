using System.Collections.Generic;
using System.Data.SqlClient;

namespace Bus_Seat_Reservation_System   // use your project namespace
{
    public static class TerminalStore
    {
        // Get all terminals (for From / To combo boxes)
        public static List<Terminal> GetAllTerminals()
        {
            List<Terminal> list = new List<Terminal>();

            using (SqlConnection con = Db.GetConnection())
            {
                string sql = "SELECT Id, Name FROM Terminals ORDER BY Name";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            Terminal t = new Terminal();
                            t.Id = (int)r["Id"];
                            t.Name = (string)r["Name"];
                            list.Add(t);
                        }
                    }
                }
            }

            return list;
        }

        // ===== this is what AdminBusTerminalForm calls =====
        public static void AddTerminal(string name)
        {
            using (SqlConnection con = Db.GetConnection())
            {
                string sql = "INSERT INTO Terminals (Name) VALUES (@name)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}