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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            {
                lblTitle.Text = "Register Counter User";
                txtPassword.UseSystemPasswordChar = true;
                txtConfirm.UseSystemPasswordChar = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;

            // ---- Basic checks ----
            if (fullName == "" || phone == "" || password == "" || confirm == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            // phone digits only
            for (int i = 0; i < phone.Length; i++)
            {
                if (!char.IsDigit(phone[i]))
                {
                    MessageBox.Show("Phone number must contain digits only.");
                    return;
                }
            }

            if (phone.Length != 10)  // adjust if your phone length is different
            {
                MessageBox.Show("Phone number must be 10 digits.");
                return;
            }

            if (UserStore.PhoneExists(phone))
            {
                MessageBox.Show("This phone number is already registered.");
                return;
            }

            // password rules (very simple)
            if (password.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters.");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (password == phone)
            {
                MessageBox.Show("Password cannot be same as phone number.");
                return;
            }

            // ---- Save user as COUNTER user ----
            UserStore.AddCounterUser(fullName, phone, password);

            MessageBox.Show("Registration successful!\n\nPhone: " + phone);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkShowPassword.Checked;
            txtPassword.UseSystemPasswordChar = !show;
            txtConfirm.UseSystemPasswordChar = !show;
        }
    }
}
