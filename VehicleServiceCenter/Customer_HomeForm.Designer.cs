namespace VehicleServiceCenter
{
    partial class Customer_HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            profilePanel = new Panel();
            settingsPictureBox = new PictureBox();
            notificationPictureBox = new PictureBox();
            customerTypeLabel = new Label();
            fullNameLabel = new Label();
            signOutPictureBox = new PictureBox();
            panel1 = new Panel();
            label8 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            iconButton_payment = new FontAwesome.Sharp.IconButton();
            iconButton_book_appointment = new FontAwesome.Sharp.IconButton();
            iconButton_update_profile = new FontAwesome.Sharp.IconButton();
            iconButton_LogOut = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label3 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            label2 = new Label();
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)settingsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)notificationPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signOutPictureBox).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // profilePanel
            // 
            profilePanel.BackColor = Color.FromArgb(38, 38, 38);
            profilePanel.Controls.Add(settingsPictureBox);
            profilePanel.Controls.Add(notificationPictureBox);
            profilePanel.Controls.Add(customerTypeLabel);
            profilePanel.Controls.Add(fullNameLabel);
            profilePanel.Controls.Add(signOutPictureBox);
            profilePanel.Dock = DockStyle.Top;
            profilePanel.Location = new Point(0, 0);
            profilePanel.Margin = new Padding(0);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(1008, 55);
            profilePanel.TabIndex = 4;
            // 
            // settingsPictureBox
            // 
            settingsPictureBox.Image = Properties.Resources.car_maintenance_17073141;
            settingsPictureBox.Location = new Point(474, 0);
            settingsPictureBox.Name = "settingsPictureBox";
            settingsPictureBox.Size = new Size(57, 55);
            settingsPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            settingsPictureBox.TabIndex = 3;
            settingsPictureBox.TabStop = false;
            // 
            // notificationPictureBox
            // 
            notificationPictureBox.Image = Properties.Resources.icons8_customer_64;
            notificationPictureBox.Location = new Point(775, 0);
            notificationPictureBox.Name = "notificationPictureBox";
            notificationPictureBox.Size = new Size(31, 55);
            notificationPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            notificationPictureBox.TabIndex = 3;
            notificationPictureBox.TabStop = false;
            // 
            // customerTypeLabel
            // 
            customerTypeLabel.AutoSize = true;
            customerTypeLabel.BackColor = Color.Transparent;
            customerTypeLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerTypeLabel.ForeColor = Color.Gainsboro;
            customerTypeLabel.Location = new Point(812, 30);
            customerTypeLabel.Name = "customerTypeLabel";
            customerTypeLabel.Size = new Size(76, 15);
            customerTypeLabel.TabIndex = 2;
            customerTypeLabel.Text = "CUSTOMER";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.BackColor = Color.Transparent;
            fullNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameLabel.ForeColor = Color.WhiteSmoke;
            fullNameLabel.Location = new Point(812, 9);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(108, 20);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "FULL NAME";
            // 
            // signOutPictureBox
            // 
            signOutPictureBox.Cursor = Cursors.Hand;
            signOutPictureBox.Dock = DockStyle.Right;
            signOutPictureBox.Image = Properties.Resources.icons8_sign_out_501;
            signOutPictureBox.Location = new Point(977, 0);
            signOutPictureBox.Name = "signOutPictureBox";
            signOutPictureBox.Size = new Size(31, 55);
            signOutPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            signOutPictureBox.TabIndex = 1;
            signOutPictureBox.TabStop = false;
            signOutPictureBox.Click += signOutPictureBox_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(18, 18, 18);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(iconButton_payment);
            panel1.Controls.Add(iconButton_book_appointment);
            panel1.Controls.Add(iconButton_update_profile);
            panel1.Controls.Add(iconButton_LogOut);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 55);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 507);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(51, 139);
            label8.Name = "label8";
            label8.Size = new Size(149, 16);
            label8.TabIndex = 22;
            label8.Text = "ADD YOUR CAR INFOI!";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(61, 165);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(128, 39);
            iconButton1.TabIndex = 21;
            iconButton1.Text = "ADD CAR";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SPN_HLX_010040LG25B228870GR_comp_0041;
            pictureBox1.Location = new Point(241, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(491, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // iconButton_payment
            // 
            iconButton_payment.BackColor = Color.FromArgb(38, 38, 38);
            iconButton_payment.FlatAppearance.BorderSize = 0;
            iconButton_payment.FlatStyle = FlatStyle.Flat;
            iconButton_payment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton_payment.ForeColor = Color.White;
            iconButton_payment.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1;
            iconButton_payment.IconColor = Color.Gainsboro;
            iconButton_payment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_payment.IconSize = 37;
            iconButton_payment.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton_payment.Location = new Point(168, 178);
            iconButton_payment.Margin = new Padding(3, 2, 3, 2);
            iconButton_payment.Name = "iconButton_payment";
            iconButton_payment.Size = new Size(180, 66);
            iconButton_payment.TabIndex = 19;
            iconButton_payment.Text = "PAYMENT";
            iconButton_payment.TextAlign = ContentAlignment.MiddleRight;
            iconButton_payment.UseVisualStyleBackColor = false;
            // 
            // iconButton_book_appointment
            // 
            iconButton_book_appointment.BackColor = Color.FromArgb(38, 38, 38);
            iconButton_book_appointment.FlatAppearance.BorderSize = 0;
            iconButton_book_appointment.FlatStyle = FlatStyle.Flat;
            iconButton_book_appointment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton_book_appointment.ForeColor = Color.White;
            iconButton_book_appointment.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            iconButton_book_appointment.IconColor = Color.Gainsboro;
            iconButton_book_appointment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_book_appointment.IconSize = 37;
            iconButton_book_appointment.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton_book_appointment.Location = new Point(351, 180);
            iconButton_book_appointment.Margin = new Padding(3, 2, 3, 2);
            iconButton_book_appointment.Name = "iconButton_book_appointment";
            iconButton_book_appointment.Size = new Size(180, 64);
            iconButton_book_appointment.TabIndex = 18;
            iconButton_book_appointment.Text = "BOOK APPOINTMENT";
            iconButton_book_appointment.TextAlign = ContentAlignment.MiddleRight;
            iconButton_book_appointment.UseVisualStyleBackColor = false;
            iconButton_book_appointment.Click += iconButton_book_appointment_Click;
            // 
            // iconButton_update_profile
            // 
            iconButton_update_profile.BackColor = Color.FromArgb(38, 38, 38);
            iconButton_update_profile.FlatAppearance.BorderSize = 0;
            iconButton_update_profile.FlatStyle = FlatStyle.Flat;
            iconButton_update_profile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton_update_profile.ForeColor = Color.White;
            iconButton_update_profile.IconChar = FontAwesome.Sharp.IconChar.Edit;
            iconButton_update_profile.IconColor = Color.Gainsboro;
            iconButton_update_profile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_update_profile.IconSize = 37;
            iconButton_update_profile.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton_update_profile.Location = new Point(351, 112);
            iconButton_update_profile.Margin = new Padding(3, 2, 3, 2);
            iconButton_update_profile.Name = "iconButton_update_profile";
            iconButton_update_profile.Size = new Size(180, 64);
            iconButton_update_profile.TabIndex = 17;
            iconButton_update_profile.Text = "UPDATE PROFILE";
            iconButton_update_profile.TextAlign = ContentAlignment.MiddleRight;
            iconButton_update_profile.UseVisualStyleBackColor = false;
            iconButton_update_profile.Click += iconButton_update_profile_Click;
            // 
            // iconButton_LogOut
            // 
            iconButton_LogOut.BackColor = Color.FromArgb(38, 38, 38);
            iconButton_LogOut.FlatAppearance.BorderSize = 0;
            iconButton_LogOut.FlatStyle = FlatStyle.Flat;
            iconButton_LogOut.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton_LogOut.ForeColor = Color.White;
            iconButton_LogOut.IconChar = FontAwesome.Sharp.IconChar.House;
            iconButton_LogOut.IconColor = Color.Gainsboro;
            iconButton_LogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_LogOut.IconSize = 37;
            iconButton_LogOut.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton_LogOut.Location = new Point(168, 110);
            iconButton_LogOut.Margin = new Padding(3, 2, 3, 2);
            iconButton_LogOut.Name = "iconButton_LogOut";
            iconButton_LogOut.Size = new Size(180, 64);
            iconButton_LogOut.TabIndex = 16;
            iconButton_LogOut.Text = "LOG OUT";
            iconButton_LogOut.TextAlign = ContentAlignment.MiddleRight;
            iconButton_LogOut.UseVisualStyleBackColor = false;
            iconButton_LogOut.Click += iconButton1_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(738, 139);
            panel6.Name = "panel6";
            panel6.Size = new Size(3, 50);
            panel6.TabIndex = 10;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(747, 198);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 15;
            label4.Text = "EXTEMITED TIME";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(738, 197);
            panel5.Name = "panel5";
            panel5.Size = new Size(3, 50);
            panel5.TabIndex = 13;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightGreen;
            label6.Location = new Point(747, 221);
            label6.Name = "label6";
            label6.Size = new Size(154, 37);
            label6.TabIndex = 14;
            label6.Text = "4 days";
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Location = new Point(0, 258);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1025, 229);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(375, 16);
            label7.Name = "label7";
            label7.Size = new Size(273, 31);
            label7.TabIndex = 11;
            label7.Text = "ACTIVE SERVICES";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(747, 139);
            label3.Name = "label3";
            label3.Size = new Size(97, 16);
            label3.TabIndex = 11;
            label3.Text = "REPAIR COST";
            label3.Click += label5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(745, 52);
            label5.Name = "label5";
            label5.Size = new Size(35, 16);
            label5.TabIndex = 11;
            label5.Text = "CAR";
            label5.Click += label5_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 38, 38);
            panel3.Location = new Point(3, 331);
            panel3.Name = "panel3";
            panel3.Size = new Size(1000, 3);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(736, 57);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(3, 50);
            panel4.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(741, 152);
            label1.Name = "label1";
            label1.Size = new Size(141, 37);
            label1.TabIndex = 10;
            label1.Text = "Tk 9000";
            label1.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(741, 83);
            label2.Name = "label2";
            label2.Size = new Size(106, 42);
            label2.TabIndex = 10;
            label2.Text = "Hilux";
            label2.Click += label2_Click;
            // 
            // Customer_HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 537);
            Controls.Add(panel1);
            Controls.Add(profilePanel);
            Name = "Customer_HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer_HomeForm";
            Load += Customer_HomeForm_Load;
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)settingsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)notificationPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)signOutPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel profilePanel;
        private PictureBox settingsPictureBox;
        private PictureBox notificationPictureBox;
        private Label customerTypeLabel;
        private Label fullNameLabel;
        private PictureBox signOutPictureBox;
        private Panel panel1;
        private Label label5;
        private Panel panel4;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Panel panel5;
        private Label label6;
        private Label label3;
        private Panel panel3;
        private Label label1;
        private Panel panel6;
        private Label label7;
        private FontAwesome.Sharp.IconButton iconButton_LogOut;
        private FontAwesome.Sharp.IconButton iconButton_update_profile;
        private FontAwesome.Sharp.IconButton iconButton_book_appointment;
        private FontAwesome.Sharp.IconButton iconButton_payment;
    }
}