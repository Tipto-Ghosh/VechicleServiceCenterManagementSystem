using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;
using VehicleServiceCenter.Services;

namespace VehicleServiceCenter
{
    public partial class AdminForm : Form
    {
        private int loggedAdminId;
        public AdminForm(int adminId)
        {
            this.loggedAdminId = adminId;
            InitializeComponent(); 

           

            btnHome.BackColor = Color.FromArgb(136, 136, 136);

            Console.WriteLine(this.loggedAdminId);
        }

        public AdminForm()
        {
            InitializeComponent();
            btnHome.BackColor = Color.FromArgb(136, 136, 136);
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            AdminCustomerForm a1 = new AdminCustomerForm(loggedAdminId);
            a1.Show();
            this.Hide();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Admin_ReceptionistForm r1 = new Admin_ReceptionistForm(loggedAdminId);
            r1.Show();
            this.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Admin_Mechanic m1 = new Admin_Mechanic();
            m1.Show();
            this.Hide();
        }

        private void PanelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e) {

            Admin admin = new Admin();

            UserRepository userRepo = new UserRepository();
            User loggedUser = userRepo.GetUserById(this.loggedAdminId);

            this.label_name.Text = loggedUser.Name;

            CustomerRepository cr = new CustomerRepository();

            int customerCount = cr.GetCustomerCount();
            this.label_customer_count.Text = customerCount.ToString();


            MechanicRepository mr = new MechanicRepository();
            int mechCount = mr.GetMechanicCount();
            this.label_mech_count.Text = mechCount.ToString();

            AdminRepository ar = new AdminRepository();
            int adminCount = ar.GetAdminCount();
            this.label_admin_count.Text = adminCount.ToString();

            ReceptionistRepository re = new ReceptionistRepository();
            int receptionistCount = re.GetReceptionistCount();
            this.label_receptionist_count.Text = receptionistCount.ToString();
        }

        private void iconButton_updateSelf_Click(object sender, EventArgs e) {
            
            this.Hide();
            Admin_Profile_Edit ape = new Admin_Profile_Edit(this.loggedAdminId);
            ape.Show();
        }

        private void label_receptionist_count_Click(object sender, EventArgs e)
        {

        }
    }
}
