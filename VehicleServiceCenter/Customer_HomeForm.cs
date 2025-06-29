using VehicleServiceCenter.Repositories;
using VehicleServiceCenter.Models;
using System;
using System.Collections.Generic;
using System.Drawing; 
using System.Windows.Forms; 

namespace VehicleServiceCenter
{
    public partial class Customer_HomeForm : Form
    {
        private int loggedCustomerId;

        public Customer_HomeForm(int cusId)
        {
            loggedCustomerId = cusId;
            InitializeComponent();

            showPurchasedServices(loggedCustomerId); 

            iconButton_LogOut.BackColor = Color.FromArgb(136, 136, 136);
        }

        public Customer_HomeForm()
        {
            InitializeComponent();


            iconButton_LogOut.BackColor = Color.FromArgb(136, 136, 136);
        }

        private int x = 40, y = 80; 
        private void showPurchasedServices(int customerId) { 
            x = 40;
            y = 40;

            panel2.Controls.Clear();

            OfferedServiceRepository _offeredServiceRepository = new OfferedServiceRepository();
            List<string> purchasedServices = _offeredServiceRepository.GetServicesByCustomerId(customerId); // Use the parameter 'customerId'

            foreach (string serviceName in purchasedServices)
            {
                Panel newPanel = new Panel();
                newPanel.Size = new Size(154, 154);

                if (x + newPanel.Width > panel2.ClientSize.Width - 40)
                {
                    x = 40;
                    y += 194;
                }

                newPanel.Location = new Point(x, y);
                x += 194;

                newPanel.BorderStyle = BorderStyle.None;
                newPanel.BackColor = Color.FromArgb(56, 56, 56);

                Label panelLabel = new Label();
                panelLabel.Text = $"# {purchasedServices.IndexOf(serviceName) + 1}"; 
                panelLabel.AutoSize = true;
                panelLabel.Location = new Point(10, 10);
                panelLabel.ForeColor = Color.White;
                newPanel.Controls.Add(panelLabel);

                Label serviceLabel = new Label();
                serviceLabel.Text = serviceName;
                serviceLabel.AutoSize = false;
                serviceLabel.ForeColor = Color.White;
                serviceLabel.Font = new Font("Arial", 17, FontStyle.Bold);
                serviceLabel.TextAlign = ContentAlignment.MiddleCenter;
                serviceLabel.BackColor = Color.Transparent;
                serviceLabel.Size = new Size(newPanel.Width, newPanel.Height - 30);
                serviceLabel.Location = new Point(0, (newPanel.Height / 2) - 70);
                newPanel.Controls.Add(serviceLabel);

                panel2.Controls.Add(newPanel);
            }

            panel2.Select();
        }

        private void btnCreatePanel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            LoginForm lf = new LoginForm();
            this.Hide();
            lf.ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            Customer_Edit_Form customer_Edit_Form = new Customer_Edit_Form();
            customer_Edit_Form.Show();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ShopForm s1 = new ShopForm();
            s1._previousForm = this;
            s1.Show();
            this.Hide();
        }

        private void Customer_HomeForm_Load(object sender, EventArgs e)
        {
            UserRepository ur = new UserRepository();
            User user = ur.GetUserById(loggedCustomerId);

            fullNameLabel.Text = user.Name;

            // Convert list to a single string
            string vehicleText = string.Join("\n", vehicleList.Select(v =>
                $"{v.Model}"
            ));

            // Set the text to label2
            label2.Text = vehicleText;

            this.Size = new Size(1024, 576);
            this.MaximumSize = new Size(1024, 576);
            this.MinimumSize = new Size(1024, 576);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void iconButton_update_profile_Click(object sender, EventArgs e)
        {
            Customer_Edit_Form cef = new Customer_Edit_Form(loggedCustomerId);
            this.Hide();
            cef.Show();
        }

        private void iconButton_book_appointment_Click(object sender, EventArgs e)
        {
            ShopForm sf = new ShopForm(loggedCustomerId);
            this.Hide();
            sf.Show();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            CarSelection carSelection = new CarSelection(loggedCustomerId);
            carSelection.Show();
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