namespace VehicleServiceCenter
{
    public partial class CarSelection : Form
    {
        public CarSelection()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void brandOnePictureBox_Click(object sender, EventArgs e)
        {
            ToyotaForm newForm = new ToyotaForm();
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


    }
}
