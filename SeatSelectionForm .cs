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
    public partial class SeatSelectionForm : Form
    {
        private Trip _trip;
        private string _customerName;
        private string _phone;
        private string _cnic;

        private List<int> _selectedSeatNumbers = new List<int>();

        // default constructor (for designer)
        public SeatSelectionForm()
        {
            InitializeComponent();
        }

        // constructor used from BookingForm
        public SeatSelectionForm(Trip trip, string customerName, string phone, string cnic)
            : this()
        {
            _trip = trip;
            _customerName = customerName;
            _phone = phone;
            _cnic = cnic;
        }

        private void SeatSelectionForm_Load(object sender, EventArgs e)
        {
            lblFormTitle.Text = "Select Seats";

            lblName.Text = "Name: " + _customerName;
            lblPhone.Text = "Phone No: " + _phone;
            lblCnic.Text = "CNIC: " + _cnic;

            GenerateSeatButtons();
        }

        private void GenerateSeatButtons()
        {
            pnlSeats.Controls.Clear();
            _selectedSeatNumbers.Clear();
            dgvSelectedSeats.Rows.Clear();

            int seatCount = _trip.SeatCount;   // e.g. 24
            int buttonSize = 40;
            int gap = 5;           // space between seats
            int aisleWidth = 25;   // space in the middle (aisle)
            int seatsPerRow = 4;   // 2 left + 2 right

            for (int index = 0; index < seatCount; index++)
            {
                int seatNumber = index + 1;

                int row = index / seatsPerRow;      // 0,1,2,...
                int posInRow = index % seatsPerRow; // 0..3

                int x;
                if (posInRow < 2)
                {
                    // left side
                    x = posInRow * (buttonSize + gap);
                }
                else
                {
                    // right side, add aisle space
                    x = posInRow * (buttonSize + gap) + aisleWidth;
                }

                int y = row * (buttonSize + gap);

                Button btn = new Button();
                btn.Width = buttonSize;
                btn.Height = buttonSize;
                btn.Left = x;
                btn.Top = y;
                btn.Text = seatNumber.ToString();
                btn.Tag = seatNumber;

                if (BookingStore.IsSeatBooked(_trip.Id, seatNumber))
                {
                    // already booked: red and disabled
                    btn.BackColor = Color.Red;
                    btn.ForeColor = Color.White;
                    btn.Enabled = false;
                }
                else
                {
                    // available: green + click handler
                    btn.BackColor = Color.LightGreen;
                    btn.Click += SeatButton_Click;
                }

                pnlSeats.Controls.Add(btn);
            }
        }
        
        // Runs when any seat button is clicked
        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int seatNumber = (int)btn.Tag;

            // If already selected → unselect
            if (_selectedSeatNumbers.Contains(seatNumber))
            {
                _selectedSeatNumbers.Remove(seatNumber);
                btn.BackColor = Color.LightGreen;

                // remove from table
                foreach (DataGridViewRow row in dgvSelectedSeats.Rows)
                {
                    if (row.Cells["colSeatNumber"].Value != null &&
                        Convert.ToInt32(row.Cells["colSeatNumber"].Value) == seatNumber)
                    {
                        dgvSelectedSeats.Rows.Remove(row);
                        break;
                    }
                }
            }
            else
            {
                // select new seat
                _selectedSeatNumbers.Add(seatNumber);
                btn.BackColor = Color.Yellow;

                // add a row and set the Seat Number cell
                int rowIndex = dgvSelectedSeats.Rows.Add();
                dgvSelectedSeats.Rows[rowIndex].Cells["colSeatNumber"].Value = seatNumber;
            }
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_selectedSeatNumbers.Count == 0)
            {
                MessageBox.Show("Please select at least one seat.");
                return;
            }

            // Simple: use first selected seat for the ticket
            int seatNo = _selectedSeatNumbers[0];

            Booking booking = BookingStore.AddBooking(
                _trip.Id,
                seatNo,
                _customerName,
                _phone,
                _cnic
            );

            MessageBox.Show("Seat booked successfully! Ticket ID: " + booking.Id);

            TicketForm tf = new TicketForm(booking, _trip);
            tf.ShowDialog();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}


