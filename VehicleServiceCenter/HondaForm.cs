﻿using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;

namespace VehicleServiceCenter
{
    public partial class HondaForm : Form
    {

        private int userID;
        private string licensePlate;
        private string carModel;
        public HondaForm(int userID)
        {
            InitializeComponent();
        }
        public HondaForm()
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
                licensePlate = "654321";
                carModel = "CR-V";
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

        private void HondaForm_Load(object sender, EventArgs e)
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
                licensePlate = "643215";
                carModel = "INSIGHT";
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
                licensePlate = "789654";
                carModel = "GRACE";
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
                licensePlate = "852369";
                carModel = "ACCORD";
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
                licensePlate = "963147";
                carModel = "VEXEL";
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
                licensePlate = "7539514";
                carModel = "CIVIC";
                Vehicle v1 = new Vehicle(userID, licensePlate, carModel);
                VehicleRepository v2 = new VehicleRepository();
                v2.InsertVehicle(v1);

                MessageBox.Show("Vehicle added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            LoginForm newForm = new LoginForm();
            newForm.Show();
            this.Hide();
        }

        private void HondaForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1024, 576);
            this.MaximumSize = new Size(1024, 576);
            this.MinimumSize = new Size(1024, 576);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
