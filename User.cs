using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Seat_Reservation_System
{
    public class User
    {
        public int Id;
        public string FullName;     // person's name
        public string PhoneNumber;  // for login
        public string Password;
        public bool IsAdmin;        // true = admin, false = counter user
    }
}