﻿namespace VehicleServiceCenter
{
    partial class Customer_Edit_Form
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
        private void InitializeComponent() {
            panel1 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            LogBtn = new Button();
            SignBtn = new Button();
            panel2 = new Panel();
            radioButton_Other = new RadioButton();
            radioButton_female = new RadioButton();
            radioButton_male = new RadioButton();
            textBox_UserID = new TextBox();
            label_userID = new Label();
            DOBPicker = new DateTimePicker();
            BloodGroupComboBox = new ComboBox();
            label2 = new Label();
            PhoneTxtBox = new TextBox();
            label1 = new Label();
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
            label5 = new Label();
            signOutPictureBox = new PictureBox();
            button_home = new Button();
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
            panel1.Controls.Add(button_home);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(LogBtn);
            panel1.Controls.Add(SignBtn);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 73);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 643);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Location = new Point(712, 125);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(229, 7);
            panel4.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(767, 93);
            label4.Name = "label4";
            label4.Size = new Size(130, 22);
            label4.TabIndex = 30;
            label4.Text = "ACCOUNT INFO";
            // 
            // LogBtn
            // 
            LogBtn.BackColor = Color.DarkRed;
            LogBtn.FlatAppearance.BorderSize = 4;
            LogBtn.FlatStyle = FlatStyle.Flat;
            LogBtn.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogBtn.ForeColor = SystemColors.Menu;
            LogBtn.Location = new Point(753, 308);
            LogBtn.Name = "LogBtn";
            LogBtn.Size = new Size(188, 98);
            LogBtn.TabIndex = 19;
            LogBtn.Text = "DELETE ACCOUNT";
            LogBtn.UseVisualStyleBackColor = false;
            LogBtn.Click += LogBtn_Click;
            // 
            // SignBtn
            // 
            SignBtn.BackColor = Color.Transparent;
            SignBtn.FlatAppearance.BorderSize = 4;
            SignBtn.FlatStyle = FlatStyle.Flat;
            SignBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            SignBtn.ForeColor = SystemColors.ControlLightLight;
            SignBtn.Location = new Point(753, 187);
            SignBtn.Name = "SignBtn";
            SignBtn.Size = new Size(188, 94);
            SignBtn.TabIndex = 18;
            SignBtn.Text = "UPDATE";
            SignBtn.UseVisualStyleBackColor = false;
            SignBtn.Click += SignBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 18, 18);
            panel2.Controls.Add(radioButton_Other);
            panel2.Controls.Add(radioButton_female);
            panel2.Controls.Add(radioButton_male);
            panel2.Controls.Add(textBox_UserID);
            panel2.Controls.Add(label_userID);
            panel2.Controls.Add(DOBPicker);
            panel2.Controls.Add(BloodGroupComboBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(PhoneTxtBox);
            panel2.Controls.Add(label1);
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
            panel2.ForeColor = Color.FromArgb(18, 18, 18);
            panel2.Location = new Point(69, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 569);
            panel2.TabIndex = 17;
            // 
            // radioButton_Other
            // 
            radioButton_Other.AutoSize = true;
            radioButton_Other.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_Other.ForeColor = Color.White;
            radioButton_Other.Location = new Point(311, 391);
            radioButton_Other.Name = "radioButton_Other";
            radioButton_Other.Size = new Size(69, 24);
            radioButton_Other.TabIndex = 38;
            radioButton_Other.TabStop = true;
            radioButton_Other.Text = "Other";
            radioButton_Other.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            radioButton_female.AutoSize = true;
            radioButton_female.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_female.ForeColor = Color.White;
            radioButton_female.Location = new Point(217, 391);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(79, 24);
            radioButton_female.TabIndex = 37;
            radioButton_female.TabStop = true;
            radioButton_female.Text = "Female";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            radioButton_male.AutoSize = true;
            radioButton_male.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_male.ForeColor = Color.White;
            radioButton_male.Location = new Point(118, 391);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(64, 24);
            radioButton_male.TabIndex = 36;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // textBox_UserID
            // 
            textBox_UserID.BackColor = Color.FromArgb(124, 124, 124);
            textBox_UserID.BorderStyle = BorderStyle.None;
            textBox_UserID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_UserID.ForeColor = SystemColors.InactiveBorder;
            textBox_UserID.Location = new Point(131, 44);
            textBox_UserID.Multiline = true;
            textBox_UserID.Name = "textBox_UserID";
            textBox_UserID.ReadOnly = true;
            textBox_UserID.Size = new Size(295, 29);
            textBox_UserID.TabIndex = 30;
            textBox_UserID.Text = "System Auto Generated";
            // 
            // label_userID
            // 
            label_userID.AutoSize = true;
            label_userID.Font = new Font("Cascadia Code", 10F);
            label_userID.ForeColor = Color.White;
            label_userID.Location = new Point(16, 44);
            label_userID.Name = "label_userID";
            label_userID.Size = new Size(80, 22);
            label_userID.TabIndex = 29;
            label_userID.Text = "USER ID";
            // 
            // DOBPicker
            // 
            DOBPicker.Location = new Point(130, 512);
            DOBPicker.Name = "DOBPicker";
            DOBPicker.Size = new Size(250, 27);
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
            BloodGroupComboBox.Location = new Point(155, 447);
            BloodGroupComboBox.Name = "BloodGroupComboBox";
            BloodGroupComboBox.Size = new Size(118, 36);
            BloodGroupComboBox.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 455);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 25;
            label2.Text = "BLOOD GROUP";
            // 
            // PhoneTxtBox
            // 
            PhoneTxtBox.BackColor = Color.FromArgb(124, 124, 124);
            PhoneTxtBox.BorderStyle = BorderStyle.None;
            PhoneTxtBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneTxtBox.ForeColor = SystemColors.InactiveBorder;
            PhoneTxtBox.Location = new Point(131, 327);
            PhoneTxtBox.Multiline = true;
            PhoneTxtBox.Name = "PhoneTxtBox";
            PhoneTxtBox.Size = new Size(295, 27);
            PhoneTxtBox.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 332);
            label1.Name = "label1";
            label1.Size = new Size(90, 22);
            label1.TabIndex = 23;
            label1.Text = "PHONE NO";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_info_100;
            pictureBox3.Location = new Point(242, 653);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // AboutLbl
            // 
            AboutLbl.AutoSize = true;
            AboutLbl.Font = new Font("Microsoft Sans Serif", 10F);
            AboutLbl.ForeColor = Color.White;
            AboutLbl.Location = new Point(155, 653);
            AboutLbl.Name = "AboutLbl";
            AboutLbl.Size = new Size(95, 20);
            AboutLbl.TabIndex = 17;
            AboutLbl.Text = "ABOUT US";
            AboutLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // GenderLbl
            // 
            GenderLbl.AutoSize = true;
            GenderLbl.Font = new Font("Cascadia Code", 10F);
            GenderLbl.ForeColor = Color.White;
            GenderLbl.Location = new Point(18, 391);
            GenderLbl.Name = "GenderLbl";
            GenderLbl.Size = new Size(70, 22);
            GenderLbl.TabIndex = 13;
            GenderLbl.Text = "GENDER";
            // 
            // DobLbl
            // 
            DobLbl.AutoSize = true;
            DobLbl.Font = new Font("Cascadia Code", 10F);
            DobLbl.ForeColor = Color.White;
            DobLbl.Location = new Point(19, 512);
            DobLbl.Name = "DobLbl";
            DobLbl.Size = new Size(40, 22);
            DobLbl.TabIndex = 9;
            DobLbl.Text = "DOB";
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.BackColor = Color.FromArgb(124, 124, 124);
            EmailTxtBox.BorderStyle = BorderStyle.None;
            EmailTxtBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTxtBox.ForeColor = SystemColors.InactiveBorder;
            EmailTxtBox.Location = new Point(131, 257);
            EmailTxtBox.Multiline = true;
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.Size = new Size(295, 27);
            EmailTxtBox.TabIndex = 8;
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Font = new Font("Cascadia Code", 10F);
            EmailLbl.ForeColor = Color.White;
            EmailLbl.Location = new Point(16, 260);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(70, 22);
            EmailLbl.TabIndex = 7;
            EmailLbl.Text = "E-MAIL";
            // 
            // PassTxtBox
            // 
            PassTxtBox.BackColor = Color.FromArgb(124, 124, 124);
            PassTxtBox.BorderStyle = BorderStyle.None;
            PassTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PassTxtBox.ForeColor = SystemColors.InactiveBorder;
            PassTxtBox.Location = new Point(131, 188);
            PassTxtBox.Multiline = true;
            PassTxtBox.Name = "PassTxtBox";
            PassTxtBox.Size = new Size(295, 27);
            PassTxtBox.TabIndex = 6;
            // 
            // PassLbl
            // 
            PassLbl.AutoSize = true;
            PassLbl.Font = new Font("Cascadia Code", 10F);
            PassLbl.ForeColor = Color.White;
            PassLbl.Location = new Point(16, 188);
            PassLbl.Name = "PassLbl";
            PassLbl.Size = new Size(90, 22);
            PassLbl.TabIndex = 5;
            PassLbl.Text = "PASSWORD";
            // 
            // UserNameTxtBox
            // 
            UserNameTxtBox.BackColor = Color.FromArgb(124, 124, 124);
            UserNameTxtBox.BorderStyle = BorderStyle.None;
            UserNameTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameTxtBox.ForeColor = SystemColors.InactiveBorder;
            UserNameTxtBox.Location = new Point(131, 116);
            UserNameTxtBox.Multiline = true;
            UserNameTxtBox.Name = "UserNameTxtBox";
            UserNameTxtBox.Size = new Size(295, 29);
            UserNameTxtBox.TabIndex = 4;
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.Font = new Font("Cascadia Code", 10F);
            UserNameLbl.ForeColor = Color.White;
            UserNameLbl.Location = new Point(16, 116);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new Size(100, 22);
            UserNameLbl.TabIndex = 3;
            UserNameLbl.Text = "USER NAME";
            // 
            // profilePanel
            // 
            profilePanel.BackColor = Color.FromArgb(38, 38, 38);
            profilePanel.Controls.Add(label5);
            profilePanel.Controls.Add(signOutPictureBox);
            profilePanel.Dock = DockStyle.Top;
            profilePanel.Location = new Point(0, 0);
            profilePanel.Margin = new Padding(0);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(1152, 73);
            profilePanel.TabIndex = 6;
            // 
            // label5
            // 
            label5.Font = new Font("Cascadia Code SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(343, 9);
            label5.Name = "label5";
            label5.Size = new Size(466, 54);
            label5.TabIndex = 4;
            label5.Text = "UPDATE PROFILE INFORMATION";
            label5.TextAlign = ContentAlignment.MiddleCenter;
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
            // button_home
            // 
            button_home.BackColor = Color.Transparent;
            button_home.FlatAppearance.BorderSize = 4;
            button_home.FlatStyle = FlatStyle.Flat;
            button_home.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button_home.ForeColor = SystemColors.ControlLightLight;
            button_home.Location = new Point(753, 441);
            button_home.Name = "button_home";
            button_home.Size = new Size(188, 94);
            button_home.TabIndex = 32;
            button_home.Text = "Home";
            button_home.UseVisualStyleBackColor = false;
            button_home.Click += button_home_Click;
            // 
            // Customer_Edit_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1152, 716);
            Controls.Add(panel1);
            Controls.Add(profilePanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Customer_Edit_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer_Edit_Form";
            Load += Customer_Edit_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            profilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)signOutPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel profilePanel;
        private PictureBox signOutPictureBox;
        private Panel panel2;
        private DateTimePicker DOBPicker;
        private ComboBox BloodGroupComboBox;
        private Label label2;
        private PictureBox pictureBox3;
        private Label AboutLbl;
        private Label GenderLbl;
        private Label DobLbl;
        private TextBox textBox_UserID;
        private Label label_userID;
        private TextBox PhoneTxtBox;
        private Label label1;
        private TextBox EmailTxtBox;
        private Label EmailLbl;
        private TextBox PassTxtBox;
        private Label PassLbl;
        private TextBox UserNameTxtBox;
        private Label UserNameLbl;
        private Button LogBtn;
        private Button SignBtn;
        private Label label4;
        private Panel panel4;
        private Label label5;
        private RadioButton radioButton_male;
        private RadioButton radioButton_female;
        private RadioButton radioButton_Other;
        private Button button_home;
    }
}