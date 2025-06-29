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
    public partial class Admin_Profile_Edit : Form {

        private int loggedAdminId;
        public Admin_Profile_Edit() {
            InitializeComponent();
        }

        public Admin_Profile_Edit(int loggedAdminId) {
            InitializeComponent();
            this.loggedAdminId = loggedAdminId;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void signOutPictureBox_Click(object sender, EventArgs e) {

        }

        private void iconButton1_Click(object sender, EventArgs e) {
            AdminForm a1 = new AdminForm(this.loggedAdminId);
            a1.Show();
            this.Hide();
        }

        private void Admin_Profile_Edit_Load(object sender, EventArgs e) {
            this.LoadUser();
        }

        private void LoadUser() {
            UserRepository ur = new UserRepository();
            User loggedUser = ur.GetUserById(loggedAdminId);

            textBox_UserID.Text = loggedUser.UserID.ToString();
            textBox_name.Text = loggedUser.Name;
            textBox_pass.Text = loggedUser.Password;
            textBox_email.Text = loggedUser.Email;
            DOBPicker.Value = loggedUser.DateOfBirth;

            string gender = loggedUser.Gender.ToLower();
            radioButton_male.Checked = gender == "male";
            radioButton_famale.Checked = gender == "female";
            radioButton_Other.Checked = gender == "other";


            if (!string.IsNullOrEmpty(loggedUser.BloodGroup) &&
                BloodGroupComboBox.Items.Contains(loggedUser.BloodGroup)) 
            {
                BloodGroupComboBox.SelectedItem = loggedUser.BloodGroup;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e) {
            this.LoadUser();
        }

        private void button_update_Click(object sender, EventArgs e) {
            // receive all the info
            string name = textBox_name.Text.Trim();
            string password = textBox_pass.Text.Trim();
            string email = textBox_email.Text.Trim();

            string gender = "";
            if (radioButton_male.Checked) {
                gender = "Male";
            } else if (radioButton_famale.Checked) {
                gender = "Female";
            } else if(radioButton_Other.Checked) {
                gender = "Other";
            } else {
                MessageBox.Show("Please fill the gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime dob = DOBPicker.Value;
            string bloodGroup = BloodGroupComboBox.SelectedItem != null ? BloodGroupComboBox.SelectedItem.ToString() : "";

            
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) ||
             string.IsNullOrEmpty(email) || string.IsNullOrEmpty(gender) ||
             string.IsNullOrEmpty(bloodGroup)) 
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // show confirm message
            DialogResult result = MessageBox.Show("Are you sure you want to update your profile?",
                                          "Confirm Update",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.No) {
                return;
            }
                
            User updated = new User();
            updated.UserID = loggedAdminId;
            updated.Name = name;
            updated.Password = password;
            updated.Email = email;
            updated.Gender = gender;
            updated.BloodGroup = bloodGroup;
            updated.DateOfBirth = dob;
            updated.UserType = "Admin";
            UserRepository ur = new UserRepository();
            int status = ur.UpdateUser(updated);

            
            if (status == 1) {
                MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Profile update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.LoadUser();
        }
    }
}
