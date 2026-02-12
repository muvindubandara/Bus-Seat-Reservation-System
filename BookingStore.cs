using System;
using System.Data.SqlClient;

namespace Bus_Seat_Reservation_System
{
    public static class BookingStore
    {
        public static Booking AddBooking(int tripId, int seatNumber,
                                         string name, string phone, string cnic)
        {
            Booking b = new Booking();
            b.TripId = tripId;
            b.SeatNumber = seatNumber;
            b.CustomerName = name;
            b.PhoneNo = phone;
            b.Cnic = cnic;

            using (SqlConnection con = Db.GetConnection())
            {
                string sql =
                    "INSERT INTO Bookings (TripId, SeatNumber, CustomerName, PhoneNo, Cnic) " +
                    "OUTPUT INSERTED.Id " +
                    "VALUES (@TripId, @SeatNumber, @CustomerName, @PhoneNo, @Cnic)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@TripId", tripId);
                    cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
                    cmd.Parameters.AddWithValue("@CustomerName", name);
                    cmd.Parameters.AddWithValue("@PhoneNo", phone);
                    cmd.Parameters.AddWithValue("@Cnic", cnic);

                    con.Open();
                    b.Id = (int)cmd.ExecuteScalar(); // get new Ticket ID, data saved in DB
                }
            }

            return b;
        }

        public static bool IsSeatBooked(int tripId, int seatNumber)
        {
            using (SqlConnection con = Db.GetConnection())
            {
                string sql = "SELECT COUNT(*) FROM Bookings WHERE TripId=@TripId AND SeatNumber=@Seat";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@TripId", tripId);
                    cmd.Parameters.AddWithValue("@Seat", seatNumber);
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static Booking GetBookingById(int id)
        {
            using (SqlConnection con = Db.GetConnection())
            {
                string sql =
                    "SELECT Id, TripId, SeatNumber, CustomerName, PhoneNo, Cnic " +
                    "FROM Bookings WHERE Id=@Id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            Booking b = new Booking();
                            b.Id = (int)r["Id"];
                            b.TripId = (int)r["TripId"];
                            b.SeatNumber = (int)r["SeatNumber"];
                            b.CustomerName = (string)r["CustomerName"];
                            b.PhoneNo = (string)r["PhoneNo"];
                            b.Cnic = (string)r["Cnic"];
                            return b;
                        }
                    }
                }
            }
            return null;
        }

        public static void RemoveBooking(int id)
        {
            using (SqlConnection con = Db.GetConnection())
            {
                string sql = "DELETE FROM Bookings WHERE Id=@Id";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    cmd.ExecuteNonQuery(); // row deleted from DB
                }
            }
        }
    }
}