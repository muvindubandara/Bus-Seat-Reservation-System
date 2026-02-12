using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Seat_Reservation_System
{
    public class Trip
    {
        public int Id;
        public string BusNumber;
        public string From;
        public string To;
        public DateTime TravelDate;
        public string DepartureTime;
        public string BusClass;   // "AC" or "Non-AC"
        public decimal Fare;
        public int SeatCount;
    }
}
