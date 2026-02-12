using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Bus_Seat_Reservation_System
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            // Default travel date = today
            dtpTravelDate.Value = DateTime.Today;

            // Fill From/To combo boxes from TripStore.Terminals
            cmbFrom.Items.Clear();
            cmbTo.Items.Clear();
            cmbFrom.Items.AddRange(TripStore.Terminals);
            cmbTo.Items.AddRange(TripStore.Terminals);

            if (cmbFrom.Items.Count > 0) cmbFrom.SelectedIndex = 0;
            if (cmbTo.Items.Count > 1) cmbTo.SelectedIndex = 1;

            // Default category
            rbAC.Checked = true;
        }

        private string GetSelectedClass()
        {
            if (rbAC.Checked) return "AC";
            if (rbNonAC.Checked) return "Non-AC";
            return "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string from = cmbFrom.Text.Trim();
            string to = cmbTo.Text.Trim();
            DateTime date = dtpTravelDate.Value.Date;
            string busClass = GetSelectedClass();  // "AC" or "Non-AC"

            if (from == "" || to == "" || busClass == "")
            {
                MessageBox.Show("Please select From, To and Category.");
                return;
            }

            dgvTrips.Rows.Clear();
            bool found = false;

            // Loop through all trips in TripStore
            for (int i = 0; i < TripStore.Trips.Count; i++)
            {
                Trip t = TripStore.Trips[i];

                if (t.From == from &&
                    t.To == to &&
                    t.TravelDate.Date == date &&
                    t.BusClass == busClass)
                {
                    dgvTrips.Rows.Add(
                        t.BusNumber,                          // colBusNumber
                        t.BusClass,                           // colBusClass
                        t.TravelDate.ToString("dd/MM/yyyy"),  // colTravelDate
                        t.From,                               // colFrom
                        t.To,                                 // colTo
                        t.DepartureTime,                      // colDeparture
                        t.Fare                                // colFare
                                                              // colBook uses its own "Book" text
                    );
                    found = true;
                }
            }

            if (!found)
            {
                MessageBox.Show("No trips found for your search.");
            }
        }

             // ---------- Handle Book button in each row ----------
        private void dgvTrips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header clicks
            if (e.RowIndex < 0)
                return;

            // Only react when Book column is clicked
            string columnName = dgvTrips.Columns[e.ColumnIndex].Name;
            if (columnName != "colBook")
                return;

            // 1. Read customer details
            string name = txtCustomerName.Text.Trim();
            string phone = txtCustomerPhone.Text.Trim();
            string cnic = txtCustomerCnic.Text.Trim();

            if (name == "" || phone == "" || cnic == "")
            {
                MessageBox.Show("Please enter Name, Phone No and CNIC.");
                return;
            }

            // simple phone number check: digits only
            for (int i = 0; i < phone.Length; i++)
            {
                if (!char.IsDigit(phone[i]))
                {
                    MessageBox.Show("Phone number must contain digits only.");
                    return;
                }
            }

            // 2. Get data from the clicked row
            DataGridViewRow row = dgvTrips.Rows[e.RowIndex];

            string busNumber = Convert.ToString(row.Cells["colBusNumber"].Value);
            string travelDateText = Convert.ToString(row.Cells["colTravelDate"].Value);

            // 3. Find the Trip object for this row
            Trip selectedTrip = null;
            for (int i = 0; i < TripStore.Trips.Count; i++)
            {
                Trip t = TripStore.Trips[i];
                if (t.BusNumber == busNumber &&
                    t.TravelDate.ToString("dd/MM/yyyy") == travelDateText)
                {
                    selectedTrip = t;
                    break;
                }
            }

            if (selectedTrip == null)
            {
                MessageBox.Show("Could not find selected trip.");
                return;
            }

            // 4. Open seat selection form for this trip
            SeatSelectionForm f = new SeatSelectionForm(selectedTrip, name, phone, cnic);
            f.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
