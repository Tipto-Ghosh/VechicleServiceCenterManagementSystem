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
using VehicleServiceCenter.Repositories;

namespace VehicleServiceCenter
{
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void pictureBox4_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void LogBtn_Click(object sender, EventArgs e) {
            string strUserId = this.UserIdTxtBox.Text;
            string pass = this.PassTxtBox.Text;

            if (string.IsNullOrEmpty(strUserId) || string.IsNullOrEmpty(pass)) {
                MessageBox.Show("Fill the UserId and Password", "Empty Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(strUserId, out int userId)) {
                MessageBox.Show("Invalid UserId. Must Be Integer", "Value Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check Validity
            UserService us = new UserService();
            User isUser = us.Login(userId, pass);

            if (isUser == null) {
                MessageBox.Show("Wrong UserID or Pass", "Not Exists",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Show success message
            DialogResult result = MessageBox.Show("Login Successful!", "Welcome",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK) {
                string userType = isUser.UserType.ToLower();

                this.Hide(); // Hide current login form

                if (userType == "ceo" || userType == "manager") {
                    // Show the Admin Home Page
                } else if (userType == "customer") {
                    // Show the customer Home Page
                } else if (userType == "receptionist") {
                    // Show the receptionist Home Page
                } else {
                    // Show the Mechanic Home Page
                }
            }
        }

        private void SignBtn_Click(object sender, EventArgs e) {
            this.Hide();
            SignUpCustomerForm signUpPage = new SignUpCustomerForm();
            signUpPage.Show();
        }

        private void PassLbl_Click(object sender, EventArgs e) {

        }

        private void button_HideShow_Click(object sender, EventArgs e) {
            
            if (PassTxtBox.UseSystemPasswordChar) {
                PassTxtBox.UseSystemPasswordChar = false; 
                button_HideShow.Text = "Show";
            } else {
                PassTxtBox.UseSystemPasswordChar = true; 
                button_HideShow.Text = "Hide";
            }
        }

    }
}
