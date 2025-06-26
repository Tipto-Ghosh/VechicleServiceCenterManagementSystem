namespace VehicleServiceCenter
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent(); // Initializes the components defined in Admin.Designer.cs

            // Call this method to initially set all buttons to their normal state
            // and attach the universal click event handler.

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
            AdminCustomerForm a1 = new AdminCustomerForm();
            a1.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Admin_ReceptionistForm r1 = new Admin_ReceptionistForm();
            r1.Show();
            this.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Admin_Mechanic m1 = new Admin_Mechanic();
            m1.Show();
            this.Hide();
        }
    }
}
