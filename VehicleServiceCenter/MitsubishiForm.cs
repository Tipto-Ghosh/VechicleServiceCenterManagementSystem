using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;

namespace VehicleServiceCenter
{
    public partial class MitsubishiForm : Form
    {
        private int userID;
        private string licensePlate;
        private string carModel;
        public MitsubishiForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MitsubishiForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                licensePlate = "235135";
                carModel = "PAJERO";
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

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(68, 68, 68);
            }
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(178, 178, 178);
            }
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(68, 68, 68);
            }
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(178, 178, 178);
            }
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to add this vehicle?",
                "Confirm Insertion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                licensePlate = "123456";
                carModel = "L200";
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

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            CarSelection newForm = new CarSelection(userID);
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
                licensePlate = "256643";
                carModel = "OUTLANDER";
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
                licensePlate = "9876534";
                carModel = "X-PANDER";
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
                licensePlate = "1234567";
                carModel = "LANCER";
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
                licensePlate = "1234567";
                carModel = "ECLIPSE";
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

