using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;
using VehicleServiceCenter.Services;

namespace VehicleServiceCenter
{
    public partial class ShopForm : Form
    {
        public Form _previousForm;


        private int loggedCusId;
        private OfferedService s1;
        private int Result;

        private int serviceID;
        private string serviceName;
        private string serviceDescription;
        private int servicePrice;
        private int serviceDuration;


        public ShopForm(int userID)
        {
            this.loggedCusId = userID;
            InitializeComponent();
            SetLabelText();

        }
        public ShopForm()
        {
            InitializeComponent();
            SetLabelText();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }


        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void SetLabelText()
        {
            label5.Text = "408/1 (Old KA 66/1), Kuratoli,\t Khilkhet, Dhaka 1229, Bangladesh";
            label5.AutoSize = false;
            label5.Size = new Size(200, 60);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Customer_HomeForm c1 = new Customer_HomeForm(loggedCusId);
            c1.Show();
            this.Close();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            UserRepository ur = new UserRepository();
            User user = ur.GetUserById(loggedCusId);

            this.label6.Text = user.Name;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            bool confirmPurchase = MessageBox.Show(
            "Are you sure you want to confirm your purchase?",
            "Confirm Purchase",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            ) == DialogResult.Yes;

            if (!confirmPurchase)
            {
                return;
            }

            
            serviceName = "Oil Change";
            serviceDescription = "Change the engine oil and filter to ensure smooth operation.";
            servicePrice = 1500;
            serviceDuration = 30;

            OfferedService offeredService = new OfferedService  (serviceName, serviceDescription, servicePrice, serviceDuration, loggedCusId);


            OfferedServiceService f1 = new OfferedServiceService();
            Result = f1.AddService(offeredService);


            if (Result == 1)
            {
                MessageBox.Show("Service added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add service.");
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            bool confirmPurchase = MessageBox.Show(
"Are you sure you want to confirm your purchase?",
"Confirm Purchase",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question
) == DialogResult.Yes;

            if (!confirmPurchase)
            {
                return;
            }

            serviceID = loggedCusId;
            serviceName = "Engine Tuning";
            serviceDescription = "Optimize engine performance by adjusting fuel and air mixture.";
            servicePrice = 2500;
            serviceDuration = 300;

            OfferedService offeredService = new OfferedService(serviceName, serviceDescription, servicePrice, serviceDuration, loggedCusId);
            offeredService.ServiceID = loggedCusId;


            OfferedServiceService f1 = new OfferedServiceService();
            Result = f1.AddService(offeredService);


            if (Result == 1)
            {
                MessageBox.Show("Service added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add service.");
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            bool confirmPurchase = MessageBox.Show(
"Are you sure you want to confirm your purchase?",
"Confirm Purchase",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question
) == DialogResult.Yes;

            if (!confirmPurchase)
            {
                return;
            }

            serviceID = loggedCusId;
            serviceName = "Brake Inspection";
            serviceDescription = "Thorough inspection of brake system for safety and performance.";
            servicePrice = 500;
            serviceDuration = 180;

            OfferedService offeredService = new OfferedService(serviceName, serviceDescription, servicePrice, serviceDuration, loggedCusId);

            offeredService.ServiceID = loggedCusId;


            OfferedServiceService f1 = new OfferedServiceService();
            Result = f1.AddService(offeredService);


            if (Result == 1)
            {
                MessageBox.Show("Service added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add service.");
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            bool confirmPurchase = MessageBox.Show(
"Are you sure you want to confirm your purchase?",
"Confirm Purchase",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question
) == DialogResult.Yes;

            if (!confirmPurchase)
            {
                return;
            }

            serviceID = loggedCusId;
            serviceName = "car maintenance";
            serviceDescription = "Regular maintenance to keep your car in top condition.";
            servicePrice = 3000;
            serviceDuration = 2880;

            OfferedService offeredService = new OfferedService(serviceName, serviceDescription, servicePrice, serviceDuration, loggedCusId);
            offeredService.ServiceID = loggedCusId;


            OfferedServiceService f1 = new OfferedServiceService();
            Result = f1.AddService(offeredService);


            if (Result == 1)
            {
                MessageBox.Show("Service added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add service.");
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Point scrollPosition = new Point(0, 976);

            panel1.AutoScrollPosition = scrollPosition;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            bool confirmPurchase = MessageBox.Show(
"Are you sure you want to confirm your purchase?",
"Confirm Purchase",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question
) == DialogResult.Yes;

            if (!confirmPurchase)
            {
                return;
            }

            serviceID = loggedCusId;
            serviceName = "Generator Repair";
            serviceDescription = "Repair and maintenance of generator systems.";
            servicePrice = 4000;
            serviceDuration = 1440;

            OfferedService offeredService = new OfferedService(serviceName, serviceDescription, servicePrice, serviceDuration, loggedCusId);
            offeredService.ServiceID = loggedCusId;


            OfferedServiceService f1 = new OfferedServiceService();
            Result = f1.AddService(offeredService);


            if (Result == 1)
            {
                MessageBox.Show("Service added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add service.");
            }
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            bool confirmPurchase = MessageBox.Show(
"Are you sure you want to confirm your purchase?",
"Confirm Purchase",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question
) == DialogResult.Yes;

            if (!confirmPurchase)
            {
                return;
            }

            serviceID = loggedCusId;
            serviceName = "Compressor Repair";
            servicePrice = 3500;
            serviceDescription = "Repair and maintenance of compressor systems.";
            serviceDuration = 700;

            OfferedService offeredService = new OfferedService(serviceName, serviceDescription, servicePrice, serviceDuration, loggedCusId);
            offeredService.ServiceID = loggedCusId;


            OfferedServiceService f1 = new OfferedServiceService();
            Result = f1.AddService(offeredService);


            if (Result == 1)
            {
                MessageBox.Show("Service added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add service.");
            }
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            bool confirmPurchase = MessageBox.Show(
"Are you sure you want to confirm your purchase?",
"Confirm Purchase",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question
) == DialogResult.Yes;

            if (!confirmPurchase)
            {
                return;
            }

            serviceID = loggedCusId;
            serviceName = "Coolant Refill";
            serviceDescription = "Refill and replace coolant for optimal engine temperature control.";
            servicePrice = 800;
            serviceDuration = 60;

            OfferedService offeredService = new OfferedService(serviceName, serviceDescription, servicePrice, serviceDuration, loggedCusId);
            offeredService.ServiceID = loggedCusId;


            OfferedServiceService f1 = new OfferedServiceService();
            Result = f1.AddService(offeredService);


            if (Result == 1)
            {
                MessageBox.Show("Service added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add service.");
            }
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            bool confirmPurchase = MessageBox.Show(
"Are you sure you want to confirm your purchase?",
"Confirm Purchase",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question
) == DialogResult.Yes;

            if (!confirmPurchase)
            {
                return;
            }

            serviceID = loggedCusId;
            serviceName = "Complete Car Maintenance";
            serviceDescription = "Comprehensive maintenance package for your vehicle.";
            servicePrice = 5000;
            serviceDuration = 4320;

            OfferedService offeredService = new OfferedService(serviceName, serviceDescription, servicePrice, serviceDuration, loggedCusId);
            offeredService.ServiceID = loggedCusId;


            OfferedServiceService f1 = new OfferedServiceService();
            Result = f1.AddService(offeredService);


            if (Result == 1)
            {
                MessageBox.Show("Service added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add service.");
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            bool confirmPurchase = MessageBox.Show(
"Are you sure you want to confirm your purchase?",
"Confirm Purchase",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question
) == DialogResult.Yes;

            if (!confirmPurchase)
            {
                return;
            }

            serviceID = loggedCusId;
            serviceName = "Delux Car Wash";
            serviceDescription = "Thorough car wash and detailing service.";
            servicePrice = 1000;
            serviceDuration = 320;

            OfferedService offeredService = new OfferedService(serviceName, serviceDescription, servicePrice, serviceDuration, loggedCusId);
            offeredService.ServiceID = loggedCusId;


            OfferedServiceService f1 = new OfferedServiceService();
            Result = f1.AddService(offeredService);


            if (Result == 1)
            {
                MessageBox.Show("Service added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add service.");
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            bool confirmPurchase = MessageBox.Show(
"Are you sure you want to confirm your purchase?",
"Confirm Purchase",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question
) == DialogResult.Yes;

            if (!confirmPurchase)
            {
                return;
            }

            serviceID = loggedCusId;
            serviceName = "Basic Car Wash";
            serviceDescription = "Basic car wash service to keep your vehicle clean.";
            servicePrice = 500;
            serviceDuration = 120;

            OfferedService offeredService = new OfferedService(serviceName, serviceDescription, servicePrice, serviceDuration, loggedCusId);
            offeredService.ServiceID = loggedCusId;


            OfferedServiceService f1 = new OfferedServiceService();
            Result = f1.AddService(offeredService);


            if (Result == 1)
            {
                MessageBox.Show("Service added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add service.");
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            bool confirmPurchase = MessageBox.Show(
"Are you sure you want to confirm your purchase?",
"Confirm Purchase",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question
) == DialogResult.Yes;

            if (!confirmPurchase)
            {
                return;
            }

            serviceID = loggedCusId;
            serviceName = "Wax Wash";
            serviceDescription = "Wax wash service for a shiny and protected finish.";
            servicePrice = 1500;
            serviceDuration = 240;

            OfferedService offeredService = new OfferedService(serviceName, serviceDescription, servicePrice, serviceDuration, loggedCusId);
            offeredService.ServiceID = loggedCusId;


            OfferedServiceService f1 = new OfferedServiceService();
            Result = f1.AddService(offeredService);


            if (Result == 1)
            {
                MessageBox.Show("Service added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add service.");
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            bool confirmPurchase = MessageBox.Show(
"Are you sure you want to confirm your purchase?",
"Confirm Purchase",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question
) == DialogResult.Yes;

            if (!confirmPurchase)
            {
                return;
            }

            serviceID = loggedCusId;
            serviceName = "interior car cleaning";
            serviceDescription = "Thorough interior cleaning for a fresh and tidy cabin.";
            servicePrice = 1200;
            serviceDuration = 240;

            OfferedService offeredService = new OfferedService(serviceName, serviceDescription, servicePrice, serviceDuration, loggedCusId);
            offeredService.ServiceID = loggedCusId;


            OfferedServiceService f1 = new OfferedServiceService();
            Result = f1.AddService(offeredService);


            if (Result == 1)
            {
                MessageBox.Show("Service added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add service.");
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            bool confirmPurchase = MessageBox.Show(
"Are you sure you want to confirm your purchase?",
"Confirm Purchase",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question
) == DialogResult.Yes;

            if (!confirmPurchase)
            {
                return;
            }

            serviceID = loggedCusId;
            serviceName = "Compressor Repair";
            serviceDescription = "Repair and maintenance of compressor systems.";
            servicePrice = 3500;
            serviceDuration = 700;


            OfferedService offeredService = new OfferedService(serviceName, serviceDescription, servicePrice, serviceDuration, loggedCusId);
            offeredService.ServiceID = loggedCusId;

            OfferedServiceService f1 = new OfferedServiceService();
            Result = f1.AddService(offeredService);


            if (Result == 1)
            {
                MessageBox.Show("Service added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add service.");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
