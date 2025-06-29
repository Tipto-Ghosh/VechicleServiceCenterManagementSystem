using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;

namespace VehicleServiceCenter
{
    public partial class SuzukiForm : Form
    {
        private int userID;
        private string licensePlate;
        private string carModel;
        public SuzukiForm(int userID)
        {
            InitializeComponent();
        }public SuzukiForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Do you want to add this vehicle?",
               "Confirm Insertion",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
                licensePlate = "005060";
                carModel = "GRAND VITARA";
                Vehicle v1 = new Vehicle(userID, licensePlate, carModel);
                VehicleRepository v2 = new VehicleRepository();
                v2.InsertVehicle(v1);

                MessageBox.Show("Vehicle added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Customer_HomeForm newForm = new Customer_HomeForm(userID);
                newForm.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Do you want to add this vehicle?",
               "Confirm Insertion",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
                licensePlate = "997959";
                carModel = "ERTIGA";
                Vehicle v1 = new Vehicle(userID, licensePlate, carModel);
                VehicleRepository v2 = new VehicleRepository();
                v2.InsertVehicle(v1);

                MessageBox.Show("Vehicle added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Customer_HomeForm newForm = new Customer_HomeForm(userID);
                newForm.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Do you want to add this vehicle?",
              "Confirm Insertion",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
          );

            if (result == DialogResult.Yes)
            {
                licensePlate = "445465";
                carModel = "LIANA";
                Vehicle v1 = new Vehicle(userID, licensePlate, carModel);
                VehicleRepository v2 = new VehicleRepository();
                v2.InsertVehicle(v1);

                MessageBox.Show("Vehicle added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Customer_HomeForm newForm = new Customer_HomeForm(userID);
                newForm.Show();
                this.Hide();
            }
            else
            {
                return;
            }
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Do you want to add this vehicle?",
              "Confirm Insertion",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
          );

            if (result == DialogResult.Yes)
            {
                licensePlate = "447477";
                carModel = "WAGON-R";
                Vehicle v1 = new Vehicle(userID, licensePlate, carModel);
                VehicleRepository v2 = new VehicleRepository();
                v2.InsertVehicle(v1);

                MessageBox.Show("Vehicle added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Customer_HomeForm newForm = new Customer_HomeForm(userID);
                newForm.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Do you want to add this vehicle?",
              "Confirm Insertion",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
          );

            if (result == DialogResult.Yes)
            {
                licensePlate = "221252";
                carModel = "SWIFT";
                Vehicle v1 = new Vehicle(userID, licensePlate, carModel);
                VehicleRepository v2 = new VehicleRepository();
                v2.InsertVehicle(v1);

                MessageBox.Show("Vehicle added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Customer_HomeForm newForm = new Customer_HomeForm(userID);
                newForm.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Do you want to add this vehicle?",
              "Confirm Insertion",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
          );

            if (result == DialogResult.Yes)
            {
                licensePlate = "669656";
                carModel = "CIAZ";
                Vehicle v1 = new Vehicle(userID, licensePlate, carModel);
                VehicleRepository v2 = new VehicleRepository();
                v2.InsertVehicle(v1);

            this.Hide();
        }

        private void SuzukiForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1024, 576);
            this.MaximumSize = new Size(1024, 576);
            this.MinimumSize = new Size(1024, 576);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
