using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;

namespace VehicleServiceCenter
{
    public partial class ToyotaForm : Form
    {
        private int userID;
        private string licensePlate;
        private string carModel;
        public ToyotaForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }
        private void pictureBox19_MouseEnter(object sender, EventArgs e)
        {
            pictureBox19.BackColor = Color.FromArgb(68, 68, 68);
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            pictureBox19.BackColor = Color.Transparent;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {



            CarSelection newForm = new CarSelection(userID);
            newForm.Show();


            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {

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

        private void ToyotaForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

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
                licensePlate = "123456";
                carModel = "HILUX";
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
                licensePlate = "235415";
                carModel = "COROLLA";
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
                licensePlate = "145215";
                carModel = "LAND CRUISER";
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
                licensePlate = "445367";
                carModel = "ALLION";
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
                licensePlate = "556789";
                carModel = "NOAH";
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
                licensePlate = "667890";
                carModel = "PARABOX";
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
