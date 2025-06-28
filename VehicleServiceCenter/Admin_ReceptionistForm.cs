using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;
using VehicleServiceCenter.Services;

namespace VehicleServiceCenter
{
    public partial class Admin_ReceptionistForm : Form {
        private int loggedId;
        private ReceptionistRepository receptionistRepository;

        public Admin_ReceptionistForm(int id) {
            InitializeComponent();

            this.loggedId = id;
            this.receptionistRepository = new ReceptionistRepository();
            BtnReceptionist.BackColor = Color.FromArgb(136, 136, 136);
        }

        public Admin_ReceptionistForm() {
            InitializeComponent();
            BtnReceptionist.BackColor = Color.FromArgb(136, 136, 136);
        }

        private void Admin_ReceptionistForm_Load(object sender, EventArgs e) {

            UserRepository ur = new UserRepository();
            User loggedUser = ur.GetUserById(this.loggedId); 


            LoadReceptionistData();


            this.dataGridView_Reps.SelectionChanged += new System.EventHandler(this.dataGridView_Reps_SelectionChanged);
            this.checkedListBox_gender.ItemCheck += checkedListBox_gender_ItemCheck;


            ResetReceptionistFields();



        }

        private void btnHome_Click(object sender, EventArgs e) {
            AdminForm a1 = new AdminForm();
            a1.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e) {
            AdminCustomerForm a1 = new AdminCustomerForm();
            a1.Show();
            this.Hide();
        }

        private void btnMechanic_Click(object sender, EventArgs e) {
            Admin_Mechanic m1 = new Admin_Mechanic();
            m1.Show();
            this.Hide();
        }



        private void LoadReceptionistData() {
            this.dataGridView_Reps.SelectionChanged -= dataGridView_Reps_SelectionChanged;

            DataTable data = receptionistRepository.GetAllReceptionistDetailsAsDataTable();
            this.dataGridView_Reps.DataSource = data;

            if(dataGridView_Reps.Rows.Count > 0) {
                dataGridView_Reps.ClearSelection();
            }

            this.dataGridView_Reps.SelectionChanged += dataGridView_Reps_SelectionChanged;
        }


        private void dataGridView_Reps_SelectionChanged(object sender, EventArgs e) {
            try {
                if (dataGridView_Reps.SelectedRows.Count == 1) {
                    var row = dataGridView_Reps.SelectedRows[0];
                    if (row == null || row.Cells["UserID"].Value == null) return;

                    textBox_UserID.Text = row.Cells["UserID"].Value.ToString();
                    UserNameTxtBox.Text = row.Cells["Name"].Value?.ToString();
                    textBox_email.Text = row.Cells["Email"].Value?.ToString();
                    textBox_password.Text = row.Cells["Password"].Value?.ToString();

                    // Set gender
                    string gender = row.Cells["Gender"].Value?.ToString()?.ToLower() ?? "";
                    for (int i = 0; i < checkedListBox_gender.Items.Count; i++)
                        checkedListBox_gender.SetItemChecked(i, false);
                    for (int i = 0; i < checkedListBox_gender.Items.Count; i++) {
                        string item = checkedListBox_gender.Items[i].ToString().ToLower();
                        if (item == gender) {
                            checkedListBox_gender.SetItemChecked(i, true);
                            break;
                        }
                    }

                    // Date of Birth
                    if (DateTime.TryParse(row.Cells["DateOfBirth"].Value?.ToString(), out DateTime dob))
                        dateTimePicker_dob.Value = dob;

                    // Blood group
                    string bloodGroup = row.Cells["BloodGroup"].Value?.ToString();
                    int index = comboBox_blood.FindStringExact(bloodGroup);
                    comboBox_blood.SelectedIndex = index >= 0 ? index : -1;

                    // ShiftTime
                    string shift = row.Cells["ShiftTime"].Value?.ToString()?.ToLower() ?? "";
                    radioButton_morning.Checked = shift == "morning";
                    radioButton_noon.Checked = shift == "noon";
                    radioButton_night.Checked = shift == "night";
                } else {
                    ResetReceptionistFields();
                }
            } catch (Exception ex) {
                MessageBox.Show($"Error during selection: {ex.Message}", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void ResetReceptionistFields() {
            textBox_UserID.Text = string.Empty;
            UserNameTxtBox.Text = string.Empty;
            textBox_email.Text = string.Empty;
            textBox_password.Text = string.Empty;



            for (int i = 0; i < checkedListBox_gender.Items.Count; i++) {
                checkedListBox_gender.SetItemChecked(i, false);
            }


            dateTimePicker_dob.Value = DateTime.Now;


            comboBox_blood.SelectedIndex = -1;


            radioButton_morning.Checked = false;
            radioButton_noon.Checked = false;
            radioButton_night.Checked = false;
        }
        private void checkedListBox_gender_ItemCheck(object sender, ItemCheckEventArgs e) {
            for (int i = 0; i < checkedListBox_gender.Items.Count; i++) {
                if (i != e.Index) {
                    checkedListBox_gender.SetItemChecked(i, false);
                }
            }
        }

        private void button_update_Click(object sender, EventArgs e) {
            // if no row selected
            if (string.IsNullOrWhiteSpace(textBox_UserID.Text)) {
                MessageBox.Show("select a receptionist from the table to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = int.Parse(textBox_UserID.Text);
            string name = UserNameTxtBox.Text.Trim();
            string email = textBox_email.Text.Trim();
            string password = textBox_password.Text.Trim();
            DateTime dob = dateTimePicker_dob.Value;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password)) {
                MessageBox.Show("Name, Email, and Password fields cannot be empty.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gender = "";
            int genderCount = 0;
            for (int i = 0; i < checkedListBox_gender.Items.Count; i++) {
                if (checkedListBox_gender.GetItemChecked(i)) {
                    gender = checkedListBox_gender.Items[i].ToString();
                    genderCount++;
                }
            }
            if (genderCount != 1) {
                MessageBox.Show("Please select exactly one gender.", "Gender Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bloodGroup = comboBox_blood.SelectedItem?.ToString() ?? "";
            if (string.IsNullOrWhiteSpace(bloodGroup)) {
                MessageBox.Show("Please select a blood group.", "Missing Blood Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string shift = "";
            if (radioButton_morning.Checked) {
                shift = "Morning";
            } else if (radioButton_noon.Checked) {
                shift = "Noon";
            } else if (radioButton_night.Checked) {
                shift = "Night";
            } else {
                MessageBox.Show("Please select a shift.", "Missing Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update Iinfo
            Receptionist rep = new Receptionist();
            rep.UserID = userId;
            rep.Name = name;
            rep.Gender = gender;
            rep.Password = password;
            rep.DateOfBirth = dob;
            rep.BloodGroup = bloodGroup;
            rep.Email = email;
            rep.ShiftTime = shift;

            ReceptionistRepository rr = new ReceptionistRepository();
            int status = rr.UpdateReceptionist(rep);

            if (status == 0) {
                MessageBox.Show("Update failed. Please try again.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                MessageBox.Show("Receptionist updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReceptionistData();
                dataGridView_Reps.ClearSelection();
                this.ResetReceptionistFields();
            }
        }

        private void button_delete_Click(object sender, EventArgs e) {
            // If no rows selected 
            if (string.IsNullOrWhiteSpace(textBox_UserID.Text)) {
                MessageBox.Show("Please select a receptionist from the table to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this receptionist?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) {
                return;
            }

            
            int userId = int.Parse(textBox_UserID.Text);
            ReceptionistRepository rr = new ReceptionistRepository();
            int status = rr.DeleteReceptionist(userId);

            if(status == -1) {
                MessageBox.Show("Receptionist does not exist.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (status == 0) {
                MessageBox.Show("Failed to delete receptionist. Please try again.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                MessageBox.Show("Receptionist deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReceptionistData();
                dataGridView_Reps.ClearSelection();
                ResetReceptionistFields();
            }
        }
    }
}
