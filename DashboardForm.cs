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
    public partial class DashboardForm : Form
    {
        private User _currentUser;
        public DashboardForm(User user)
        {
            _currentUser = user;
            InitializeComponent();
        }
        private void ShowHomePanel()
        {
            panelHome.Visible = true;
            panelHome.BringToFront();
        }
        private void LoadAllRoutes()
        {
            dgvTrips.Rows.Clear();

            var trips = TripStore.GetAllTrips();   // reads all routes from Trips table

            foreach (Trip t in trips)
            {
                dgvTrips.Rows.Add(
                    t.BusNumber,                          // Bus_Number column
                    t.BusClass,                           // Class
                    t.TravelDate.ToString("dd/MM/yyyy"),  // Date
                    t.From,                               // From
                    t.To,                                 // To
                    t.DepartureTime,                      // Time
                    t.Fare                                 // Fare
                );
            }
        }

        private void LoadAllTrips()
        {
            dgvTrips.Rows.Clear();

            var trips = TripStore.GetAllTrips();   // reads all rows from Trips table

            foreach (Trip t in trips)
            {
                dgvTrips.Rows.Add(
                    t.BusNumber,                          // Bus Number
                    t.BusClass,                           // Class
                    t.TravelDate.ToString("dd/MM/yyyy"),  // Date
                    t.From,                               // From
                    t.To,                                 // To
                    t.DepartureTime,                      // Time
                    t.Fare                                // Fare
                );
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // top labels
            lblDashboardTitle.Text = "DASHBOARD";
            lblWelcome.Text = "Welcome To Bus Reservation System";
            if (_currentUser != null)
            {
                lblLoggedIn.Text = "Logged in as: " + _currentUser.PhoneNumber;
            }

            // travel date default today
            dtpTravelDate.Value = DateTime.Today;

            // fill From / To terminals
            cmbFrom.Items.Clear();
            cmbTo.Items.Clear();
            cmbFrom.Items.AddRange(TripStore.Terminals);
            cmbTo.Items.AddRange(TripStore.Terminals);

            if (cmbFrom.Items.Count > 0)
                cmbFrom.SelectedIndex = 0;
            if (cmbTo.Items.Count > 1)
                cmbTo.SelectedIndex = 1;

            // default category
            rbAC.Checked = true;

            ShowHomePanel();

            // existing code: welcome label, dtpTravelDate.Value, fill cmbFrom/cmbTo from terminals, etc.

            // e.g.
            // var terms = TerminalStore.GetAllTerminals();
            // cmbFrom.Items.Clear(); cmbTo.Items.Clear();
            // foreach (var term in terms) { cmbFrom.Items.Add(term.Name); cmbTo.Items.Add(term.Name); }

            LoadAllRoutes();  // show all routes when dashboard opens
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
            string busClass = GetSelectedClass();  // or "" if you don’t filter by class

            dgvTrips.Rows.Clear();

            List<Trip> trips = TripStore.GetAllTrips();
            bool found = false;

            foreach (Trip t in trips)
            {
                bool match = true;

                // filter by From
                if (from != "" && t.From != from)
                    match = false;

                // filter by To
                if (to != "" && t.To != to)
                    match = false;

                // filter by Date
                if (t.TravelDate.Date != date)
                    match = false;

                // filter by Class (only if you want)
                if (busClass != "" && t.BusClass != busClass)
                    match = false;

                if (match)
                {
                    dgvTrips.Rows.Add(
                        t.BusNumber,
                        t.BusClass,
                        t.TravelDate.ToString("dd/MM/yyyy"),
                        t.From,
                        t.To,
                        t.DepartureTime,
                        t.Fare
                    );
                    found = true;
                }
            }

            if (!found)
            {
                MessageBox.Show("No routes found for your search.");
            }
        }

        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close(); // go back to LoginForm
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowHomePanel();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            // open booking form
            BookingForm f = new BookingForm();
            f.Show();       // shows booking form as a new window

           
        }

        private void btnCancellation_Click(object sender, EventArgs e)
        {
            CancellationForm f = new CancellationForm();
            f.Show();      
        }

        private void btnTicketSearch_Click(object sender, EventArgs e)
        {
            TicketSearchForm f = new TicketSearchForm();
            f.ShowDialog();
        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadAllTrips();
        }
    }
}

