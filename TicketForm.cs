using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Seat_Reservation_System
{
    public partial class TicketForm : Form
    {
        private Booking _booking;
        private Trip _trip;
        private PrintDocument _printDocument = new PrintDocument(); // for optional printing

        public TicketForm(Booking booking, Trip trip)
        {
            _booking = booking;
            _trip = trip;
            InitializeComponent();

            _printDocument.PrintPage += PrintDocument_PrintPage;
        }


        private void TicketForm_Load(object sender, EventArgs e)
        {
            lblTicketId.Text = _booking.Id.ToString();
            lblName.Text = _booking.CustomerName;
            lblPhone.Text = _booking.PhoneNo;
            lblCnic.Text = _booking.Cnic;

            lblFrom.Text = _trip.From;
            lblTo.Text = _trip.To;
            lblDate.Text = _trip.TravelDate.ToString("dd/MM/yyyy");
            lblTime.Text = _trip.DepartureTime;
            lblBusNo.Text = _trip.BusNumber;
            lblClass.Text = _trip.BusClass;
            lblSeat.Text = _booking.SeatNumber.ToString();
            lblFare.Text = _trip.Fare.ToString();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = _printDocument;
            preview.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float y = 50;
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font font = new Font("Arial", 12);

            e.Graphics.DrawString("Bus Ticket", titleFont, Brushes.Black, 50, y);
            y += 40;

            e.Graphics.DrawString("Ticket ID: " + lblTicketId.Text, font, Brushes.Black, 50, y); y += 20;
            e.Graphics.DrawString("Name: " + lblName.Text, font, Brushes.Black, 50, y); y += 20;
            e.Graphics.DrawString("Phone: " + lblPhone.Text, font, Brushes.Black, 50, y); y += 20;
            e.Graphics.DrawString("CNIC: " + lblCnic.Text, font, Brushes.Black, 50, y); y += 20;

            e.Graphics.DrawString("From: " + lblFrom.Text + "   To: " + lblTo.Text, font, Brushes.Black, 50, y); y += 20;
            e.Graphics.DrawString("Date: " + lblDate.Text + "   Time: " + lblTime.Text, font, Brushes.Black, 50, y); y += 20;

            e.Graphics.DrawString("Bus No: " + lblBusNo.Text + "   Class: " + lblClass.Text, font, Brushes.Black, 50, y); y += 20;
            e.Graphics.DrawString("Seat: " + lblSeat.Text + "   Fare: " + lblFare.Text, font, Brushes.Black, 50, y);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

