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
    public partial class AdminBusTerminalForm : Form
    {
        public AdminBusTerminalForm()
        {
            InitializeComponent();
        }

        private void AdminBusTerminalForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTerminal_Click(object sender, EventArgs e)
        {
            string city = txtTerminalCity.Text.Trim();

            if (city == "")
            {
                MessageBox.Show("Please enter a city / terminal name.");
                return;
            }

            try
            {
                TerminalStore.AddTerminal(city);
                MessageBox.Show("Terminal added: " + city);
                txtTerminalCity.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding terminal: " + ex.Message);
            }
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            string busNumber = txtBusNumber.Text.Trim();
            string busClass = txtBusClass.Text.Trim();
            string seatsText = txtBusSeats.Text.Trim();

            if (busNumber == "" || busClass == "" || seatsText == "")
            {
                MessageBox.Show("Please enter Bus Number, Class and Seats.");
                return;
            }

            int seats;
            if (!int.TryParse(seatsText, out seats) || seats <= 0)
            {
                MessageBox.Show("Seats must be a positive number.");
                return;
            }

            try
            {
                BusStore.AddBus(busNumber, busClass, seats);
                MessageBox.Show("Bus added: " + busNumber);
                txtBusNumber.Text = "";
                txtBusClass.Text = "";
                txtBusSeats.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding bus: " + ex.Message);
            }
        }
    }
}
