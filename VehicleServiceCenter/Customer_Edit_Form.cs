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
using VehicleServiceCenter.Repositories;

namespace VehicleServiceCenter
{
    public partial class Customer_Edit_Form : Form {
        private int loggedCusId;
        public Customer_Edit_Form(int id) {
            this.loggedCusId = id;
            InitializeComponent();
            //iconButton3.BackColor = Color.FromArgb(136, 136, 136);
        }

        public Customer_Edit_Form() {
            InitializeComponent();
            //iconButton3.BackColor = Color.FromArgb(136, 136, 136);
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void iconButton3_Click(object sender, EventArgs e) {

        }

        private void iconButton1_Click(object sender, EventArgs e) {
            Customer_HomeForm c1 = new Customer_HomeForm();
            c1.Show();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e) {
            ShopForm s1 = new ShopForm();
            s1._previousForm = this;
            s1.Show();
            this.Hide();
        }

        private void Customer_Edit_Form_Load(object sender, EventArgs e) {

            loadCustomerInfo();

        }

        private void loadCustomerInfo() {
            resetFields();

            CustomerRepository cr = new CustomerRepository();
            string phoneNum = cr.GetCustomerPhoneByID(loggedCusId);

            UserRepository ur = new UserRepository();
            User user = ur.GetUserById(loggedCusId);

            textBox_UserID.Text = user.UserID.ToString();
            UserNameTxtBox.Text = user.Name;
            PassTxtBox.Text = user.Password;
            DOBPicker.Value = user.DateOfBirth;
            BloodGroupComboBox.SelectedItem = user.BloodGroup;
            EmailTxtBox.Text = user.Email;
            PhoneTxtBox.Text = phoneNum;

            string gender = user.Gender.ToLower();
            if (gender == "male") {
                radioButton_male.Checked = true;
            } else if (gender == "female") {
                radioButton_female.Checked = true;
            } else if (gender == "other") {
                radioButton_Other.Checked = true;
            }
        }

        private void resetFields() {
            textBox_UserID.Clear();
            UserNameTxtBox.Clear();
            PassTxtBox.Clear();
            EmailTxtBox.Clear();
            PhoneTxtBox.Clear();

            radioButton_male.Checked = false;
            radioButton_female.Checked = false;
            radioButton_Other.Checked = false;

            BloodGroupComboBox.SelectedIndex = -1;
            DOBPicker.Value = DateTime.Today;
        }

        private void SignBtn_Click(object sender, EventArgs e) {
            // update button 

            if (string.IsNullOrWhiteSpace(UserNameTxtBox.Text) || string.IsNullOrWhiteSpace(PassTxtBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTxtBox.Text) || string.IsNullOrWhiteSpace(PhoneTxtBox.Text) ||
                (!radioButton_male.Checked && !radioButton_female.Checked && !radioButton_Other.Checked) ||
                BloodGroupComboBox.SelectedIndex == -1) {
                MessageBox.Show("Please fill in all fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult result = MessageBox.Show("Are you sure you want to update your information?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) {
                loadCustomerInfo();
                return;
            }

            Customer updateCus = new Customer();
            updateCus.UserID = loggedCusId;
            updateCus.Name = UserNameTxtBox.Text.Trim();
            updateCus.Password = PassTxtBox.Text.Trim();
            updateCus.Email = EmailTxtBox.Text.Trim();
            updateCus.DateOfBirth = DOBPicker.Value;
            updateCus.BloodGroup = BloodGroupComboBox.SelectedItem.ToString();
            updateCus.Gender = radioButton_male.Checked ? "Male" :
                                radioButton_female.Checked ? "Female" : "Other";
            updateCus.PhoneNumber = PhoneTxtBox.Text.Trim();


            CustomerRepository cr = new CustomerRepository();
            int status = cr.UpdateCustomer(updateCus);

            if (status == 0 || status == -1) {
                MessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else {
                MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            loadCustomerInfo();
        }

        private void LogBtn_Click(object sender, EventArgs e) {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete your account?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );


            if (confirm == DialogResult.No) {
                return;
            }


            // if yess

            CustomerRepository cr = new CustomerRepository();
            int status = cr.DeleteCustomer(loggedCusId);

            if (status == 1) {
                MessageBox.Show("Account deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoginForm lf = new LoginForm();
                this.Hide();
                lf.Show();
            } else {
                MessageBox.Show("Failed to delete account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadCustomerInfo();
            }
        }

        private void button_home_Click(object sender, EventArgs e) {
            Customer_HomeForm ch = new Customer_HomeForm(loggedCusId);
            this.Hide();
            ch.Show();
        }
    }
}
