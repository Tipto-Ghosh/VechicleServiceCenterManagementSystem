namespace VehicleServiceCenter
{
    public partial class CarSelection : Form
    {
        private int userID;
        public CarSelection(int userID)
        {
            this.userID = userID;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Customer_HomeForm newForm = new Customer_HomeForm(userID);
            newForm.Show();
            this.Hide();
        }

        private void brandOnePictureBox_Click(object sender, EventArgs e)
        {
            ToyotaForm newForm = new ToyotaForm(userID);
            newForm.Show();
            this.Hide();
        }
        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(178, 178, 178);
            }
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(68, 68, 68);
            }
        }
        private void Control_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(178, 178, 178);
            }
            else if (sender is Label lbl && lbl == otherBrandLabel)
            {
                lbl.BackColor = Color.FromArgb(178, 178, 178);
            }
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(68, 68, 68);
            }
            else if (sender is Label lbl && lbl == otherBrandLabel)
            {
                lbl.BackColor = Color.FromArgb(68, 68, 68);
            }
        }

        private void brandTwoPictureBox_Click(object sender, EventArgs e)
        {
            NissanForm newForm = new NissanForm(userID);
            newForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MitsubishiForm newForm = new MitsubishiForm(userID);
            newForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SuzukiForm newForm = new SuzukiForm(userID);
            newForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HondaForm newForm = new HondaForm(userID);
            newForm.Show();
            this.Hide();
        }

        private void signOutPictureBox_Click(object sender, EventArgs e)
        {
            LoginForm newForm = new LoginForm();
            newForm.Show();
            this.Hide();
        }
    }
}
