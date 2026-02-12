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

        public partial class LoginForm : Form
        {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private bool ValidateInput(out string phone, out string password)
        {
            phone = txtPhone.Text.Trim();
            password = txtPassword.Text;

            if (phone == "" || password == "")
            {
                MessageBox.Show("Please enter phone number and password.");
                return false;
            }

            // security: check phone has only digits and correct length
            for (int i = 0; i < phone.Length; i++)
            {
                if (!char.IsDigit(phone[i]))
                {
                    MessageBox.Show("Phone number must contain digits only.");
                    return false;
                }
            }

            if (phone.Length != 10) // change to your country length
            {
                MessageBox.Show("Phone number must be 10 digits.");
                return false;
            }

            return true;
        }

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            string phone, password;
            if (!ValidateInput(out phone, out password))
            {
                return;
            }

            User u = UserStore.FindByPhoneAndPassword(phone, password);

            if (u == null)
            {
                MessageBox.Show("Invalid phone number or password.");
                return;
            }

            if (u.IsAdmin)
            {
                MessageBox.Show("This is an admin account. Use 'Login as Admin' button.");
                return;
            }

            // successful user login
            MessageBox.Show("User login successful!");

            // Open Dashboard!
            // inside btnLoginUser_Click, after "User login successful!"
            DashboardForm f = new DashboardForm(u);  // u is the logged-in User
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            string phone, password;
            if (!ValidateInput(out phone, out password))
            {
                return;
            }

            User u = UserStore.FindByPhoneAndPassword(phone, password);

            if (u == null || !u.IsAdmin)
            {
                MessageBox.Show("Invalid admin phone or password.");
                return;
            }

            // successful admin login
            MessageBox.Show("Admin login successful!");

            
            AdminPanelForm f = new AdminPanelForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


 
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // open counter registration
            RegisterForm f = new RegisterForm();
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}