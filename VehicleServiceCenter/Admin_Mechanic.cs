using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;
using VehicleServiceCenter.Services;

namespace VehicleServiceCenter {
    public partial class Admin_Mechanic : Form {
        private int loggedUserId;
        private MechanicRepository mechanicRepository;

        public Admin_Mechanic(int id) {
            this.loggedUserId = id;
            mechanicRepository = new MechanicRepository();
            InitializeComponent();
        }

        public Admin_Mechanic() {
            mechanicRepository = new MechanicRepository();
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e) {
            UserRepository ur = new UserRepository();
            User loggedUser = ur.GetUserById(loggedUserId);

            if (loggedUser.UserType.ToLower() == "admin") {
                AdminForm a1 = new AdminForm(this.loggedUserId);
                a1.Show();
                this.Hide();
            } else {
                MessageBox.Show("in progress", "Development phase", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e) {
            AdminCustomerForm a1 = new AdminCustomerForm(loggedUserId);
            a1.Show();
            this.Hide();
        }

        private void BtnReceptionist_Click(object sender, EventArgs e) {
            UserRepository ur = new UserRepository();
            User loggedUser = ur.GetUserById(loggedUserId);

            string type = loggedUser.UserType.ToLower();

            if (type == "admin") {
                Admin_ReceptionistForm r1 = new Admin_ReceptionistForm();
                r1.Show();
            } else if (type == "receptionist") {

            }
            this.Hide();
        }

        private void Admin_Mechanic_Load(object sender, EventArgs e) {
            UserRepository ur = new UserRepository();
            User loggedUser = ur.GetUserById(loggedUserId);
            label_full_name.Text = loggedUser.Name;
            label_type.Text = loggedUser.UserType;

            LoadMechanicData();
            dataGridView_mechic.SelectionChanged += dataGridView_mechic_SelectionChanged;
            ResetMechanicFields();


            if (loggedUser.UserType.ToLower() != "admin") {
                BtnReceptionist.Hide();
            }
        }

        private void LoadMechanicData() {
            dataGridView_mechic.SelectionChanged -= dataGridView_mechic_SelectionChanged;

            DataTable dt = mechanicRepository.GetAllMechanicsAsDataTable();
            dataGridView_mechic.DataSource = dt;

            if (dataGridView_mechic.Rows.Count > 0) {
                dataGridView_mechic.ClearSelection();
            }
            dataGridView_mechic.SelectionChanged += dataGridView_mechic_SelectionChanged;
        }

        private void dataGridView_mechic_SelectionChanged(object sender, EventArgs e) {
            try {
                if (dataGridView_mechic.SelectedRows.Count == 1) {
                    var row = dataGridView_mechic.SelectedRows[0];
                    if (row?.Cells["UserID"].Value == null) return;

                    textBox_userID.Text = row.Cells["UserID"].Value.ToString();
                    UserNameTxtBox.Text = row.Cells["Name"].Value?.ToString();
                    textBox_password.Text = row.Cells["Password"].Value?.ToString();
                    textBox_email.Text = row.Cells["Email"].Value?.ToString();
                    textBox_rating.Text = row.Cells["Rating"].Value?.ToString();

                    if (DateTime.TryParse(row.Cells["DateOfBirth"].Value?.ToString(), out DateTime dob)) {
                        dateTimePicker_dob.Value = dob;
                    }

                    string bloodGroup = row.Cells["BloodGroup"].Value?.ToString();
                    int index = BloodGroupComboBox.FindStringExact(bloodGroup);
                    BloodGroupComboBox.SelectedIndex = index >= 0 ? index : -1;

                    string gender = row.Cells["Gender"].Value?.ToString()?.ToLower();
                    radioButton_male.Checked = gender == "male";
                    radioButton_female.Checked = gender == "female";
                    radioButton_other.Checked = gender == "other";

                    string status = row.Cells["Status"].Value?.ToString();
                    int statusIndex = comboBox_status.FindStringExact(status);
                    comboBox_status.SelectedIndex = statusIndex >= 0 ? statusIndex : -1;
                } else {
                    ResetMechanicFields();
                }
            } catch (Exception ex) {
                MessageBox.Show($"Error loading mechanic data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetMechanicFields() {
            textBox_userID.Text = "";
            UserNameTxtBox.Text = "";
            textBox_password.Text = "";
            textBox_email.Text = "";
            textBox_rating.Text = "";

            dateTimePicker_dob.Value = DateTime.Now;
            BloodGroupComboBox.SelectedIndex = -1;
            comboBox_status.SelectedIndex = -1;

            radioButton_male.Checked = false;
            radioButton_female.Checked = false;
            radioButton_other.Checked = false;

            dataGridView_mechic.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e) {
            // update button
            if (dataGridView_mechic.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a mechanic from the table.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView_mechic_SelectionChanged(null, null);

            int userId = int.Parse(textBox_userID.Text);

            string name = UserNameTxtBox.Text.Trim();
            string email = textBox_email.Text.Trim();
            string password = textBox_password.Text.Trim();
            string ratingText = textBox_rating.Text.Trim();
            DateTime dob = dateTimePicker_dob.Value;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(ratingText)) {
                MessageBox.Show("Please fill in all required fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(ratingText, out float rating) || rating < 0 || rating > 5) {
                MessageBox.Show("Rating must be a valid number between 0 and 5.", "Invalid Rating", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bloodGroup = BloodGroupComboBox.SelectedItem?.ToString() ?? "";
            if (string.IsNullOrWhiteSpace(bloodGroup)) {
                MessageBox.Show("Please select a blood group.", "Missing Blood Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = comboBox_status.SelectedItem?.ToString() ?? "";
            if (string.IsNullOrWhiteSpace(status)) {
                MessageBox.Show("Please select a status.", "Missing Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gender = "";
            if (radioButton_male.Checked) gender = "Male";
            else if (radioButton_female.Checked) gender = "Female";
            else if (radioButton_other.Checked) gender = "Other";
            else {
                MessageBox.Show("Please select a gender.", "Missing Gender", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Mechanic mechanic = new Mechanic();
            mechanic.UserID = userId;
            mechanic.Name = name;
            mechanic.Email = email;
            mechanic.Password = password;
            mechanic.Gender = gender;
            mechanic.DateOfBirth = dob;
            mechanic.BloodGroup = bloodGroup;
            mechanic.Status = status;
            mechanic.Rating = rating;
            mechanic.UserType = "Mechanic";


            DataAccess da = new DataAccess();
            bool updated = da.UpdateMechanic(userId, name, gender, password, dob, bloodGroup, email, rating, status);

            if (updated)
                MessageBox.Show("Mechanic updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Update failed. Please try again.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LoadMechanicData();
            ResetMechanicFields();
        }

        private void button_cancel_Click(object sender, EventArgs e) {
            ResetMechanicFields();
        }

        private void button4_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(textBox_userID.Text)) {
                MessageBox.Show("Please select a mechanic from the table to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this mechanic?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            int mechId = int.Parse(textBox_userID.Text);
            int status = mechanicRepository.DeleteMechanic(mechId);

            if (status == -1)
                MessageBox.Show("Mechanic does not exist.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (status == 0)
                MessageBox.Show("Failed to delete mechanic. Please try again.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                MessageBox.Show("Mechanic deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMechanicData();
                ResetMechanicFields();
            }
        }

        private void button_add_Click(object sender, EventArgs e) {
            // add new mechanic form
        }
    }
}
