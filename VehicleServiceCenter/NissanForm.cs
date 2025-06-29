using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;

namespace VehicleServiceCenter
{
    public partial class NissanForm : Form
    {
        private int userID;
        private string licensePlate;
        private string carModel;
        public NissanForm(int userID)
        {
            InitializeComponent();
        }
        public NissanForm()
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
                licensePlate = "456357";
                carModel = "SUNNY";
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
                licensePlate = "302010";
                carModel = "BLUEBIRD";
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
                licensePlate = "030102";
                carModel = "X-TRAIL";
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
                licensePlate = "998958";
                carModel = "JUKE";
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
                licensePlate = "556564";
                carModel = "ROGUE";
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
                licensePlate = "333333";
                carModel = "GT-R";
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
    }
}
