namespace VehicleServiceCenter
{
    partial class SignUpCustomerForm
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
            SignBtn = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
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
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            AboutLbl = new Label();
            label6 = new Label();
            StartBtn = new Button();
            GenderLbl = new Label();
            DobLbl = new Label();
            EmailTxtBox = new TextBox();
            EmailLbl = new Label();
            PassTxtBox = new TextBox();
            PassLbl = new Label();
            UserNameTxtBox = new TextBox();
            UserNameLbl = new Label();
            LogBtn = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // SignBtn
            // 
            SignBtn.BackColor = Color.FromArgb(208, 206, 206);
            SignBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            SignBtn.ForeColor = Color.FromArgb(18, 18, 18);
            SignBtn.Location = new Point(59, 558);
            SignBtn.Margin = new Padding(3, 4, 3, 4);
            SignBtn.Name = "SignBtn";
            SignBtn.Size = new Size(114, 43);
            SignBtn.TabIndex = 0;
            SignBtn.Text = "SIGN UP";
            SignBtn.UseVisualStyleBackColor = false;
            SignBtn.Click += SignBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.car_maintenance_17073141;
            pictureBox1.Location = new Point(175, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 18, 18);
            panel1.Controls.Add(textBox_UserID);
            panel1.Controls.Add(label_userID);
            panel1.Controls.Add(DOBPicker);
            panel1.Controls.Add(BloodGroupComboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(PhoneTxtBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(OtherChk);
            panel1.Controls.Add(FemaleChk);
            panel1.Controls.Add(MaleChk);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(AboutLbl);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(StartBtn);
            panel1.Controls.Add(GenderLbl);
            panel1.Controls.Add(DobLbl);
            panel1.Controls.Add(EmailTxtBox);
            panel1.Controls.Add(EmailLbl);
            panel1.Controls.Add(PassTxtBox);
            panel1.Controls.Add(PassLbl);
            panel1.Controls.Add(UserNameTxtBox);
            panel1.Controls.Add(UserNameLbl);
            panel1.Controls.Add(LogBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(SignBtn);
            panel1.Dock = DockStyle.Right;
            panel1.ForeColor = Color.FromArgb(18, 18, 18);
            panel1.Location = new Point(681, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 701);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // textBox_UserID
            // 
            textBox_UserID.BackColor = Color.FromArgb(124, 124, 124);
            textBox_UserID.BorderStyle = BorderStyle.None;
            textBox_UserID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_UserID.ForeColor = SystemColors.InactiveBorder;
            textBox_UserID.Location = new Point(140, 127);
            textBox_UserID.Margin = new Padding(3, 4, 3, 4);
            textBox_UserID.Multiline = true;
            textBox_UserID.Name = "textBox_UserID";
            textBox_UserID.ReadOnly = true;
            textBox_UserID.Size = new Size(337, 40);
            textBox_UserID.TabIndex = 30;
            textBox_UserID.Text = "System Auto Generated";
            // 
            // label_userID
            // 
            label_userID.AutoSize = true;
            label_userID.Font = new Font("Cascadia Code", 10F);
            label_userID.ForeColor = Color.White;
            label_userID.Location = new Point(7, 129);
            label_userID.Name = "label_userID";
            label_userID.Size = new Size(80, 22);
            label_userID.TabIndex = 29;
            label_userID.Text = "USER ID";
            label_userID.Click += label3_Click;
            // 
            // DOBPicker
            // 
            DOBPicker.Location = new Point(140, 500);
            DOBPicker.Margin = new Padding(3, 4, 3, 4);
            DOBPicker.Name = "DOBPicker";
            DOBPicker.Size = new Size(285, 27);
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
            BloodGroupComboBox.Location = new Point(165, 443);
            BloodGroupComboBox.Margin = new Padding(3, 4, 3, 4);
            BloodGroupComboBox.Name = "BloodGroupComboBox";
            BloodGroupComboBox.Size = new Size(218, 36);
            BloodGroupComboBox.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 444);
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
            PhoneTxtBox.Location = new Point(140, 343);
            PhoneTxtBox.Margin = new Padding(3, 4, 3, 4);
            PhoneTxtBox.Multiline = true;
            PhoneTxtBox.Name = "PhoneTxtBox";
            PhoneTxtBox.Size = new Size(337, 36);
            PhoneTxtBox.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 343);
            label1.Name = "label1";
            label1.Size = new Size(90, 22);
            label1.TabIndex = 23;
            label1.Text = "PHONE NO";
            // 
            // OtherChk
            // 
            OtherChk.AutoSize = true;
            OtherChk.Font = new Font("Cascadia Code", 9F);
            OtherChk.ForeColor = Color.White;
            OtherChk.Location = new Point(363, 401);
            OtherChk.Margin = new Padding(3, 4, 3, 4);
            OtherChk.Name = "OtherChk";
            OtherChk.Size = new Size(76, 24);
            OtherChk.TabIndex = 22;
            OtherChk.Text = "OTHER";
            OtherChk.UseVisualStyleBackColor = true;
            // 
            // FemaleChk
            // 
            FemaleChk.AutoSize = true;
            FemaleChk.Font = new Font("Cascadia Code", 9F);
            FemaleChk.ForeColor = Color.White;
            FemaleChk.Location = new Point(241, 401);
            FemaleChk.Margin = new Padding(3, 4, 3, 4);
            FemaleChk.Name = "FemaleChk";
            FemaleChk.Size = new Size(85, 24);
            FemaleChk.TabIndex = 21;
            FemaleChk.Text = "FEMALE";
            FemaleChk.UseVisualStyleBackColor = true;
            // 
            // MaleChk
            // 
            MaleChk.AutoSize = true;
            MaleChk.Font = new Font("Cascadia Code", 9F);
            MaleChk.ForeColor = Color.White;
            MaleChk.Location = new Point(140, 401);
            MaleChk.Margin = new Padding(3, 4, 3, 4);
            MaleChk.Name = "MaleChk";
            MaleChk.Size = new Size(67, 24);
            MaleChk.TabIndex = 20;
            MaleChk.Text = "MALE";
            MaleChk.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_close_50;
            pictureBox4.Location = new Point(384, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_info_100;
            pictureBox3.Location = new Point(260, 672);
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
            AboutLbl.Location = new Point(165, 672);
            AboutLbl.Name = "AboutLbl";
            AboutLbl.Size = new Size(95, 20);
            AboutLbl.TabIndex = 17;
            AboutLbl.Text = "ABOUT US";
            AboutLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 16;
            label6.Text = "label6";
            // 
            // StartBtn
            // 
            StartBtn.BackColor = Color.FromArgb(208, 206, 206);
            StartBtn.Font = new Font("Microsoft Sans Serif", 13.8F);
            StartBtn.Location = new Point(95, 609);
            StartBtn.Margin = new Padding(3, 4, 3, 4);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(254, 43);
            StartBtn.TabIndex = 15;
            StartBtn.Text = "Let’s Start!";
            StartBtn.UseVisualStyleBackColor = false;
            StartBtn.Click += button3_Click;
            // 
            // GenderLbl
            // 
            GenderLbl.AutoSize = true;
            GenderLbl.Font = new Font("Cascadia Code", 10F);
            GenderLbl.ForeColor = Color.White;
            GenderLbl.Location = new Point(8, 399);
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
            DobLbl.Location = new Point(10, 505);
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
            EmailTxtBox.Location = new Point(140, 293);
            EmailTxtBox.Margin = new Padding(3, 4, 3, 4);
            EmailTxtBox.Multiline = true;
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.Size = new Size(295, 27);
            EmailTxtBox.TabIndex = 8;
            EmailTxtBox.TextChanged += EmailTxtBox_TextChanged;
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Font = new Font("Cascadia Code", 10F);
            EmailLbl.ForeColor = Color.White;
            EmailLbl.Location = new Point(7, 293);
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
            PassTxtBox.Location = new Point(140, 244);
            PassTxtBox.Margin = new Padding(3, 4, 3, 4);
            PassTxtBox.Multiline = true;
            PassTxtBox.Name = "PassTxtBox";
            PassTxtBox.Size = new Size(295, 27);
            PassTxtBox.TabIndex = 6;
            PassTxtBox.TextChanged += PassTxtBox_TextChanged;
            // 
            // PassLbl
            // 
            PassLbl.AutoSize = true;
            PassLbl.Font = new Font("Cascadia Code", 10F);
            PassLbl.ForeColor = Color.White;
            PassLbl.Location = new Point(2, 244);
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
            UserNameTxtBox.Location = new Point(140, 193);
            UserNameTxtBox.Margin = new Padding(3, 4, 3, 4);
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
            UserNameLbl.Location = new Point(7, 193);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new Size(100, 22);
            UserNameLbl.TabIndex = 3;
            UserNameLbl.Text = "USER NAME";
            UserNameLbl.Click += label1_Click;
            // 
            // LogBtn
            // 
            LogBtn.BackColor = Color.FromArgb(18, 18, 18);
            LogBtn.Font = new Font("Microsoft Sans Serif", 12F);
            LogBtn.ForeColor = Color.FromArgb(208, 206, 206);
            LogBtn.Location = new Point(269, 558);
            LogBtn.Margin = new Padding(3, 4, 3, 4);
            LogBtn.Name = "LogBtn";
            LogBtn.Size = new Size(114, 43);
            LogBtn.TabIndex = 2;
            LogBtn.Text = "LOG IN";
            LogBtn.UseVisualStyleBackColor = false;
            LogBtn.Click += LogBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.download_2;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(682, 701);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(682, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(441, 3);
            panel2.TabIndex = 19;
            // 
            // SignUpCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 701);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUpCustomerForm";
            Text = "LogIN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button SignBtn;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label PassLbl;
        private TextBox UserNameTxtBox;
        private Label UserNameLbl;
        private Button LogBtn;
        private Label DobLbl;
        private TextBox EmailTxtBox;
        private Label EmailLbl;
        private TextBox PassTxtBox;
        private Label GenderLbl;
        private Label AboutLbl;
        private Button StartBtn;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel2;
        private CheckBox OtherChk;
        private CheckBox FemaleChk;
        private CheckBox MaleChk;
        private Label label6;
        private TextBox PhoneTxtBox;
        private Label label1;
        private ComboBox BloodGroupComboBox;
        private Label label2;
        private DateTimePicker DOBPicker;
        private Label label_userID;
        private TextBox textBox_UserID;
    }
}