using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleServiceCenter
{
    public partial class Admin_ReceptionistForm : Form
    {
        private Color normalBgColor = Color.FromArgb(59, 56, 56); // Background color for normal state
        private Color activeBgColor = Color.FromArgb(136, 136, 136); // Background color for active state
        private Color normalTextColor = Color.White;             // Text and icon color for normal state
        private Color activeTextColor = Color.White;
        private IconButton currentBtn;
        public Admin_ReceptionistForm()
        {
            InitializeComponent();
            ActivateButton(BtnReceptionist, EventArgs.Empty);
        }
        private void ActivateButton(object senderBtn, EventArgs e)
        {
            // Ensure the sender is an IconButton before proceeding
            if (senderBtn is IconButton clickedBtn)
            {
                // First, reset the styles of the previously active button (if any)


                // Set the newly clicked button as the current active button
                currentBtn = clickedBtn;

                // Apply the active styling to the current button
                currentBtn.BackColor = activeBgColor; // Change background color
                currentBtn.ForeColor = activeTextColor; // Change text color to black
                currentBtn.IconColor = activeTextColor; // Change icon color to black

                // Set the font style to bold. We create a new Font object with the existing font family and size.
                currentBtn.Font = new Font(currentBtn.Font, FontStyle.Bold);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminForm a1 = new AdminForm();
            a1.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            AdminCustomerForm a1 = new AdminCustomerForm();
            a1.Show();
            this.Hide();
        }
    }
}
