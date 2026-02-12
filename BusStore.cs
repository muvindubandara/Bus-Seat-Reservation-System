using System.Collections.Generic;
using System.Data.SqlClient;

namespace Bus_Seat_Reservation_System
{
    public static class BusStore
    {
        // For route form and other lists
        public static List<BusInfo> GetAllBuses()
        {
            List<BusInfo> list = new List<BusInfo>();

            using (SqlConnection con = Db.GetConnection())
            {
                string sql = "SELECT Id, BusNumber, BusClass, SeatCount FROM Buses ORDER BY BusNumber";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            BusInfo b = new BusInfo();
                            b.Id = (int)r["Id"];
                            b.BusNumber = (string)r["BusNumber"];
                            b.BusClass = (string)r["BusClass"];
                            b.SeatCount = (int)r["SeatCount"];
                            list.Add(b);
                        }
                    }
                }
            }

            return list;
        }

        // Used by AdminRouteForm to get class & seats from bus number
        public static BusInfo GetBusByNumber(string busNumber)
        {
            using (SqlConnection con = Db.GetConnection())
            {
                string sql = "SELECT Id, BusNumber, BusClass, SeatCount FROM Buses WHERE BusNumber = @num";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@num", busNumber);
                    con.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            BusInfo b = new BusInfo();
                            b.Id = (int)r["Id"];
                            b.BusNumber = (string)r["BusNumber"];
                            b.BusClass = (string)r["BusClass"];
                            b.SeatCount = (int)r["SeatCount"];
                            return b;
                        }
                    }
                }
            }

            return null;
        }

        // ===== this is what AdminBusTerminalForm calls =====
        public static void AddBus(string busNumber, string busClass, int seatCount)
        {
            using (SqlConnection con = Db.GetConnection())
            {
                string sql =
                    "INSERT INTO Buses (BusNumber, BusClass, SeatCount) " +
                    "VALUES (@num, @class, @seats)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@num", busNumber);
                    cmd.Parameters.AddWithValue("@class", busClass);
                    cmd.Parameters.AddWithValue("@seats", seatCount);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static BusInfo GetBusById(int id)
        {
            using (SqlConnection con = Db.GetConnection())
            {
                string sql = "SELECT Id, BusNumber, BusClass, SeatCount FROM Buses WHERE Id = @id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            BusInfo b = new BusInfo();
                            b.Id = (int)r["Id"];
                            b.BusNumber = (string)r["BusNumber"];
                            b.BusClass = (string)r["BusClass"];
                            b.SeatCount = (int)r["SeatCount"];
                            return b;
                        }
                    }
                }
            }
            return null;
        }

        public static void DeleteBus(int id)
        {
            using (SqlConnection con = Db.GetConnection())
            {
                string sql = "DELETE FROM Buses WHERE Id = @id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}