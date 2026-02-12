using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Bus_Seat_Reservation_System
{
    public static class TripStore
    {
        // -------- Get all routes (for admin grid, etc.) --------
        public static List<Trip> GetAllTrips()
        {
            List<Trip> list = new List<Trip>();

            using (SqlConnection con = Db.GetConnection())
            {
                string sql =
                    "SELECT Id, BusNumber, FromTerminal, ToTerminal, TravelDate, " +
                    "       DepartureTime, BusClass, Fare, SeatCount " +
                    "FROM Trips ORDER BY TravelDate, DepartureTime";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            Trip t = new Trip();
                            t.Id = (int)r["Id"];
                            t.BusNumber = (string)r["BusNumber"];
                            t.From = (string)r["FromTerminal"];
                            t.To = (string)r["ToTerminal"];
                            t.TravelDate = (DateTime)r["TravelDate"];
                            t.DepartureTime = (string)r["DepartureTime"];
                            t.BusClass = (string)r["BusClass"];
                            t.Fare = (decimal)r["Fare"];
                            t.SeatCount = (int)r["SeatCount"];
                            list.Add(t);
                        }
                    }
                }
            }

            return list;
        }

        // (optional) Get one trip by id – useful for tickets etc.
        public static Trip GetTripById(int id)
        {
            using (SqlConnection con = Db.GetConnection())
            {
                string sql =
                    "SELECT Id, BusNumber, FromTerminal, ToTerminal, TravelDate, " +
                    "       DepartureTime, BusClass, Fare, SeatCount " +
                    "FROM Trips WHERE Id=@Id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            Trip t = new Trip();
                            t.Id = (int)r["Id"];
                            t.BusNumber = (string)r["BusNumber"];
                            t.From = (string)r["FromTerminal"];
                            t.To = (string)r["ToTerminal"];
                            t.TravelDate = (DateTime)r["TravelDate"];
                            t.DepartureTime = (string)r["DepartureTime"];
                            t.BusClass = (string)r["BusClass"];
                            t.Fare = (decimal)r["Fare"];
                            t.SeatCount = (int)r["SeatCount"];
                            return t;
                        }
                    }
                }
            }

            return null;
        }

        // -------- Add route --------
        public static void AddTrip(Trip t)
        {
            using (SqlConnection con = Db.GetConnection())
            {
                string sql =
                    "INSERT INTO Trips (BusNumber, FromTerminal, ToTerminal, TravelDate, " +
                    "                   DepartureTime, BusClass, Fare, SeatCount) " +
                    "VALUES (@BusNumber, @From, @To, @Date, @Time, @Class, @Fare, @Seats)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@BusNumber", t.BusNumber);
                    cmd.Parameters.AddWithValue("@From", t.From);
                    cmd.Parameters.AddWithValue("@To", t.To);
                    cmd.Parameters.AddWithValue("@Date", t.TravelDate.Date);
                    cmd.Parameters.AddWithValue("@Time", t.DepartureTime);
                    cmd.Parameters.AddWithValue("@Class", t.BusClass);
                    cmd.Parameters.AddWithValue("@Fare", t.Fare);
                    cmd.Parameters.AddWithValue("@Seats", t.SeatCount);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // -------- Update route --------
        public static void UpdateTrip(Trip t)
        {
            using (SqlConnection con = Db.GetConnection())
            {
                string sql =
                    "UPDATE Trips SET " +
                    "BusNumber=@BusNumber, FromTerminal=@From, ToTerminal=@To, " +
                    "TravelDate=@Date, DepartureTime=@Time, BusClass=@Class, " +
                    "Fare=@Fare, SeatCount=@Seats " +
                    "WHERE Id=@Id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@BusNumber", t.BusNumber);
                    cmd.Parameters.AddWithValue("@From", t.From);
                    cmd.Parameters.AddWithValue("@To", t.To);
                    cmd.Parameters.AddWithValue("@Date", t.TravelDate.Date);
                    cmd.Parameters.AddWithValue("@Time", t.DepartureTime);
                    cmd.Parameters.AddWithValue("@Class", t.BusClass);
                    cmd.Parameters.AddWithValue("@Fare", t.Fare);
                    cmd.Parameters.AddWithValue("@Seats", t.SeatCount);
                    cmd.Parameters.AddWithValue("@Id", t.Id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // -------- Delete route --------
        public static void DeleteTrip(int id)
        {
            using (SqlConnection con = Db.GetConnection())
            {
                con.Open();

                // Optional: use a transaction so both deletes succeed or fail together
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    // 1) Delete bookings for this trip
                    using (SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Bookings WHERE TripId = @TripId", con, tx))
                    {
                        cmd.Parameters.AddWithValue("@TripId", id);
                        cmd.ExecuteNonQuery();
                    }

                    // 2) Delete the trip itself
                    using (SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Trips WHERE Id = @Id", con, tx))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }

                    tx.Commit();
                }
                catch
                {
                    tx.Rollback();
                    throw; // re-throw so you can see error if something else goes wrong
                }
            }
        }
        

        // -------- Compatibility properties for old code --------

        // Old code using TripStore.Trips will now call GetAllTrips()
        public static List<Trip> Trips
        {
            get { return GetAllTrips(); }
        }

        // Old code using TripStore.Terminals will load names from Terminals table
        public static string[] Terminals
        {
            get
            {
                var terminalList = TerminalStore.GetAllTerminals();
                string[] arr = new string[terminalList.Count];

                for (int i = 0; i < terminalList.Count; i++)
                    arr[i] = terminalList[i].Name;

                return arr;
            }
        }
    }
}