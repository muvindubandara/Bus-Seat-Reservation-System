using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Bus_Seat_Reservation_System
{
    public partial class AdminPanelForm : Form
    {
        private int _editingBusId = 0;
        private int _editingRouteId = 0;

        public AdminPanelForm()
        {
            InitializeComponent();
        }

        
        private void AdminPanelForm_Load(object sender, EventArgs e)
        {


            dtpDate.Value = DateTime.Today;

           
            LoadBusesGrid();
            LoadTerminalsIntoCombos();   // fill From / To combos
            LoadRoutes();                // fill routes grid
        }

        // ================= LOAD HELPERS =================

        // ----- Load terminals into dgvTerminals -----
        

        // ----- Load buses into dgvBuses -----
        private void LoadBusesGrid()
        {
            dgvBuses.Rows.Clear();
            var buses = BusStore.GetAllBuses();

            foreach (var b in buses)
            {
                // columns: colBusId, colBusNumber, colBusClass, colBusSeats
                dgvBuses.Rows.Add(b.Id, b.BusNumber, b.BusClass, b.SeatCount);
            }
        }

        // ----- Fill From / To ComboBoxes from Terminals table -----
        private void LoadTerminalsIntoCombos()
        {
            var terminals = TerminalStore.GetAllTerminals();

            cmbFromTerminal.Items.Clear();
            cmbToTerminal.Items.Clear();

            foreach (var t in terminals)
            {
                cmbFromTerminal.Items.Add(t.Name);
                cmbToTerminal.Items.Add(t.Name);
            }

            if (cmbFromTerminal.Items.Count > 0) cmbFromTerminal.SelectedIndex = 0;
            if (cmbToTerminal.Items.Count > 0) cmbToTerminal.SelectedIndex = 0;
        }

        // ----- Load routes into dgvRoutes -----
        private void LoadRoutes()
        {
            dgvRoutes.Rows.Clear();
            List<Trip> trips = TripStore.GetAllTrips();

            foreach (Trip t in trips)
            {
                // IMPORTANT: store real DateTime in the cell
                dgvRoutes.Rows.Add(
                    t.Id,            // colId
                    t.BusNumber,     // colRouteBusNumber OR colBusNumber (see note below)
                    t.From,          // colFrom
                    t.To,            // colTo
                    t.TravelDate,    // colDate  (DateTime, not string)
                    t.DepartureTime, // colTime
                    t.Fare,          // colFare
                    t.SeatCount      // colSeats
                );
            }

            // Format the date column for display only
            if (dgvRoutes.Columns["colDate"] != null)
            {
                dgvRoutes.Columns["colDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        // --------- When a row is clicked, fill input controls ---------

        private void dgvRoutes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvRoutes.Rows[e.RowIndex];

            txtId.Text = Convert.ToString(row.Cells["colId"].Value);
            txtBusNumber.Text = Convert.ToString(row.Cells["colRouteBusNumber"].Value);
            cmbFromTerminal.Text = Convert.ToString(row.Cells["colFrom"].Value);
            cmbToTerminal.Text = Convert.ToString(row.Cells["colTo"].Value);

            if (row.Cells["colDate"].Value is DateTime d)
                dtpDate.Value = d;
            else
                dtpDate.Value = DateTime.Today;

            txtTime.Text = Convert.ToString(row.Cells["colTime"].Value);
            txtFare.Text = Convert.ToString(row.Cells["colFare"].Value);
            txtSeats.Text = Convert.ToString(row.Cells["colSeats"].Value);
        }
        // ================= ROUTE VALIDATION =================

        private bool ValidateInputs()
        {
            if (txtBusNumber.Text.Trim() == "" ||
                cmbFromTerminal.Text.Trim() == "" ||
                cmbToTerminal.Text.Trim() == "" ||
                txtTime.Text.Trim() == "" ||
                txtFare.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all required fields.");
                return false;
            }

            decimal fare;
            if (!decimal.TryParse(txtFare.Text.Trim(), out fare))
            {
                MessageBox.Show("Fare must be a number.");
                return false;
            }

            return true;
        }

        // ================= UPDATE ROUTE =================
        private void btnUpdateRoute_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {
                MessageBox.Show("Select a route to update.");
                return;
            }
            if (!ValidateInputs()) return;

            string busNumber = txtBusNumber.Text.Trim();
            BusInfo bus = BusStore.GetBusByNumber(busNumber);
            if (bus == null)
            {
                MessageBox.Show("Bus not found. Please add this bus first.");
                return;
            }

            Trip t = new Trip();
            t.Id = int.Parse(txtId.Text.Trim());
            t.BusNumber = bus.BusNumber;
            t.BusClass = bus.BusClass;
            t.SeatCount = bus.SeatCount;
            t.From = cmbFromTerminal.Text.Trim();
            t.To = cmbToTerminal.Text.Trim();
            t.TravelDate = dtpDate.Value.Date;
            t.DepartureTime = txtTime.Text.Trim();
            t.Fare = decimal.Parse(txtFare.Text.Trim());

            TripStore.UpdateTrip(t);

            txtSeats.Text = bus.SeatCount.ToString();

            MessageBox.Show("Route updated.");
            ClearInputs();
            LoadRoutes();
        }

       

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtId.Text = "";
            txtBusNumber.Text = "";
            txtTime.Text = "";
            txtFare.Text = "";
            txtSeats.Text = "";
            dtpDate.Value = DateTime.Today;

            if (cmbFromTerminal.Items.Count > 0) cmbFromTerminal.SelectedIndex = 0;
            if (cmbToTerminal.Items.Count > 0) cmbToTerminal.SelectedIndex = 0;
        }

        // ================= OPTIONAL: OPEN BUS/TERMINAL FORM =================
        // If you still have a separate AdminBusTerminalForm and want a button
        // to open it, you can use this handler:

        private void btnOpenBusTerminalForm_Click(object sender, EventArgs e)
        {
            using (var f = new AdminBusTerminalForm())
            {
                f.ShowDialog();
            }

            // Refresh after coming back
           
            LoadBusesGrid();
            LoadTerminalsIntoCombos();
        }
       

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            
        }

        // ================= DELETE ROUTE =================
        private void btnDeleteRoute_Click(object sender, EventArgs e)
        {
            string idText = txtId.Text.Trim();

            if (idText == "")
            {
                MessageBox.Show("Select a route to delete.");
                return;
            }

            int id;
            if (!int.TryParse(idText, out id))
            {
                MessageBox.Show("Internal route Id is invalid. Please click a row again.");
                return;
            }

            DialogResult r = MessageBox.Show(
                "Delete this route (and its bookings)?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.No) return;

            TripStore.DeleteTrip(id);   // numeric PK

            MessageBox.Show("Route deleted.");
            ClearInputs();
            LoadRoutes();
        }

        // ================= REFRESH BUTTON =================

        private void btnRefreshAll_Click(object sender, EventArgs e)
        {
          
            LoadBusesGrid();
            LoadTerminalsIntoCombos();
            LoadRoutes();
        }

        private void dgvBuses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;  // ignore header

            // Check if the clicked column is the Delete button
            string colName = dgvBuses.Columns[e.ColumnIndex].Name;
            if (colName != "colBusDelete")
                return;

            // Get Bus ID from the row
            object idVal = dgvBuses.Rows[e.RowIndex].Cells["colBusId"].Value;
            if (idVal == null)
            {
                MessageBox.Show("No Bus ID for this row.");
                return;
            }

            int id;
            if (!int.TryParse(idVal.ToString(), out id))
            {
                MessageBox.Show("Invalid Bus ID.");
                return;
            }

            // Confirm delete
            DialogResult r = MessageBox.Show(
                "Delete this bus?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.No) return;

            // Delete from database
            try
            {
                BusStore.DeleteBus(id);
                MessageBox.Show("Bus deleted.");

                // Refresh grid from DB (recommended)
                LoadBusesGrid();

                // Or remove just the row:
                // dgvBuses.Rows.RemoveAt(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting bus: " + ex.Message);
            }

        }

        private void dgvRoutes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvRoutes.Columns[e.ColumnIndex].Name;

            // ====== DELETE ROUTE ======
            if (colName == "colRouteDelete")
            {
                object idVal = dgvRoutes.Rows[e.RowIndex].Cells["colId"].Value;
                if (idVal == null)
                {
                    MessageBox.Show("No route Id found for this row.");
                    return;
                }

                int id;
                if (!int.TryParse(idVal.ToString(), out id))
                {
                    MessageBox.Show("Invalid route Id.");
                    return;
                }

                DialogResult r = MessageBox.Show(
                    "Delete this route (and its bookings)?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (r == DialogResult.No) return;

                TripStore.DeleteTrip(id);
                MessageBox.Show("Route deleted.");
                ClearInputs();
                LoadRoutes();
            }
            // ====== EDIT ROUTE ======
            else if (colName == "colRouteEdit")
            {
                DataGridViewRow row = dgvRoutes.Rows[e.RowIndex];

                txtId.Text = Convert.ToString(row.Cells["colId"].Value);
                txtBusNumber.Text = Convert.ToString(row.Cells["colRouteBusNumber"].Value);  // or "colBusNumber" if that's your name
                cmbFromTerminal.Text = Convert.ToString(row.Cells["colFrom"].Value);
                cmbToTerminal.Text = Convert.ToString(row.Cells["colTo"].Value);

                // -------- SAFE DATE HANDLING --------
                object dateVal = row.Cells["colDate"].Value;
                DateTime dt;

                if (dateVal is DateTime dtDate)               // case 1: real DateTime in the cell
                {
                    dt = dtDate;
                    dtpDate.Value = dt;
                }
                else if (dateVal != null &&
                         DateTime.TryParse(dateVal.ToString(),
                                           CultureInfo.CurrentCulture,
                                           DateTimeStyles.None,
                                           out dt))            // case 2: parsable with current culture
                {
                    dtpDate.Value = dt;
                }
                else if (dateVal != null &&
                         DateTime.TryParseExact(dateVal.ToString(),
                                                "dd/MM/yyyy",
                                                CultureInfo.InvariantCulture,
                                                DateTimeStyles.None,
                                                out dt))        // case 3: "dd/MM/yyyy" string
                {
                    dtpDate.Value = dt;
                }
                else
                {
                    // fallback if nothing worked – prevents crash
                    dtpDate.Value = DateTime.Today;
                }

                txtTime.Text = Convert.ToString(row.Cells["colTime"].Value);
                txtFare.Text = Convert.ToString(row.Cells["colFare"].Value);
                txtSeats.Text = Convert.ToString(row.Cells["colSeats"].Value);

                // optional: mark editing route id
                int id;
                if (int.TryParse(txtId.Text, out id))
                    _editingRouteId = id;
                else
                    _editingRouteId = 0;
            }
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            // Get bus by number to know its class and seats
            string busNumber = txtBusNumber.Text.Trim();
            BusInfo bus = BusStore.GetBusByNumber(busNumber);
            if (bus == null)
            {
                MessageBox.Show("Bus not found. Please add this bus first.");
                return;
            }

            Trip t = new Trip();
            t.BusNumber = bus.BusNumber;
            t.BusClass = bus.BusClass;         // from Buses table
            t.SeatCount = bus.SeatCount;        // from Buses table
            t.From = cmbFromTerminal.Text.Trim();
            t.To = cmbToTerminal.Text.Trim();
            t.TravelDate = dtpDate.Value.Date;
            t.DepartureTime = txtTime.Text.Trim();
            t.Fare = decimal.Parse(txtFare.Text.Trim());

            TripStore.AddTrip(t);                   // saved in Trips table

            // show seats from bus in the seats textbox (info only)
            txtSeats.Text = bus.SeatCount.ToString();

            MessageBox.Show("Route added.");
            ClearInputs();
            LoadRoutes();
        }

        private void btnAddTerminalsBuses_Click(object sender, EventArgs e)
        {
            using (var f = new AdminBusTerminalForm())
            {
                f.ShowDialog();
            }

            // After closing the child form, refresh terminals and buses on admin dashboard
           
            LoadBusesGrid();
            LoadTerminalsIntoCombos();
        }

        
    }

}
