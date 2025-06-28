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
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
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
            pictureBox1 = new PictureBox();
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)settingsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)notificationPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signOutPictureBox).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            profilePanel.Size = new Size(1152, 73);
            profilePanel.TabIndex = 4;
            // 
            // settingsPictureBox
            // 
            settingsPictureBox.Image = Properties.Resources.car_maintenance_17073141;
            settingsPictureBox.Location = new Point(542, 0);
            settingsPictureBox.Margin = new Padding(3, 4, 3, 4);
            settingsPictureBox.Name = "settingsPictureBox";
            settingsPictureBox.Size = new Size(65, 73);
            settingsPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            settingsPictureBox.TabIndex = 3;
            settingsPictureBox.TabStop = false;
            // 
            // notificationPictureBox
            // 
            notificationPictureBox.Image = Properties.Resources.icons8_customer_64;
            notificationPictureBox.Location = new Point(886, 0);
            notificationPictureBox.Margin = new Padding(3, 4, 3, 4);
            notificationPictureBox.Name = "notificationPictureBox";
            notificationPictureBox.Size = new Size(35, 73);
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
            customerTypeLabel.Location = new Point(928, 40);
            customerTypeLabel.Name = "customerTypeLabel";
            customerTypeLabel.Size = new Size(95, 18);
            customerTypeLabel.TabIndex = 2;
            customerTypeLabel.Text = "CUSTOMER";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.BackColor = Color.Transparent;
            fullNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameLabel.ForeColor = Color.WhiteSmoke;
            fullNameLabel.Location = new Point(928, 12);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(132, 25);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "FULL NAME";
            // 
            // signOutPictureBox
            // 
            signOutPictureBox.Dock = DockStyle.Right;
            signOutPictureBox.Image = Properties.Resources.icons8_sign_out_501;
            signOutPictureBox.Location = new Point(1117, 0);
            signOutPictureBox.Margin = new Padding(3, 4, 3, 4);
            signOutPictureBox.Name = "signOutPictureBox";
            signOutPictureBox.Size = new Size(35, 73);
            signOutPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            signOutPictureBox.TabIndex = 1;
            signOutPictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(18, 18, 18);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 73);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 668);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(38, 38, 38);
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            iconButton3.IconColor = Color.Gainsboro;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 37;
            iconButton3.Location = new Point(534, 23);
            iconButton3.Margin = new Padding(3, 4, 3, 4);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(86, 52);
            iconButton3.TabIndex = 16;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(38, 38, 38);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Edit;
            iconButton2.IconColor = Color.Gainsboro;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 37;
            iconButton2.Location = new Point(659, 23);
            iconButton2.Margin = new Padding(3, 4, 3, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(86, 52);
            iconButton2.TabIndex = 16;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(38, 38, 38);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconButton1.IconColor = Color.Gainsboro;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 37;
            iconButton1.Location = new Point(408, 23);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(86, 52);
            iconButton1.TabIndex = 16;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(843, 213);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(3, 107);
            panel6.TabIndex = 10;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(854, 347);
            label4.Name = "label4";
            label4.Size = new Size(122, 31);
            label4.TabIndex = 15;
            label4.Text = "EXTEMITED TIME";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(843, 345);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(3, 69);
            panel5.TabIndex = 13;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightGreen;
            label6.Location = new Point(864, 371);
            label6.Name = "label6";
            label6.Size = new Size(176, 49);
            label6.TabIndex = 14;
            label6.Text = "4 days";
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 464);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1155, 493);
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
            label7.Location = new Point(429, 21);
            label7.Name = "label7";
            label7.Size = new Size(341, 39);
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
            label3.Location = new Point(854, 213);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
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
            label5.Location = new Point(854, 80);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 11;
            label5.Text = "CAR";
            label5.Click += label5_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 38, 38);
            panel3.Location = new Point(3, 441);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1143, 4);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(843, 79);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(3, 107);
            panel4.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(858, 237);
            label1.Name = "label1";
            label1.Size = new Size(199, 54);
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
            label2.Location = new Point(858, 104);
            label2.Name = "label2";
            label2.Size = new Size(132, 54);
            label2.TabIndex = 10;
            label2.Text = "Hilux";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(307, 119);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(537, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Customer_HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 716);
            Controls.Add(panel1);
            Controls.Add(profilePanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Customer_HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer_HomeForm";
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)settingsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)notificationPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)signOutPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}