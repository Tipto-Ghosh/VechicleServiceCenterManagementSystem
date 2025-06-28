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
            button_update = new Button();
            radioButton_Other = new RadioButton();
            radioButton_famale = new RadioButton();
            radioButton_male = new RadioButton();
            textBox_email = new TextBox();
            textBox_pass = new TextBox();
            textBox_name = new TextBox();
            button_cancel = new Button();
            textBox_UserID = new TextBox();
            label_userID = new Label();
            DOBPicker = new DateTimePicker();
            BloodGroupComboBox = new ComboBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            AboutLbl = new Label();
            GenderLbl = new Label();
            DobLbl = new Label();
            EmailLbl = new Label();
            PassLbl = new Label();
            UserNameLbl = new Label();
            profilePanel = new Panel();
            iconButton_back = new FontAwesome.Sharp.IconButton();
            fullNameLabel = new Label();
            signOutPictureBox = new PictureBox();
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
            panel1.Location = new Point(0, 73);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 643);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 18, 18);
            panel2.Controls.Add(button_update);
            panel2.Controls.Add(radioButton_Other);
            panel2.Controls.Add(radioButton_famale);
            panel2.Controls.Add(radioButton_male);
            panel2.Controls.Add(textBox_email);
            panel2.Controls.Add(textBox_pass);
            panel2.Controls.Add(textBox_name);
            panel2.Controls.Add(button_cancel);
            panel2.Controls.Add(textBox_UserID);
            panel2.Controls.Add(label_userID);
            panel2.Controls.Add(DOBPicker);
            panel2.Controls.Add(BloodGroupComboBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(AboutLbl);
            panel2.Controls.Add(GenderLbl);
            panel2.Controls.Add(DobLbl);
            panel2.Controls.Add(EmailLbl);
            panel2.Controls.Add(PassLbl);
            panel2.Controls.Add(UserNameLbl);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.FromArgb(18, 18, 18);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(465, 643);
            panel2.TabIndex = 17;
            // 
            // button_update
            // 
            button_update.BackColor = Color.Transparent;
            button_update.FlatAppearance.BorderSize = 4;
            button_update.FlatStyle = FlatStyle.Flat;
            button_update.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button_update.ForeColor = SystemColors.ControlLightLight;
            button_update.Location = new Point(37, 538);
            button_update.Name = "button_update";
            button_update.Size = new Size(173, 56);
            button_update.TabIndex = 38;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // radioButton_Other
            // 
            radioButton_Other.AutoSize = true;
            radioButton_Other.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_Other.ForeColor = Color.White;
            radioButton_Other.Location = new Point(329, 327);
            radioButton_Other.Name = "radioButton_Other";
            radioButton_Other.Size = new Size(69, 24);
            radioButton_Other.TabIndex = 37;
            radioButton_Other.TabStop = true;
            radioButton_Other.Text = "Other";
            radioButton_Other.UseVisualStyleBackColor = true;
            // 
            // radioButton_famale
            // 
            radioButton_famale.AutoSize = true;
            radioButton_famale.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_famale.ForeColor = Color.White;
            radioButton_famale.Location = new Point(213, 327);
            radioButton_famale.Name = "radioButton_famale";
            radioButton_famale.Size = new Size(79, 24);
            radioButton_famale.TabIndex = 36;
            radioButton_famale.TabStop = true;
            radioButton_famale.Text = "Female";
            radioButton_famale.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            radioButton_male.AutoSize = true;
            radioButton_male.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_male.ForeColor = Color.White;
            radioButton_male.Location = new Point(115, 327);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(64, 24);
            radioButton_male.TabIndex = 35;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // textBox_email
            // 
            textBox_email.BackColor = Color.FromArgb(124, 124, 124);
            textBox_email.BorderStyle = BorderStyle.None;
            textBox_email.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_email.ForeColor = SystemColors.InactiveBorder;
            textBox_email.Location = new Point(131, 253);
            textBox_email.Multiline = true;
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(295, 29);
            textBox_email.TabIndex = 34;
            // 
            // textBox_pass
            // 
            textBox_pass.BackColor = Color.FromArgb(124, 124, 124);
            textBox_pass.BorderStyle = BorderStyle.None;
            textBox_pass.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_pass.ForeColor = SystemColors.InactiveBorder;
            textBox_pass.Location = new Point(131, 188);
            textBox_pass.Multiline = true;
            textBox_pass.Name = "textBox_pass";
            textBox_pass.Size = new Size(295, 29);
            textBox_pass.TabIndex = 33;
            // 
            // textBox_name
            // 
            textBox_name.BackColor = Color.FromArgb(124, 124, 124);
            textBox_name.BorderStyle = BorderStyle.None;
            textBox_name.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_name.ForeColor = SystemColors.InactiveBorder;
            textBox_name.Location = new Point(131, 116);
            textBox_name.Multiline = true;
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(295, 29);
            textBox_name.TabIndex = 32;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = Color.Transparent;
            button_cancel.FlatAppearance.BorderSize = 4;
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button_cancel.ForeColor = SystemColors.ControlLightLight;
            button_cancel.Location = new Point(242, 538);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(173, 56);
            button_cancel.TabIndex = 31;
            button_cancel.Text = "CANCEL";
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click;
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
            DOBPicker.Location = new Point(131, 465);
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
            BloodGroupComboBox.Location = new Point(174, 390);
            BloodGroupComboBox.Name = "BloodGroupComboBox";
            BloodGroupComboBox.Size = new Size(118, 36);
            BloodGroupComboBox.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 390);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 25;
            label2.Text = "BLOOD GROUP";
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
            GenderLbl.Location = new Point(19, 327);
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
            DobLbl.Location = new Point(37, 465);
            DobLbl.Name = "DobLbl";
            DobLbl.Size = new Size(40, 22);
            DobLbl.TabIndex = 9;
            DobLbl.Text = "DOB";
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
            profilePanel.Controls.Add(iconButton_back);
            profilePanel.Controls.Add(fullNameLabel);
            profilePanel.Controls.Add(signOutPictureBox);
            profilePanel.Dock = DockStyle.Top;
            profilePanel.Location = new Point(0, 0);
            profilePanel.Margin = new Padding(0);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(465, 73);
            profilePanel.TabIndex = 8;
            // 
            // iconButton_back
            // 
            iconButton_back.FlatAppearance.BorderSize = 0;
            iconButton_back.FlatStyle = FlatStyle.Flat;
            iconButton_back.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            iconButton_back.ForeColor = SystemColors.ControlLightLight;
            iconButton_back.IconChar = FontAwesome.Sharp.IconChar.CircleChevronRight;
            iconButton_back.IconColor = SystemColors.ControlLight;
            iconButton_back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_back.Location = new Point(11, 11);
            iconButton_back.Margin = new Padding(3, 4, 3, 4);
            iconButton_back.Name = "iconButton_back";
            iconButton_back.Size = new Size(45, 53);
            iconButton_back.TabIndex = 31;
            iconButton_back.UseVisualStyleBackColor = true;
            iconButton_back.Click += iconButton1_Click;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.BackColor = Color.Transparent;
            fullNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameLabel.ForeColor = Color.WhiteSmoke;
            fullNameLabel.Location = new Point(174, 20);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(123, 25);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "Update Info";
            // 
            // signOutPictureBox
            // 
            signOutPictureBox.Image = Properties.Resources.icons8_sign_out_501;
            signOutPictureBox.Location = new Point(421, -1);
            signOutPictureBox.Margin = new Padding(3, 4, 3, 4);
            signOutPictureBox.Name = "signOutPictureBox";
            signOutPictureBox.Size = new Size(35, 73);
            signOutPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            signOutPictureBox.TabIndex = 1;
            signOutPictureBox.TabStop = false;
            signOutPictureBox.Click += signOutPictureBox_Click;
            // 
            // Admin_Profile_Edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 716);
            Controls.Add(panel1);
            Controls.Add(profilePanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin_Profile_Edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Profile_Edit";
            Load += Admin_Profile_Edit_Load;
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
        private FontAwesome.Sharp.IconButton iconButton_back;
        private Button button_cancel;
        private TextBox textBox_email;
        private TextBox textBox_pass;
        private TextBox textBox_name;
        private RadioButton radioButton_Other;
        private RadioButton radioButton_famale;
        private RadioButton radioButton_male;
        private Button button_update;
    }
}