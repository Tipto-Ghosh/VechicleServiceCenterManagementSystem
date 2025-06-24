using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleServiceCenter.Models;
using VehicleServiceCenter.Services;

namespace VehicleServiceCenter
{
    public partial class LogIN : Form {
        public LogIN() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void pictureBox2_Click(object sender, EventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {

        }

        private void pictureBox4_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void SignBtn_Click(object sender, EventArgs e) {
            // Take Val
            string userType = "customer";

            string username = UserNameTxtBox.Text.Trim();
            string password = PassTxtBox.Text.Trim();
            string email = EmailTxtBox.Text.Trim();
            string phone = PhoneTxtBox.Text.Trim();
            string bloodGroup = BloodGroupComboBox.SelectedItem != null ?
                BloodGroupComboBox.SelectedItem.ToString() : "Unknown";

            DateTime dob = DOBPicker.Value;

            // Validation checks
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone)) {
                MessageBox.Show("All fields must be filled.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!phone.All(char.IsDigit)) {
                MessageBox.Show("Phone number must contain digits only.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!email.Contains("@") || !email.Contains(".")) {
                MessageBox.Show("Invalid email format.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // make a object of customer
            Customer customer = new Customer();
            customer.Name = username;
            customer.PhoneNumber = phone;
            customer.Password = password;
            customer.Email = email;
            customer.BloodGroup = bloodGroup;
            customer.DateOfBirth = dob;
            customer.UserType = userType;

            // Now Add the Customer
            CustomerService customerService = new CustomerService();
            int id = customerService.SignUp(customer);

            if (id == 0 || id == -1) {
                MessageBox.Show("SignUp Failed.", "Insert Failed Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Sign up successfully! have a look on the UserId", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox_UserID.Text = id.ToString();
            customer.UserID = id;
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void LogBtn_Click(object sender, EventArgs e) {
            this.Hide();
            LoginForm l2 = new LoginForm();
            l2.Show();
        }
    }
}
