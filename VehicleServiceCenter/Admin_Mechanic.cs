namespace VehicleServiceCenter
{
    public partial class Admin_Mechanic : Form
    {
        private int loggedAdminId;
        public Admin_Mechanic()
        {
            InitializeComponent();
            btnMechanic.BackColor = Color.FromArgb(136, 136, 136);
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminForm a1 = new AdminForm();
            a1.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            AdminCustomerForm a1 = new AdminCustomerForm(loggedAdminId);
            a1.Show();
            this.Hide();
        }

        private void BtnReceptionist_Click(object sender, EventArgs e)
        {
            Admin_ReceptionistForm r1 = new Admin_ReceptionistForm();
            r1.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Mechanic_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1024, 576);
            this.MaximumSize = new Size(1024, 576);
            this.MinimumSize = new Size(1024, 576);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
