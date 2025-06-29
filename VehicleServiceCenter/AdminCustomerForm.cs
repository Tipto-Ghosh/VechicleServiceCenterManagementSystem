using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;
using VehicleServiceCenter.Services;
using System.Drawing;
using System.Windows.Forms;
using System; 

namespace VehicleServiceCenter {
    public partial class AdminCustomerForm : Form {
        private int loggedId;
        private CustomerRepository customerRepo;

        public AdminCustomerForm(int id) {
            this.loggedId = id;
            InitializeComponent();
            btnCustomer.BackColor = Color.FromArgb(136, 136, 136);
            customerRepo = new CustomerRepository();
            this.checkedListBox_gender.ItemCheck += new ItemCheckEventHandler(this.checkedListBox_gender_ItemCheck);
        }

        public AdminCustomerForm() {
            InitializeComponent();
            btnCustomer.BackColor = Color.FromArgb(136, 136, 136);
            customerRepo = new CustomerRepository();
            this.checkedListBox_gender.ItemCheck += new ItemCheckEventHandler(this.checkedListBox_gender_ItemCheck);
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void btnHome_Click(object sender, EventArgs e) {
            AdminForm a1 = new AdminForm(this.loggedId);
            a1.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void iconButton3_Click(object sender, EventArgs e) {
            Admin_ReceptionistForm r1 = new Admin_ReceptionistForm(this.loggedId);
            r1.Show();
            this.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e) {
            Admin_Mechanic m1 = new Admin_Mechanic(loggedId);
            m1.Show();
            this.Hide();
        }

        private void AdminCustomerForm_Load(object sender, EventArgs e) {
            UserRepository ur = new UserRepository();
            User loggedUser = ur.GetUserById(loggedId);

            this.label_name.Text = loggedUser.Name;
            this.label_role.Text = loggedUser.UserType;

            LoadCustomerData();
            dataGridViewCustomers.ClearSelection();
            ResetCustomerFields();
        }

        private void LoadCustomerData() {
            this.dataGridViewCustomers.SelectionChanged -= new System.EventHandler(this.dataGridViewCustomers_SelectionChanged);
            this.dataGridViewCustomers.DataSource = customerRepo.GetAllCustomerAsDataTable();
            this.dataGridViewCustomers.SelectionChanged += new System.EventHandler(this.dataGridViewCustomers_SelectionChanged);
        }

        private void dataGridViewCustomers_SelectionChanged(object sender, EventArgs e) {
            if (dataGridViewCustomers.SelectedRows.Count == 1) {
                DataGridViewRow row = dataGridViewCustomers.SelectedRows[0];

                this.textBox_UserID.Text = row.Cells["UserID"].Value.ToString();
                this.UserNameTxtBox.Text = row.Cells["Name"].Value.ToString();
                this.textBox_email.Text = row.Cells["Email"].Value.ToString();
                this.textBox_password.Text = row.Cells["Password"].Value.ToString();
                this.textBox_phone.Text = row.Cells["PhoneNumber"].Value.ToString();

                string gender = row.Cells["Gender"].Value.ToString().ToLower();
                for (int i = 0; i < checkedListBox_gender.Items.Count; i++) {
                    checkedListBox_gender.SetItemChecked(i, false);
                }
                for (int i = 0; i < checkedListBox_gender.Items.Count; i++) {
                    string item = checkedListBox_gender.Items[i].ToString().ToLower();
                    if (item == gender) {
                        checkedListBox_gender.SetItemChecked(i, true);
                        break;
                    }
                }

                if (DateTime.TryParse(row.Cells["DateOfBirth"].Value.ToString(), out DateTime dob)) {
                    this.dateTimePicker_dob.Value = dob;
                }

                string bloodGroup = row.Cells["BloodGroup"].Value.ToString();
                int index = comboBox_blood.FindStringExact(bloodGroup);
                if (index != -1) {
                    comboBox_blood.SelectedIndex = index;
                } else {
                    comboBox_blood.SelectedIndex = -1;
                }
            } else if (dataGridViewCustomers.SelectedRows.Count == 0) {
                ResetCustomerFields();
            }
        }

        private void checkedListBox_gender_ItemCheck(object sender, ItemCheckEventArgs e) {
            if (e.NewValue == CheckState.Checked) {
                for (int i = 0; i < checkedListBox_gender.Items.Count; i++) {
                    if (i != e.Index) {
                        checkedListBox_gender.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void button_Update_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBox_UserID.Text)) {
                MessageBox.Show("Please select a customer to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId;
            if (!int.TryParse(textBox_UserID.Text, out userId)) {
                MessageBox.Show("Invalid User ID. Please select a valid customer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = UserNameTxtBox.Text.Trim();
            string email = textBox_email.Text.Trim();
            string password = textBox_password.Text.Trim();
            string phoneNumber = textBox_phone.Text.Trim();
            DateTime dob = dateTimePicker_dob.Value;

            string gender = "";
            foreach (var item in checkedListBox_gender.CheckedItems) {
                gender = item.ToString();
                break;
            }

            if (string.IsNullOrEmpty(gender)) {
                MessageBox.Show("Please select a Gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bloodGroup = comboBox_blood.SelectedItem != null ? comboBox_blood.SelectedItem.ToString() : "";
            if (string.IsNullOrEmpty(bloodGroup)) {
                MessageBox.Show("Please select a Blood Group.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Customer updatedCus = new Customer {
                UserID = userId,
                Name = name,
                Gender = gender,
                Email = email,
                Password = password,
                PhoneNumber = phoneNumber,
                DateOfBirth = dob,
                BloodGroup = bloodGroup,
                UserType = "customer"
            };

            int status = customerRepo.UpdateCustomer(updatedCus);

            if (status == 0) {
                MessageBox.Show("Update Failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                MessageBox.Show("Update Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomerData();
                ResetCustomerFields();
            }
        }

        private void ResetCustomerFields() {
            this.textBox_UserID.Clear();
            this.UserNameTxtBox.Clear();
            this.textBox_email.Clear();
            this.textBox_password.Clear();
            this.textBox_phone.Clear();

            for (int i = 0; i < checkedListBox_gender.Items.Count; i++) {
                this.checkedListBox_gender.SetItemChecked(i, false);
            }

            this.comboBox_blood.SelectedIndex = -1;

            this.dateTimePicker_dob.Value = DateTime.Today;

            this.dataGridViewCustomers.ClearSelection();
        }

        private void button_add_new_Click(object sender, EventArgs e) {
            this.Hide();
            AddNewCustomerForm ancf = new AddNewCustomerForm(loggedId);
            ancf.Show();
        }


        private void button_cancel_Click(object sender, EventArgs e) {

            if (dataGridViewCustomers.SelectedRows.Count == 1) {
                dataGridViewCustomers_SelectionChanged(dataGridViewCustomers, EventArgs.Empty);
            } else {

                ResetCustomerFields();
            }
        }

        private void button_delete_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBox_UserID.Text)) {
                MessageBox.Show("Please select a customer to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userIdToDelete;
            if (!int.TryParse(textBox_UserID.Text, out userIdToDelete)) {
                MessageBox.Show("Invalid User ID for deletion. Please select a valid customer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DialogResult result = MessageBox.Show($"Are you sure you want to delete customer with User ID: {userIdToDelete}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                int status = customerRepo.DeleteCustomer(userIdToDelete);

                if (status == 0) {
                    MessageBox.Show("Deletion Failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomerData();
                    ResetCustomerFields();
                }
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e) {

            MessageBox.Show("You are already in the Customer form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void iconButton5_Click(object sender, EventArgs e) {
            MessageBox.Show("Sorry, Inventory form is in progress.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
