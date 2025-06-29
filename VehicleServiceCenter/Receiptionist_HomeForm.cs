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
namespace VehicleServiceCenter
{
    public partial class Receiptionist_HomeForm : Form {
        private int loggedRepId;

        public Receiptionist_HomeForm(int id) {
            this.loggedRepId = id;
            InitializeComponent();
        }
        public Receiptionist_HomeForm() {
            InitializeComponent();
        }

        private void Receiptionist_HomeForm_Load(object sender, EventArgs e) {
            UserRepository ur = new UserRepository();
            User user = ur.GetUserById(loggedRepId);

            label_name.Text = user.Name;

            // find cus count
            CustomerRepository cr = new CustomerRepository();
            int cusCount = cr.GetCustomerCount();
            label_customer_count.Text = cusCount.ToString();

            MechanicRepository mr = new MechanicRepository();
            int machCount = mr.GetMechanicCount();
            label_mech_count.Text = machCount.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e) {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        private void label_customer_count_Click(object sender, EventArgs e) {

        }

        private void btnCustomer_Click(object sender, EventArgs e) {
            AdminCustomerForm lf = new AdminCustomerForm(loggedRepId);
            this.Hide();
            lf.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e) {
            Admin_Mechanic am = new Admin_Mechanic();
            this.Hide();
            am.Show();
        }

        private void iconButton_updateSelf_Click(object sender, EventArgs e) {
            
        }
    }
}
