using VehicleServiceCenter.Models;
using VehicleServiceCenter.Services;

namespace VehicleServiceCenter {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
            // Ensure password is hidden by default
            PassTxtBox.UseSystemPasswordChar = true;
            button_HideShow.Text = "Show";
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

                if (userType == "admin") {
                    AdminForm adminForm = new AdminForm(isUser.UserID);
                    adminForm.Show();
                } else if (userType == "customer") {
                    // Show customer form
                    Customer_HomeForm customerForm = new Customer_HomeForm(isUser.UserID);
                    this.Hide();
                    customerForm.Show();
                } else if (userType == "receptionist") {
                    // Show receptionist form
                } else {
                    // Show mechanic form
                }
            }
        }

        private void SignBtn_Click(object sender, EventArgs e) {
            this.Hide();
            LogIN signUpPage = new LogIN();
            signUpPage.Show();
        }

        private void PassLbl_Click(object sender, EventArgs e) {

        }

        private void button_HideShow_Click(object sender, EventArgs e) {
            if (PassTxtBox.UseSystemPasswordChar) {
                // Show password
                PassTxtBox.UseSystemPasswordChar = false;
                button_HideShow.Text = "Hide";
            } else {
                // Hide password
                PassTxtBox.UseSystemPasswordChar = true;
                button_HideShow.Text = "Show";
            }
        }
    }
}
