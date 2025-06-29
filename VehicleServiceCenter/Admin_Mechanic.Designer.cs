namespace VehicleServiceCenter
{
    partial class Admin_Mechanic
    {
        /// <summary>
        
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Mechanic));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnHome = new FontAwesome.Sharp.IconButton();
            BtnReceptionist = new FontAwesome.Sharp.IconButton();
            btnCustomer = new FontAwesome.Sharp.IconButton();
            PanelProfile = new Panel();
            pictureBox21 = new PictureBox();
            label_type = new Label();
            label_full_name = new Label();
            pictureBox20 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            button_add = new Button();
            button_cancel = new Button();
            textBox_rating = new TextBox();
            label = new Label();
            comboBox_status = new ComboBox();
            label_status = new Label();
            label8 = new Label();
            BloodGroupComboBox = new ComboBox();
            radioButton_other = new RadioButton();
            radioButton_female = new RadioButton();
            radioButton_male = new RadioButton();
            textBox_email = new TextBox();
            textBox_userID = new TextBox();
            button4 = new Button();
            button3 = new Button();
            label5 = new Label();
            dateTimePicker_dob = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            textBox_password = new TextBox();
            label2 = new Label();
            UserNameTxtBox = new TextBox();
            label1 = new Label();
            lblUserID = new Label();
            dataGridView_mechic = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_mechic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 56, 56);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(BtnReceptionist);
            panel1.Controls.Add(btnCustomer);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 716);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.car_maintenance_17073141;
            pictureBox1.Location = new Point(39, 5);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            btnHome.IconColor = Color.White;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 32;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 104);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(200, 60);
            btnHome.TabIndex = 0;
            btnHome.Text = "HOME";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // BtnReceptionist
            // 
            BtnReceptionist.FlatAppearance.BorderSize = 0;
            BtnReceptionist.FlatStyle = FlatStyle.Flat;
            BtnReceptionist.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnReceptionist.ForeColor = Color.White;
            BtnReceptionist.IconChar = FontAwesome.Sharp.IconChar.Headset;
            BtnReceptionist.IconColor = Color.White;
            BtnReceptionist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnReceptionist.IconSize = 32;
            BtnReceptionist.ImageAlign = ContentAlignment.MiddleLeft;
            BtnReceptionist.Location = new Point(0, 229);
            BtnReceptionist.Margin = new Padding(0);
            BtnReceptionist.Name = "BtnReceptionist";
            BtnReceptionist.Size = new Size(200, 60);
            BtnReceptionist.TabIndex = 2;
            BtnReceptionist.Text = "RECEPTIONIST";
            BtnReceptionist.TextAlign = ContentAlignment.MiddleLeft;
            BtnReceptionist.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnReceptionist.UseVisualStyleBackColor = true;
            BtnReceptionist.Click += BtnReceptionist_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.IconChar = FontAwesome.Sharp.IconChar.User;
            btnCustomer.IconColor = Color.White;
            btnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCustomer.IconSize = 30;
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(0, 167);
            btnCustomer.Margin = new Padding(0);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(200, 60);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "CUSTOMER";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // PanelProfile
            // 
            PanelProfile.BackColor = Color.FromArgb(38, 38, 38);
            PanelProfile.Controls.Add(pictureBox21);
            PanelProfile.Controls.Add(label_type);
            PanelProfile.Controls.Add(label_full_name);
            PanelProfile.Controls.Add(pictureBox20);
            PanelProfile.Dock = DockStyle.Top;
            PanelProfile.Location = new Point(193, 0);
            PanelProfile.Margin = new Padding(0);
            PanelProfile.Name = "PanelProfile";
            PanelProfile.Size = new Size(959, 73);
            PanelProfile.TabIndex = 7;
            // 
            // pictureBox21
            // 
            pictureBox21.Image = (Image)resources.GetObject("pictureBox21.Image");
            pictureBox21.Location = new Point(725, -1);
            pictureBox21.Margin = new Padding(3, 4, 3, 4);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(35, 73);
            pictureBox21.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox21.TabIndex = 3;
            pictureBox21.TabStop = false;
            // 
            // label_type
            // 
            label_type.BackColor = Color.Transparent;
            label_type.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_type.ForeColor = Color.Gainsboro;
            label_type.Location = new Point(735, 37);
            label_type.Name = "label_type";
            label_type.Size = new Size(178, 35);
            label_type.TabIndex = 2;
            label_type.Text = "ADMIN";
            label_type.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_full_name
            // 
            label_full_name.AutoSize = true;
            label_full_name.BackColor = Color.Transparent;
            label_full_name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_full_name.ForeColor = Color.WhiteSmoke;
            label_full_name.Location = new Point(767, 9);
            label_full_name.Name = "label_full_name";
            label_full_name.Size = new Size(132, 25);
            label_full_name.TabIndex = 2;
            label_full_name.Text = "FULL NAME";
            // 
            // pictureBox20
            // 
            pictureBox20.Image = Properties.Resources.icons8_sign_out_501;
            pictureBox20.Location = new Point(919, 0);
            pictureBox20.Margin = new Padding(3, 4, 3, 4);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(32, 73);
            pictureBox20.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox20.TabIndex = 1;
            pictureBox20.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(18, 18, 18);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 326F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(dataGridView_mechic, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(193, 73);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(959, 643);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 18, 18);
            panel2.Controls.Add(button_add);
            panel2.Controls.Add(button_cancel);
            panel2.Controls.Add(textBox_rating);
            panel2.Controls.Add(label);
            panel2.Controls.Add(comboBox_status);
            panel2.Controls.Add(label_status);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(BloodGroupComboBox);
            panel2.Controls.Add(radioButton_other);
            panel2.Controls.Add(radioButton_female);
            panel2.Controls.Add(radioButton_male);
            panel2.Controls.Add(textBox_email);
            panel2.Controls.Add(textBox_userID);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dateTimePicker_dob);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox_password);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(UserNameTxtBox);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblUserID);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(633, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(326, 643);
            panel2.TabIndex = 3;
            // 
            // button_add
            // 
            button_add.BackColor = SystemColors.ControlLightLight;
            button_add.FlatAppearance.BorderSize = 0;
            button_add.FlatStyle = FlatStyle.Popup;
            button_add.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_add.ForeColor = Color.Green;
            button_add.Location = new Point(165, 520);
            button_add.Margin = new Padding(3, 4, 3, 4);
            button_add.Name = "button_add";
            button_add.Size = new Size(121, 48);
            button_add.TabIndex = 34;
            button_add.Text = "ADD NEW";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = SystemColors.ControlLightLight;
            button_cancel.FlatAppearance.BorderSize = 0;
            button_cancel.FlatStyle = FlatStyle.Popup;
            button_cancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_cancel.ForeColor = Color.Blue;
            button_cancel.Location = new Point(165, 454);
            button_cancel.Margin = new Padding(3, 4, 3, 4);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(121, 48);
            button_cancel.TabIndex = 33;
            button_cancel.Text = "CANCEL";
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click;
            // 
            // textBox_rating
            // 
            textBox_rating.BackColor = Color.FromArgb(124, 124, 124);
            textBox_rating.BorderStyle = BorderStyle.None;
            textBox_rating.Location = new Point(123, 401);
            textBox_rating.Multiline = true;
            textBox_rating.Name = "textBox_rating";
            textBox_rating.Size = new Size(183, 29);
            textBox_rating.TabIndex = 32;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.FlatStyle = FlatStyle.Flat;
            label.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.ControlLightLight;
            label.Location = new Point(7, 405);
            label.Name = "label";
            label.Size = new Size(92, 25);
            label.TabIndex = 31;
            label.Text = "RATING:";
            // 
            // comboBox_status
            // 
            comboBox_status.AutoCompleteCustomSource.AddRange(new string[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O- " });
            comboBox_status.BackColor = SystemColors.WindowFrame;
            comboBox_status.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_status.ForeColor = SystemColors.ButtonHighlight;
            comboBox_status.FormattingEnabled = true;
            comboBox_status.Items.AddRange(new object[] { "Available", "Busy", "On Leave" });
            comboBox_status.Location = new Point(123, 339);
            comboBox_status.Margin = new Padding(3, 4, 3, 4);
            comboBox_status.Name = "comboBox_status";
            comboBox_status.Size = new Size(171, 36);
            comboBox_status.TabIndex = 30;
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.BackColor = Color.Transparent;
            label_status.FlatStyle = FlatStyle.Flat;
            label_status.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_status.ForeColor = SystemColors.ControlLightLight;
            label_status.Location = new Point(7, 345);
            label_status.Name = "label_status";
            label_status.Size = new Size(100, 25);
            label_status.TabIndex = 29;
            label_status.Text = "STATUS:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 288);
            label8.Name = "label8";
            label8.Size = new Size(88, 25);
            label8.TabIndex = 28;
            label8.Text = "BLOOD:";
            // 
            // BloodGroupComboBox
            // 
            BloodGroupComboBox.AutoCompleteCustomSource.AddRange(new string[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O- " });
            BloodGroupComboBox.BackColor = SystemColors.WindowFrame;
            BloodGroupComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BloodGroupComboBox.ForeColor = SystemColors.ButtonHighlight;
            BloodGroupComboBox.FormattingEnabled = true;
            BloodGroupComboBox.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            BloodGroupComboBox.Location = new Point(123, 282);
            BloodGroupComboBox.Margin = new Padding(3, 4, 3, 4);
            BloodGroupComboBox.Name = "BloodGroupComboBox";
            BloodGroupComboBox.Size = new Size(171, 36);
            BloodGroupComboBox.TabIndex = 27;
            // 
            // radioButton_other
            // 
            radioButton_other.AutoSize = true;
            radioButton_other.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_other.ForeColor = Color.White;
            radioButton_other.Location = new Point(250, 192);
            radioButton_other.Name = "radioButton_other";
            radioButton_other.Size = new Size(76, 24);
            radioButton_other.TabIndex = 21;
            radioButton_other.TabStop = true;
            radioButton_other.Text = "OTHER";
            radioButton_other.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            radioButton_female.AutoSize = true;
            radioButton_female.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_female.ForeColor = Color.White;
            radioButton_female.Location = new Point(165, 192);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(85, 24);
            radioButton_female.TabIndex = 20;
            radioButton_female.TabStop = true;
            radioButton_female.Text = "FEMALE";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            radioButton_male.AutoSize = true;
            radioButton_male.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_male.ForeColor = Color.White;
            radioButton_male.Location = new Point(90, 187);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(69, 24);
            radioButton_male.TabIndex = 19;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "MALE";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // textBox_email
            // 
            textBox_email.BackColor = Color.FromArgb(124, 124, 124);
            textBox_email.BorderStyle = BorderStyle.None;
            textBox_email.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_email.ForeColor = Color.White;
            textBox_email.Location = new Point(78, 131);
            textBox_email.Multiline = true;
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(245, 29);
            textBox_email.TabIndex = 18;
            // 
            // textBox_userID
            // 
            textBox_userID.BackColor = Color.FromArgb(124, 124, 124);
            textBox_userID.BorderStyle = BorderStyle.None;
            textBox_userID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_userID.ForeColor = Color.White;
            textBox_userID.Location = new Point(78, 8);
            textBox_userID.Multiline = true;
            textBox_userID.Name = "textBox_userID";
            textBox_userID.ReadOnly = true;
            textBox_userID.Size = new Size(245, 29);
            textBox_userID.TabIndex = 17;
            textBox_userID.Text = "SYSTEM GENERATED";
            textBox_userID.TextAlign = HorizontalAlignment.Center;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(12, 520);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(121, 48);
            button4.TabIndex = 16;
            button4.Text = "DELETE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Green;
            button3.Location = new Point(12, 454);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(121, 48);
            button3.TabIndex = 16;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(7, 187);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 12;
            label5.Text = "GENDER:";
            // 
            // dateTimePicker_dob
            // 
            dateTimePicker_dob.Location = new Point(92, 235);
            dateTimePicker_dob.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker_dob.Name = "dateTimePicker_dob";
            dateTimePicker_dob.Size = new Size(228, 27);
            dateTimePicker_dob.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 235);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 10;
            label4.Text = "DOB:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(7, 129);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 8;
            label3.Text = "Email:";
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.FromArgb(124, 124, 124);
            textBox_password.BorderStyle = BorderStyle.None;
            textBox_password.Location = new Point(102, 90);
            textBox_password.Multiline = true;
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(218, 29);
            textBox_password.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(3, 94);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // UserNameTxtBox
            // 
            UserNameTxtBox.BackColor = Color.FromArgb(124, 124, 124);
            UserNameTxtBox.BorderStyle = BorderStyle.None;
            UserNameTxtBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameTxtBox.ForeColor = Color.White;
            UserNameTxtBox.Location = new Point(78, 47);
            UserNameTxtBox.Multiline = true;
            UserNameTxtBox.Name = "UserNameTxtBox";
            UserNameTxtBox.Size = new Size(245, 29);
            UserNameTxtBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 47);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.BackColor = Color.Transparent;
            lblUserID.FlatStyle = FlatStyle.Flat;
            lblUserID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = SystemColors.ControlLightLight;
            lblUserID.Location = new Point(0, 8);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(83, 25);
            lblUserID.TabIndex = 0;
            lblUserID.Text = "User ID:";
            // 
            // dataGridView_mechic
            // 
            dataGridView_mechic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_mechic.Dock = DockStyle.Fill;
            dataGridView_mechic.Location = new Point(0, 0);
            dataGridView_mechic.Margin = new Padding(0);
            dataGridView_mechic.Name = "dataGridView_mechic";
            dataGridView_mechic.RowHeadersWidth = 51;
            dataGridView_mechic.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_mechic.Size = new Size(633, 643);
            dataGridView_mechic.TabIndex = 0;
            // 
            // Admin_Mechanic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 716);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(PanelProfile);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin_Mechanic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Mechanic";
            Load += Admin_Mechanic_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelProfile.ResumeLayout(false);
            PanelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_mechic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton BtnReceptionist;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private Panel PanelProfile;
        private PictureBox pictureBox21;
        private Label label_type;
        private Label label_full_name;
        private PictureBox pictureBox20;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView_mechic;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Label label5;
        private DateTimePicker dateTimePicker_dob;
        private Label label4;
        private Label label3;
        private TextBox textBox_password;
        private Label label2;
        private TextBox UserNameTxtBox;
        private Label label1;
        private Label lblUserID;
        private TextBox textBox_email;
        private TextBox textBox_userID;
        private RadioButton radioButton_other;
        private RadioButton radioButton_female;
        private RadioButton radioButton_male;
        private ComboBox BloodGroupComboBox;
        private Label label_status;
        private Label label8;
        private ComboBox comboBox_status;
        private Label label;
        private TextBox textBox_rating;
        private Button button_add;
        private Button button_cancel;
    }
}