namespace VehicleServiceCenter
{
    partial class Admin_Profile_Edit
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
            panel1 = new Panel();
            panel2 = new Panel();
            SignBtn = new Button();
            textBox_UserID = new TextBox();
            label_userID = new Label();
            DOBPicker = new DateTimePicker();
            BloodGroupComboBox = new ComboBox();
            label2 = new Label();
            PhoneTxtBox = new TextBox();
            label1 = new Label();
            OtherChk = new CheckBox();
            FemaleChk = new CheckBox();
            MaleChk = new CheckBox();
            pictureBox3 = new PictureBox();
            AboutLbl = new Label();
            GenderLbl = new Label();
            DobLbl = new Label();
            EmailTxtBox = new TextBox();
            EmailLbl = new Label();
            PassTxtBox = new TextBox();
            PassLbl = new Label();
            UserNameTxtBox = new TextBox();
            UserNameLbl = new Label();
            profilePanel = new Panel();
            fullNameLabel = new Label();
            signOutPictureBox = new PictureBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signOutPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 18, 18);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 55);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 482);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 18, 18);
            panel2.Controls.Add(SignBtn);
            panel2.Controls.Add(textBox_UserID);
            panel2.Controls.Add(label_userID);
            panel2.Controls.Add(DOBPicker);
            panel2.Controls.Add(BloodGroupComboBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(PhoneTxtBox);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(OtherChk);
            panel2.Controls.Add(FemaleChk);
            panel2.Controls.Add(MaleChk);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(AboutLbl);
            panel2.Controls.Add(GenderLbl);
            panel2.Controls.Add(DobLbl);
            panel2.Controls.Add(EmailTxtBox);
            panel2.Controls.Add(EmailLbl);
            panel2.Controls.Add(PassTxtBox);
            panel2.Controls.Add(PassLbl);
            panel2.Controls.Add(UserNameTxtBox);
            panel2.Controls.Add(UserNameLbl);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.FromArgb(18, 18, 18);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(407, 482);
            panel2.TabIndex = 17;
            // 
            // SignBtn
            // 
            SignBtn.BackColor = Color.Transparent;
            SignBtn.FlatAppearance.BorderSize = 4;
            SignBtn.FlatStyle = FlatStyle.Flat;
            SignBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            SignBtn.ForeColor = SystemColors.ControlLightLight;
            SignBtn.Location = new Point(136, 429);
            SignBtn.Margin = new Padding(3, 2, 3, 2);
            SignBtn.Name = "SignBtn";
            SignBtn.Size = new Size(151, 42);
            SignBtn.TabIndex = 18;
            SignBtn.Text = "UPDATE";
            SignBtn.UseVisualStyleBackColor = false;
            // 
            // textBox_UserID
            // 
            textBox_UserID.BackColor = Color.FromArgb(124, 124, 124);
            textBox_UserID.BorderStyle = BorderStyle.None;
            textBox_UserID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_UserID.ForeColor = SystemColors.InactiveBorder;
            textBox_UserID.Location = new Point(115, 33);
            textBox_UserID.Margin = new Padding(3, 2, 3, 2);
            textBox_UserID.Multiline = true;
            textBox_UserID.Name = "textBox_UserID";
            textBox_UserID.ReadOnly = true;
            textBox_UserID.Size = new Size(258, 22);
            textBox_UserID.TabIndex = 30;
            textBox_UserID.Text = "System Auto Generated";
            // 
            // label_userID
            // 
            label_userID.AutoSize = true;
            label_userID.Font = new Font("Cascadia Code", 10F);
            label_userID.ForeColor = Color.White;
            label_userID.Location = new Point(14, 33);
            label_userID.Name = "label_userID";
            label_userID.Size = new Size(64, 18);
            label_userID.TabIndex = 29;
            label_userID.Text = "USER ID";
            // 
            // DOBPicker
            // 
            DOBPicker.Location = new Point(114, 384);
            DOBPicker.Margin = new Padding(3, 2, 3, 2);
            DOBPicker.Name = "DOBPicker";
            DOBPicker.Size = new Size(219, 23);
            DOBPicker.TabIndex = 28;
            // 
            // BloodGroupComboBox
            // 
            BloodGroupComboBox.AutoCompleteCustomSource.AddRange(new string[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O- " });
            BloodGroupComboBox.BackColor = SystemColors.WindowFrame;
            BloodGroupComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BloodGroupComboBox.ForeColor = SystemColors.ButtonHighlight;
            BloodGroupComboBox.FormattingEnabled = true;
            BloodGroupComboBox.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            BloodGroupComboBox.Location = new Point(115, 334);
            BloodGroupComboBox.Margin = new Padding(3, 2, 3, 2);
            BloodGroupComboBox.Name = "BloodGroupComboBox";
            BloodGroupComboBox.Size = new Size(104, 29);
            BloodGroupComboBox.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 335);
            label2.Name = "label2";
            label2.Size = new Size(96, 18);
            label2.TabIndex = 25;
            label2.Text = "BLOOD GROUP";
            // 
            // PhoneTxtBox
            // 
            PhoneTxtBox.BackColor = Color.FromArgb(124, 124, 124);
            PhoneTxtBox.BorderStyle = BorderStyle.None;
            PhoneTxtBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneTxtBox.ForeColor = SystemColors.InactiveBorder;
            PhoneTxtBox.Location = new Point(115, 245);
            PhoneTxtBox.Margin = new Padding(3, 2, 3, 2);
            PhoneTxtBox.Multiline = true;
            PhoneTxtBox.Name = "PhoneTxtBox";
            PhoneTxtBox.Size = new Size(258, 20);
            PhoneTxtBox.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 249);
            label1.Name = "label1";
            label1.Size = new Size(72, 18);
            label1.TabIndex = 23;
            label1.Text = "PHONE NO";
            // 
            // OtherChk
            // 
            OtherChk.AutoSize = true;
            OtherChk.Font = new Font("Cascadia Code", 9F);
            OtherChk.ForeColor = Color.White;
            OtherChk.Location = new Point(288, 294);
            OtherChk.Margin = new Padding(3, 2, 3, 2);
            OtherChk.Name = "OtherChk";
            OtherChk.Size = new Size(61, 20);
            OtherChk.TabIndex = 22;
            OtherChk.Text = "OTHER";
            OtherChk.UseVisualStyleBackColor = true;
            // 
            // FemaleChk
            // 
            FemaleChk.AutoSize = true;
            FemaleChk.Font = new Font("Cascadia Code", 9F);
            FemaleChk.ForeColor = Color.White;
            FemaleChk.Location = new Point(194, 294);
            FemaleChk.Margin = new Padding(3, 2, 3, 2);
            FemaleChk.Name = "FemaleChk";
            FemaleChk.Size = new Size(68, 20);
            FemaleChk.TabIndex = 21;
            FemaleChk.Text = "FEMALE";
            FemaleChk.UseVisualStyleBackColor = true;
            // 
            // MaleChk
            // 
            MaleChk.AutoSize = true;
            MaleChk.Font = new Font("Cascadia Code", 9F);
            MaleChk.ForeColor = Color.White;
            MaleChk.Location = new Point(117, 294);
            MaleChk.Margin = new Padding(3, 2, 3, 2);
            MaleChk.Name = "MaleChk";
            MaleChk.Size = new Size(54, 20);
            MaleChk.TabIndex = 20;
            MaleChk.Text = "MALE";
            MaleChk.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_info_100;
            pictureBox3.Location = new Point(212, 490);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(17, 16);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // AboutLbl
            // 
            AboutLbl.AutoSize = true;
            AboutLbl.Font = new Font("Microsoft Sans Serif", 10F);
            AboutLbl.ForeColor = Color.White;
            AboutLbl.Location = new Point(136, 490);
            AboutLbl.Name = "AboutLbl";
            AboutLbl.Size = new Size(79, 17);
            AboutLbl.TabIndex = 17;
            AboutLbl.Text = "ABOUT US";
            AboutLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // GenderLbl
            // 
            GenderLbl.AutoSize = true;
            GenderLbl.Font = new Font("Cascadia Code", 10F);
            GenderLbl.ForeColor = Color.White;
            GenderLbl.Location = new Point(16, 293);
            GenderLbl.Name = "GenderLbl";
            GenderLbl.Size = new Size(56, 18);
            GenderLbl.TabIndex = 13;
            GenderLbl.Text = "GENDER";
            // 
            // DobLbl
            // 
            DobLbl.AutoSize = true;
            DobLbl.Font = new Font("Cascadia Code", 10F);
            DobLbl.ForeColor = Color.White;
            DobLbl.Location = new Point(17, 384);
            DobLbl.Name = "DobLbl";
            DobLbl.Size = new Size(32, 18);
            DobLbl.TabIndex = 9;
            DobLbl.Text = "DOB";
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.BackColor = Color.FromArgb(124, 124, 124);
            EmailTxtBox.BorderStyle = BorderStyle.None;
            EmailTxtBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTxtBox.ForeColor = SystemColors.InactiveBorder;
            EmailTxtBox.Location = new Point(115, 193);
            EmailTxtBox.Margin = new Padding(3, 2, 3, 2);
            EmailTxtBox.Multiline = true;
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.Size = new Size(258, 20);
            EmailTxtBox.TabIndex = 8;
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Font = new Font("Cascadia Code", 10F);
            EmailLbl.ForeColor = Color.White;
            EmailLbl.Location = new Point(14, 195);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(56, 18);
            EmailLbl.TabIndex = 7;
            EmailLbl.Text = "E-MAIL";
            // 
            // PassTxtBox
            // 
            PassTxtBox.BackColor = Color.FromArgb(124, 124, 124);
            PassTxtBox.BorderStyle = BorderStyle.None;
            PassTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PassTxtBox.ForeColor = SystemColors.InactiveBorder;
            PassTxtBox.Location = new Point(115, 141);
            PassTxtBox.Margin = new Padding(3, 2, 3, 2);
            PassTxtBox.Multiline = true;
            PassTxtBox.Name = "PassTxtBox";
            PassTxtBox.Size = new Size(258, 20);
            PassTxtBox.TabIndex = 6;
            // 
            // PassLbl
            // 
            PassLbl.AutoSize = true;
            PassLbl.Font = new Font("Cascadia Code", 10F);
            PassLbl.ForeColor = Color.White;
            PassLbl.Location = new Point(14, 141);
            PassLbl.Name = "PassLbl";
            PassLbl.Size = new Size(72, 18);
            PassLbl.TabIndex = 5;
            PassLbl.Text = "PASSWORD";
            // 
            // UserNameTxtBox
            // 
            UserNameTxtBox.BackColor = Color.FromArgb(124, 124, 124);
            UserNameTxtBox.BorderStyle = BorderStyle.None;
            UserNameTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameTxtBox.ForeColor = SystemColors.InactiveBorder;
            UserNameTxtBox.Location = new Point(115, 87);
            UserNameTxtBox.Margin = new Padding(3, 2, 3, 2);
            UserNameTxtBox.Multiline = true;
            UserNameTxtBox.Name = "UserNameTxtBox";
            UserNameTxtBox.Size = new Size(258, 22);
            UserNameTxtBox.TabIndex = 4;
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.Font = new Font("Cascadia Code", 10F);
            UserNameLbl.ForeColor = Color.White;
            UserNameLbl.Location = new Point(14, 87);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new Size(80, 18);
            UserNameLbl.TabIndex = 3;
            UserNameLbl.Text = "USER NAME";
            // 
            // profilePanel
            // 
            profilePanel.BackColor = Color.FromArgb(38, 38, 38);
            profilePanel.Controls.Add(iconButton1);
            profilePanel.Controls.Add(fullNameLabel);
            profilePanel.Controls.Add(signOutPictureBox);
            profilePanel.Dock = DockStyle.Top;
            profilePanel.Location = new Point(0, 0);
            profilePanel.Margin = new Padding(0);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(407, 55);
            profilePanel.TabIndex = 8;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.BackColor = Color.Transparent;
            fullNameLabel.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameLabel.ForeColor = Color.WhiteSmoke;
            fullNameLabel.Location = new Point(152, 15);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(102, 28);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "FULL NAME";
            // 
            // signOutPictureBox
            // 
            signOutPictureBox.Image = Properties.Resources.icons8_sign_out_501;
            signOutPictureBox.Location = new Point(368, -1);
            signOutPictureBox.Name = "signOutPictureBox";
            signOutPictureBox.Size = new Size(31, 55);
            signOutPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            signOutPictureBox.TabIndex = 1;
            signOutPictureBox.TabStop = false;
            signOutPictureBox.Click += signOutPictureBox_Click;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.CircleChevronRight;
            iconButton1.IconColor = SystemColors.ControlLight;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(10, 8);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(39, 40);
            iconButton1.TabIndex = 31;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // Admin_Profile_Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 537);
            Controls.Add(panel1);
            Controls.Add(profilePanel);
            Name = "Admin_Profile_Edit";
            Text = "Admin_Profile_Edit";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signOutPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button SignBtn;
        private Panel panel2;
        private TextBox textBox_UserID;
        private Label label_userID;
        private DateTimePicker DOBPicker;
        private ComboBox BloodGroupComboBox;
        private Label label2;
        private TextBox PhoneTxtBox;
        private Label label1;
        private CheckBox OtherChk;
        private CheckBox FemaleChk;
        private CheckBox MaleChk;
        private PictureBox pictureBox3;
        private Label AboutLbl;
        private Label GenderLbl;
        private Label DobLbl;
        private TextBox EmailTxtBox;
        private Label EmailLbl;
        private TextBox PassTxtBox;
        private Label PassLbl;
        private TextBox UserNameTxtBox;
        private Label UserNameLbl;
        private Panel profilePanel;
        private Label fullNameLabel;
        private PictureBox signOutPictureBox;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}