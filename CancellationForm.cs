using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Seat_Reservation_System
{
    public partial class CancellationForm : Form
    {
        private Booking _currentBooking;
        private Trip _currentTrip;

        public CancellationForm()
        {
            InitializeComponent();
        }

        private void CancellationForm_Load(object sender, EventArgs e)
        {
            dtpTravelDate.Value = DateTime.Today;
            ClearDetails();
        }

        private void ClearDetails()
        {
            _currentBooking = null;
            _currentTrip = null;

            lblShowTicketId.Text = "";
            lblShowStatus.Text = "";
            lblShowName.Text = "";
            lblShowCnic.Text = "";
            lblShowPhone.Text = "";
            lblShowSeats.Text = "";
            lblShowFrom.Text = "";
            lblShowTo.Text = "";
            lblShowTravelDate.Text = "";
            lblShowFare.Text = "";

            btnCancelTicket.Enabled = false;
        }

        
        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            if (_currentBooking == null)
            {
                MessageBox.Show("No booking selected.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel this ticket?",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            // Remove booking from store – seat becomes free
            BookingStore.RemoveBooking(_currentBooking.Id);

            lblShowStatus.Text = "Cancelled";
            btnCancelTicket.Enabled = false;

            MessageBox.Show("Ticket has been cancelled.");
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            ClearDetails();

            // 1. Read Ticket ID
            string idText = txtTicketId.Text.Trim();
            if (idText == "")
            {
                MessageBox.Show("Please enter Ticket ID.");
                return;
            }

            int ticketId;
            if (!int.TryParse(idText, out ticketId))
            {
                MessageBox.Show("Ticket ID must be a number.");
                return;
            }

            // 2. Find booking by ID
            Booking b = BookingStore.GetBookingById(ticketId);
            if (b == null)
            {
                MessageBox.Show("No booking found with this Ticket ID.");
                return;
            }

            // 3. Find trip for this booking
            Trip t = null;
            for (int i = 0; i < TripStore.Trips.Count; i++)
            {
                if (TripStore.Trips[i].Id == b.TripId)
                {
                    t = TripStore.Trips[i];
                    break;
                }
            }

            if (t == null)
            {
                MessageBox.Show("Trip for this booking was not found.");
                return;
            }

            // 4. Check travel date matches (optional but like your UI)
            DateTime selectedDate = dtpTravelDate.Value.Date;
            if (t.TravelDate.Date != selectedDate)
            {
                MessageBox.Show("No booking found for this Ticket ID on the selected date.");
                return;
            }

            // 5. Show details
            _currentBooking = b;
            _currentTrip = t;

            lblShowTicketId.Text = b.Id.ToString();
            lblShowStatus.Text = "Active";   // not cancelled yet
            lblShowName.Text = b.CustomerName;
            lblShowCnic.Text = b.Cnic;
            lblShowPhone.Text = b.PhoneNo;
            lblShowSeats.Text = b.SeatNumber.ToString();
            lblShowFrom.Text = t.From;
            lblShowTo.Text = t.To;
            lblShowTravelDate.Text = t.TravelDate.ToString("dd/MM/yyyy");
            lblShowFare.Text = t.Fare.ToString();

            btnCancelTicket.Enabled = true;
        }

        private void lblCancellation_Click(object sender, EventArgs e)
        {

        }
    }
    
}

