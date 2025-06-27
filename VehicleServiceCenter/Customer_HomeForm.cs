namespace VehicleServiceCenter
{
    public partial class Customer_HomeForm : Form
    {
        public Customer_HomeForm()
        {
            InitializeComponent();

            showPurchasedServices();
            
            iconButton1.BackColor = Color.FromArgb(136, 136, 136);
        }
        private int x = 40, y = 80;

        private void showPurchasedServices()
        {
            for (int i = 0; i < 6; i++)
            {

                Panel newPanel = new Panel();

                newPanel.Size = new Size(154, 154);

                if (x + newPanel.Width > panel2.ClientSize.Width)
                {
                    x = 40;
                    y = y + 194;
                }

                newPanel.Location = new Point(x, y);
                x = x + 194;

                if (y > 991)
                {
                    break;
                }

                newPanel.BorderStyle = BorderStyle.None;
                newPanel.BackColor = Color.FromArgb(56, 56, 56);
                newPanel.Name = $"dynamicPanel_{i}";

                Label panelLabel = new Label();
                panelLabel.Text = $"#{i + 1}";
                panelLabel.AutoSize = true;
                panelLabel.Location = new Point(10, 10);
                panelLabel.ForeColor = Color.White;
                newPanel.Controls.Add(panelLabel);

                Label serviceLabel = new Label();
                serviceLabel.Text = "I am a hero and this is a test string";
                serviceLabel.AutoSize = false;
                serviceLabel.ForeColor = Color.White;
                serviceLabel.Font = new Font("Arial", 17, FontStyle.Bold);
                serviceLabel.TextAlign = ContentAlignment.MiddleCenter;
                serviceLabel.BackColor = Color.Transparent;
                serviceLabel.Size = new Size(newPanel.Width, newPanel.Height - 30);
                serviceLabel.Location = new Point(0, (newPanel.Height / 2) - 70);
                newPanel.Controls.Add(serviceLabel);

                Label CostLabel = new Label();
                CostLabel.Text = $"TK 5555";
                CostLabel.AutoSize = true;
                CostLabel.ForeColor = Color.FromArgb(255, 128, 0);
                CostLabel.Font = new Font("Arial", 14, FontStyle.Bold);
                CostLabel.TextAlign = ContentAlignment.BottomRight;
                CostLabel.Size = new Size(newPanel.Width, 30);
                CostLabel.Location = new Point(
                    newPanel.Width - CostLabel.PreferredWidth - 1,
                    newPanel.Height - CostLabel.PreferredHeight - 5
                );

                newPanel.Controls.Add(CostLabel);

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
    }
}