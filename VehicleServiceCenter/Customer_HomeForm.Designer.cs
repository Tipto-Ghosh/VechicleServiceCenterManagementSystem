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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_HomeForm));
            profilePanel = new Panel();
            settingsPictureBox = new PictureBox();
            notificationPictureBox = new PictureBox();
            customerTypeLabel = new Label();
            fullNameLabel = new Label();
            signOutPictureBox = new PictureBox();
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)settingsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)notificationPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signOutPictureBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            customerTypeLabel.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerTypeLabel.ForeColor = Color.Gainsboro;
            customerTypeLabel.Location = new Point(812, 30);
            customerTypeLabel.Name = "customerTypeLabel";
            customerTypeLabel.Size = new Size(72, 22);
            customerTypeLabel.TabIndex = 2;
            customerTypeLabel.Text = "CUSTOMER";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.BackColor = Color.Transparent;
            fullNameLabel.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameLabel.ForeColor = Color.WhiteSmoke;
            fullNameLabel.Location = new Point(812, 9);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(102, 28);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "FULL NAME";
            // 
            // signOutPictureBox
            // 
            signOutPictureBox.Dock = DockStyle.Right;
            signOutPictureBox.Image = Properties.Resources.icons8_sign_out_501;
            signOutPictureBox.Location = new Point(977, 0);
            signOutPictureBox.Name = "signOutPictureBox";
            signOutPictureBox.Size = new Size(31, 55);
            signOutPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            signOutPictureBox.TabIndex = 1;
            signOutPictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 18, 18);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 482);
            panel1.TabIndex = 5;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderColor = Color.Cornsilk;
            iconButton1.FlatAppearance.BorderSize = 20;
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = SystemColors.ControlLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.NotEqual;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(397, 436);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(105, 34);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "about us";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(470, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(558, 145);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 11;
            label5.Text = "CUSTOMER";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(549, 149);
            panel4.Name = "panel4";
            panel4.Size = new Size(3, 80);
            panel4.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Poppins", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(545, 149);
            label2.Name = "label2";
            label2.Size = new Size(130, 113);
            label2.TabIndex = 10;
            label2.Text = "00";
            // 
            // Customer_HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 537);
            Controls.Add(panel1);
            Controls.Add(profilePanel);
            Name = "Customer_HomeForm";
            Text = "Customer_HomeForm";
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)settingsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)notificationPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)signOutPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label5;
        private Panel panel4;
        private Label label2;
    }
}