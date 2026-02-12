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
    public partial class TicketSearchForm : Form
    {
        public TicketSearchForm()
        {
            InitializeComponent();
        }

        private void btnViewTicket_Click(object sender, EventArgs e)
        {
            if (lblInfo != null) lblInfo.Text = "";

            // 1. Read ticket ID from textbox
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
                MessageBox.Show("No ticket found with this ID.");
                if (lblInfo != null) lblInfo.Text = "No ticket found.";
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
                MessageBox.Show("Trip not found for this ticket.");
                if (lblInfo != null) lblInfo.Text = "Trip not found.";
                return;
            }

            // 4. Optional info on the form
            if (lblInfo != null)
            {
                lblInfo.Text =
                    "Ticket found:\n" +
                    "Name: " + b.CustomerName + "\n" +
                    "Route: " + t.From + " -> " + t.To + "\n" +
                    "Date: " + t.TravelDate.ToString("dd/MM/yyyy") + "\n" +
                    "Seat: " + b.SeatNumber;
            }

            // 5. Show the ticket in TicketForm (your simple report form)
            TicketForm tf = new TicketForm(b, t);
            tf.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
