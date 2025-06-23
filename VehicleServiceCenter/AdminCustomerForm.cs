using FontAwesome.Sharp;

namespace VehicleServiceCenter
{
    public partial class AdminCustomerForm : Form
    {
        // Stores the currently active (clicked) button to manage its state
        private IconButton currentBtn;

        // Private fields for storing normal and active color/font settings
        private Color normalBgColor = Color.FromArgb(59, 56, 56); // Background color for normal state
        private Color activeBgColor = Color.FromArgb(136, 136, 136); // Background color for active state
        private Color normalTextColor = Color.White;             // Text and icon color for normal state
        private Color activeTextColor = Color.White;
        public AdminCustomerForm()
        {
            InitializeComponent();
            SetAllButtonsDefaultStateAndAttachEvents();
            ActivateButton(btnCustomer, EventArgs.Empty);

        }

        private void ActivateButton(object senderBtn, EventArgs e)
        {
            // Ensure the sender is an IconButton before proceeding
            if (senderBtn is IconButton clickedBtn)
            {
                // First, reset the styles of the previously active button (if any)
                DisableButton();

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

        /// <summary>
        /// Resets the styling of the currently active button back to its normal state.
        /// </summary>
        private void DisableButton()
        {
            // Only proceed if there is an active button to reset
            if (currentBtn != null)
            {
                // Revert the current button's styling to normal
                currentBtn.BackColor = normalBgColor; // Revert background color
                currentBtn.ForeColor = normalTextColor; // Revert text color to white
                currentBtn.IconColor = normalTextColor; // Revert icon color to white

                // Revert the font style to regular
                currentBtn.Font = new Font(currentBtn.Font, FontStyle.Regular);

                // Important: If you want to use VisualStyles (e.g., system themes) for default appearance
                // for some buttons when they are not active, you might set this to true.
                // For a flat, custom-colored button, it's usually true already.
                currentBtn.UseVisualStyleBackColor = true;
            }
        }

        /// <summary>
        /// Iterates through all FontAwesome.Sharp.IconButton controls within 'panel1',
        /// attaches the 'ActivateButton' event handler to their Click event,
        /// and sets their initial styling to the normal (inactive) state.
        /// </summary>
        private void SetAllButtonsDefaultStateAndAttachEvents()
        {
            // Loop through each control present in 'panel1' (your sidebar/menu panel)
            foreach (Control control in panel1.Controls)
            {
                // Check if the control is an instance of FontAwesome.Sharp.IconButton
                if (control is IconButton btn)
                {
                    // Remove any existing MouseEnter event handler for 'ActiveButton'
                    // from the designer, as we want to use the Click event.
                    // This prevents the button from changing style on hover if it was set up that way.
                    btn.MouseEnter -= ActivateButton; // Remove the incorrect event handler if present

                    // Attach the 'ActivateButton' method to the 'Click' event of each button.
                    // This ensures our universal function is called when a button is clicked.
                    btn.Click += ActivateButton;

                    // Set the initial state of each button to its normal appearance
                    btn.BackColor = normalBgColor;
                    btn.ForeColor = normalTextColor;
                    btn.IconColor = normalTextColor;
                    btn.Font = new Font(btn.Font, FontStyle.Regular);
                    btn.UseVisualStyleBackColor = true; // Ensure custom BackColor is applied for flat styles
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminForm a1 = new AdminForm();
            a1.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Admin_ReceptionistForm r1 = new Admin_ReceptionistForm();
            r1.Show();
            this.Hide();
        }
    }
}
