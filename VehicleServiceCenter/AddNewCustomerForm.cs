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

namespace VehicleServiceCenter {
    public partial class AddNewCustomerForm : Form {

        int loggedId;
        public AddNewCustomerForm() {
            InitializeComponent();
        }

        public AddNewCustomerForm(int id) {
            this.loggedId = id;
            InitializeComponent();
        }

        private void AddNewCustomerForm_Load(object sender, EventArgs e) {

        }

        private void button_add_Click(object sender, EventArgs e) {
            string name = UserNameTxtBox.Text;
            string pass = PassTxtBox.Text;
            DateTime dob = dateTimePicker_dob.Value;
            string email = EmailTxtBox.Text;
            string phone = PhoneTxtBox.Text;


            string gender = "";

            if (MaleRadio.Checked) {
                gender = "Male";
            } else if (FemaleRadio.Checked) {
                gender = "Female";
            } else if (OtherRadio.Checked) {
                gender = "Other";
            }

            string blood = "";
            if (BloodGroupComboBox.SelectedItem != null) {
                blood = BloodGroupComboBox.SelectedItem.ToString();
            }

            if (string.IsNullOrWhiteSpace(name)) {
                MessageBox.Show("Please enter a username.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(email)) {
                MessageBox.Show("Please enter a email.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(pass)) {
                MessageBox.Show("Please enter a password.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dob.Date == DateTime.Now.Date) {
                MessageBox.Show("Please select your date of birth.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(phone)) {
                MessageBox.Show("Please enter a phone.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            Customer newCus = new Customer();
            newCus.Name = name;
            newCus.Gender = gender;
            newCus.Password = pass;
            newCus.DateOfBirth = dob;
            newCus.Email = email;
            newCus.BloodGroup = blood;
            newCus.PhoneNumber = phone;
            newCus.UserType = "Customer";

            CustomerRepository cr = new CustomerRepository();

            int status = cr.InsertCustomer(newCus);

            if (status == 0 || status == -1) {
                MessageBox.Show("Customer insertion failed. Please check your input and try again.",
                                "Insertion Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } else {
                MessageBox.Show("Customer has been added successfully.", "Success", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

            this.resetField();

        }

        private void button_back_Click(object sender, EventArgs e) {
            UserRepository ur = new UserRepository();

            User loggedUser = ur.GetUserById(loggedId);

            if (loggedUser.UserType.ToLower() == "admin") {
                this.Hide();
                AdminCustomerForm acf = new AdminCustomerForm(loggedUser.UserID);
                acf.Show();
            } else {


            }
        }

        private void button_refresh_Click(object sender, EventArgs e) {
            this.resetField();
        }

        private void resetField() {
            UserNameTxtBox.Text = "";
            PassTxtBox.Text = "";
            EmailTxtBox.Text = "";
            PhoneTxtBox.Text = "";
            dateTimePicker_dob.Value = DateTime.Now;
            BloodGroupComboBox.SelectedIndex = -1;
            MaleRadio.Checked = false;
            FemaleRadio.Checked = false;
            OtherRadio.Checked = false;
        }
    }
}
