namespace VehicleServiceCenter
{
    public partial class NissanForm : Form
    {
        public NissanForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(178, 178, 178);
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(68, 68, 68);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(178, 178, 178);
            }
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(68, 68, 68);
            }
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(178, 178, 178);
            }
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(68, 68, 68);
            }
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(178, 178, 178);
            }
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(68, 68, 68);
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(178, 178, 178);
            }
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(68, 68, 68);
            }
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(178, 178, 178);
            }
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(68, 68, 68);
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            CarSelection newForm = new CarSelection();
            newForm.Show();


            this.Hide();
        }
    }
}
