using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;
using VehicleServiceCenter.Services;

namespace VehicleServiceCenter
{
    public partial class AdminForm : Form {
        private int loggedAdminId;
        public AdminForm(int adminId) {
            this.loggedAdminId = adminId;
            InitializeComponent(); // Initializes the components defined in Admin.Designer.cs

            // Call this method to initially set all buttons to their normal state
            // and attach the universal click event handler.

            btnHome.BackColor = Color.FromArgb(136, 136, 136);

            Console.WriteLine(this.loggedAdminId);
        }

        public AdminForm() {
            InitializeComponent();
            btnHome.BackColor = Color.FromArgb(136, 136, 136);
        }




        private void label2_Click(object sender, EventArgs e) {

        }

        private void label8_Click(object sender, EventArgs e) {

        }

        private void label9_Click(object sender, EventArgs e) {

        }

        private void iconButton2_Click(object sender, EventArgs e) {
            AdminCustomerForm a1 = new AdminCustomerForm(loggedAdminId);
            a1.Show();
            this.Hide();

        }

        private void btnHome_Click(object sender, EventArgs e) {

        }

        private void iconButton3_Click(object sender, EventArgs e) {
            Admin_ReceptionistForm r1 = new Admin_ReceptionistForm();
            r1.Show();
            this.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e) {
            Admin_Mechanic m1 = new Admin_Mechanic();
            m1.Show();
            this.Hide();
        }

        private void PanelHome_Paint(object sender, PaintEventArgs e) {

        }

        private void AdminForm_Load(object sender, EventArgs e) {
            // Show logged admin Name
            Admin admin = new Admin();

            UserRepository userRepo = new UserRepository();
            User loggedUser = userRepo.GetUserById(loggedAdminId);

            this.label_name.Text = loggedUser.Name;

            // Show Customer count
            CustomerRepository cr = new CustomerRepository();

            int customerCount = cr.GetCustomerCount();
            this.label_customer_count.Text = customerCount.ToString();


            // Show Receptionist Count
            MechanicRepository mr = new MechanicRepository();
            int mechCount = mr.GetMechanicCount();
            this.label_mech_count.Text = mechCount.ToString();

            // Show Admin Count
            AdminRepository ar = new AdminRepository();
            int adminCount = ar.GetAdminCount();
            this.label_admin_count.Text = adminCount.ToString();

            // Show Receptionist count
            ReceptionistRepository re = new ReceptionistRepository();
            int receptionistCount = re.GetReceptionistCount();
            this.label_receptionist_count.Text = receptionistCount.ToString();
        }
    }
}
