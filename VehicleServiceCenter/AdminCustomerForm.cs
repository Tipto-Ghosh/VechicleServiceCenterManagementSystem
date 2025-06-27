using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;
using VehicleServiceCenter.Services;

namespace VehicleServiceCenter
{
    public partial class AdminCustomerForm : Form {

        private int loggedId;
        public AdminCustomerForm(int id) {
            this.loggedId = id;
            InitializeComponent();
            btnCustomer.BackColor = Color.FromArgb(136, 136, 136);
        }

        public AdminCustomerForm() {
            InitializeComponent();
            btnCustomer.BackColor = Color.FromArgb(136, 136, 136);
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void btnHome_Click(object sender, EventArgs e) {
            AdminForm a1 = new AdminForm();
            a1.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

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

        private void AdminCustomerForm_Load(object sender, EventArgs e) {
            UserRepository ur = new UserRepository();

            // Show logged admin Name
            Admin admin = new Admin();

            UserRepository userRepo = new UserRepository();
            User loggedUser = userRepo.GetUserById(loggedId);

            this.label_name.Text = loggedUser.Name;
            this.label_role.Text = loggedUser.UserType;
        }
    }
}
