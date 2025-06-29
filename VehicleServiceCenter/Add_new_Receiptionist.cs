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
    public partial class Add_new_Receiptionist : Form {

        private int loggedAdminId;

        public Add_new_Receiptionist(int id) {
            this.loggedAdminId = id;
            InitializeComponent();
        }
        public Add_new_Receiptionist() {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e) {

        }

        private void InsertButton_Click(object sender, EventArgs e) {
            string name = UserNameTxtBox.Text.Trim();
            string password = PassTxtBox.Text.Trim();
            string email = EmailTxtBox.Text.Trim();
            string bloodGroup = BloodGroupComboBox.Text.Trim();


            string gender = "";
            if (radioButton_male.Checked) {
                gender = "Male";
            } else if (radioButton_female.Checked) {
                gender = "Female";
            } else if (radioButton_other.Checked) {
                gender = "Other";
            }

            string shiftTime = "";
            if (radioButton_morning.Checked) {
                shiftTime = "Morning";
            } else if (radioButton_noon.Checked) {
                shiftTime = "Noon";
            } else if (radioButton_night.Checked) {
                shiftTime = "Night";
            }

            DateTime dob = DOBPicker.Value;
            string userType = "Receptionist";

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(bloodGroup) ||
                string.IsNullOrWhiteSpace(gender) || string.IsNullOrWhiteSpace(shiftTime)) {
                MessageBox.Show("Please fill in all fields and select gender & shift time.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Receptionist newRecep = new Receptionist();
            newRecep.Name = name;
            newRecep.Gender = gender;
            newRecep.Password = password;
            newRecep.DateOfBirth = dob;
            newRecep.BloodGroup = bloodGroup;
            newRecep.Email = email;
            newRecep.UserType = userType;

            ReceptionistRepository rr = new ReceptionistRepository();
            int status = rr.InsertReceptionist(newRecep);

            if (status == 0 || status == -1) {
                // Failed
                MessageBox.Show("Insert failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                // success
                MessageBox.Show("Insert successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFields();
            }
        }

        private void ResetFields() {
            UserNameTxtBox.Text = "";
            PassTxtBox.Text = "";
            EmailTxtBox.Text = "";
            BloodGroupComboBox.SelectedIndex = -1;
            DOBPicker.Value = DateTime.Today;

            radioButton_male.Checked = false;
            radioButton_female.Checked = false;
            radioButton_other.Checked = false;

            radioButton_morning.Checked = false;
            radioButton_noon.Checked = false;
            radioButton_night.Checked = false;

            textBox_UserID.Text = "System Auto Generated";
        }

        private void reset_button_Click(object sender, EventArgs e) {
            ResetFields();
        }

        private void back_button_Click(object sender, EventArgs e) {
            //
            Admin_ReceptionistForm arf = new Admin_ReceptionistForm(loggedAdminId);
            this.Hide();
            arf.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void Add_new_Receiptionist_Load(object sender, EventArgs e) {

        }
    }
}
