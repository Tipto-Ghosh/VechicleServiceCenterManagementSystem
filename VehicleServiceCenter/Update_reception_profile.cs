using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleServiceCenter.Repositories;
using VehicleServiceCenter.Models;

namespace VehicleServiceCenter {
    public partial class Update_reception_profile : Form {

        private int loggedId;

        public Update_reception_profile(int id) {
            loggedId = id;
            InitializeComponent();
        }
        public Update_reception_profile() {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e) {

        }

        private void Update_reception_profile_Load(object sender, EventArgs e) {
            loadCustomerInfo();
        }

        private void loadCustomerInfo() {
            resetFields();


            UserRepository ur = new UserRepository();
            User user = ur.GetUserById(loggedId);

            textBox_UserID.Text = user.UserID.ToString();
            UserNameTxtBox.Text = user.Name;
            PassTxtBox.Text = user.Password;
            DOBPicker.Value = user.DateOfBirth;
            BloodGroupComboBox.SelectedItem = user.BloodGroup;
            EmailTxtBox.Text = user.Email;


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


            radioButton_male.Checked = false;
            radioButton_female.Checked = false;
            radioButton_Other.Checked = false;

            BloodGroupComboBox.SelectedIndex = -1;
            DOBPicker.Value = DateTime.Today;
        }

        private void SignBtn_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(UserNameTxtBox.Text) || string.IsNullOrWhiteSpace(PassTxtBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTxtBox.Text) || 
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
            updateCus.UserID = loggedId;
            updateCus.Name = UserNameTxtBox.Text.Trim();
            updateCus.Password = PassTxtBox.Text.Trim();
            updateCus.Email = EmailTxtBox.Text.Trim();
            updateCus.DateOfBirth = DOBPicker.Value;
            updateCus.BloodGroup = BloodGroupComboBox.SelectedItem.ToString();
            updateCus.Gender = radioButton_male.Checked ? "Male" :
                                radioButton_female.Checked ? "Female" : "Other";
            


            CustomerRepository cr = new CustomerRepository();
            int status = cr.UpdateCustomer(updateCus);

            if (status == 0 || status == -1) {
                MessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else {
                MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            loadCustomerInfo();
        }
    }
}
