namespace VehicleServiceCenter
{
    partial class Admin_ReceptionistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_ReceptionistForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnHome = new FontAwesome.Sharp.IconButton();
            BtnReceptionist = new FontAwesome.Sharp.IconButton();
            btnMechanic = new FontAwesome.Sharp.IconButton();
            btnCustomer = new FontAwesome.Sharp.IconButton();
            btnAdmin = new FontAwesome.Sharp.IconButton();
            PanelProfile = new Panel();
            pictureBox21 = new PictureBox();
            label_role = new Label();
            label_admin_name = new Label();
            pictureBox20 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            button_add_new = new Button();
            radioButton_night = new RadioButton();
            radioButton_noon = new RadioButton();
            radioButton_morning = new RadioButton();
            comboBox_blood = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            textBox_UserID = new TextBox();
            button_delete = new Button();
            button_update = new Button();
            checkedListBox_gender = new CheckedListBox();
            label5 = new Label();
            dateTimePicker_dob = new DateTimePicker();
            label4 = new Label();
            textBox_email = new TextBox();
            label3 = new Label();
            textBox_password = new TextBox();
            label2 = new Label();
            UserNameTxtBox = new TextBox();
            label1 = new Label();
            lblUserID = new Label();
            dataGridView_Reps = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Reps).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 56, 56);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(BtnReceptionist);
            panel1.Controls.Add(btnMechanic);
            panel1.Controls.Add(btnCustomer);
            panel1.Controls.Add(btnAdmin);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 716);
            panel1.TabIndex = 2;
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
            btnHome.Size = new Size(193, 60);
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
            BtnReceptionist.Size = new Size(193, 60);
            BtnReceptionist.TabIndex = 2;
            BtnReceptionist.Text = "RECEPTIONIST";
            BtnReceptionist.TextAlign = ContentAlignment.MiddleLeft;
            BtnReceptionist.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnReceptionist.UseVisualStyleBackColor = true;
            BtnReceptionist.Click += BtnReceptionist_Click;
            // 
            // btnMechanic
            // 
            btnMechanic.FlatAppearance.BorderSize = 0;
            btnMechanic.FlatStyle = FlatStyle.Flat;
            btnMechanic.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnMechanic.ForeColor = Color.White;
            btnMechanic.IconChar = FontAwesome.Sharp.IconChar.Hammer;
            btnMechanic.IconColor = Color.White;
            btnMechanic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMechanic.IconSize = 32;
            btnMechanic.ImageAlign = ContentAlignment.MiddleLeft;
            btnMechanic.Location = new Point(0, 292);
            btnMechanic.Margin = new Padding(3, 4, 3, 4);
            btnMechanic.Name = "btnMechanic";
            btnMechanic.Size = new Size(193, 60);
            btnMechanic.TabIndex = 3;
            btnMechanic.Text = "MECHANIC";
            btnMechanic.TextAlign = ContentAlignment.MiddleLeft;
            btnMechanic.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMechanic.UseVisualStyleBackColor = true;
            btnMechanic.Click += btnMechanic_Click;
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
            btnCustomer.Size = new Size(193, 60);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "CUSTOMER";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            btnAdmin.IconColor = Color.White;
            btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmin.IconSize = 32;
            btnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmin.Location = new Point(0, 355);
            btnAdmin.Margin = new Padding(0);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(193, 60);
            btnAdmin.TabIndex = 4;
            btnAdmin.Text = "INVENTORY";
            btnAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // PanelProfile
            // 
            PanelProfile.BackColor = Color.FromArgb(38, 38, 38);
            PanelProfile.Controls.Add(pictureBox21);
            PanelProfile.Controls.Add(label_role);
            PanelProfile.Controls.Add(label_admin_name);
            PanelProfile.Controls.Add(pictureBox20);
            PanelProfile.Dock = DockStyle.Top;
            PanelProfile.Location = new Point(193, 0);
            PanelProfile.Margin = new Padding(0);
            PanelProfile.Name = "PanelProfile";
            PanelProfile.Size = new Size(959, 73);
            PanelProfile.TabIndex = 6;
            // 
            // pictureBox21
            // 
            pictureBox21.Image = (Image)resources.GetObject("pictureBox21.Image");
            pictureBox21.Location = new Point(693, 0);
            pictureBox21.Margin = new Padding(3, 4, 3, 4);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(35, 73);
            pictureBox21.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox21.TabIndex = 3;
            pictureBox21.TabStop = false;
            // 
            // label_role
            // 
            label_role.AutoSize = true;
            label_role.BackColor = Color.Transparent;
            label_role.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_role.ForeColor = Color.Gainsboro;
            label_role.Location = new Point(735, 40);
            label_role.Name = "label_role";
            label_role.Size = new Size(55, 18);
            label_role.TabIndex = 2;
            label_role.Text = "ADMIN";
            // 
            // label_admin_name
            // 
            label_admin_name.AutoSize = true;
            label_admin_name.BackColor = Color.Transparent;
            label_admin_name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_admin_name.ForeColor = Color.WhiteSmoke;
            label_admin_name.Location = new Point(735, 12);
            label_admin_name.Name = "label_admin_name";
            label_admin_name.Size = new Size(132, 25);
            label_admin_name.TabIndex = 2;
            label_admin_name.Text = "FULL NAME";
            label_admin_name.Click += label_admin_name_Click;
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
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 326F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(dataGridView_Reps, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(193, 73);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(959, 643);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 18, 18);
            panel2.Controls.Add(button_add_new);
            panel2.Controls.Add(radioButton_night);
            panel2.Controls.Add(radioButton_noon);
            panel2.Controls.Add(radioButton_morning);
            panel2.Controls.Add(comboBox_blood);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox_UserID);
            panel2.Controls.Add(button_delete);
            panel2.Controls.Add(button_update);
            panel2.Controls.Add(checkedListBox_gender);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dateTimePicker_dob);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox_email);
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
            panel2.TabIndex = 2;
            // 
            // button_add_new
            // 
            button_add_new.BackColor = SystemColors.ControlLightLight;
            button_add_new.FlatAppearance.BorderSize = 0;
            button_add_new.FlatStyle = FlatStyle.Popup;
            button_add_new.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add_new.ForeColor = Color.Lime;
            button_add_new.Location = new Point(94, 569);
            button_add_new.Margin = new Padding(3, 4, 3, 4);
            button_add_new.Name = "button_add_new";
            button_add_new.Size = new Size(121, 48);
            button_add_new.TabIndex = 26;
            button_add_new.Text = "ADD NEW";
            button_add_new.UseVisualStyleBackColor = false;
            button_add_new.Click += button_add_new_Click;
            // 
            // radioButton_night
            // 
            radioButton_night.AutoSize = true;
            radioButton_night.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_night.ForeColor = Color.White;
            radioButton_night.Location = new Point(254, 445);
            radioButton_night.Name = "radioButton_night";
            radioButton_night.Size = new Size(69, 24);
            radioButton_night.TabIndex = 25;
            radioButton_night.TabStop = true;
            radioButton_night.Text = "Night";
            radioButton_night.UseVisualStyleBackColor = true;
            // 
            // radioButton_noon
            // 
            radioButton_noon.AutoSize = true;
            radioButton_noon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_noon.ForeColor = Color.White;
            radioButton_noon.Location = new Point(181, 445);
            radioButton_noon.Name = "radioButton_noon";
            radioButton_noon.Size = new Size(69, 24);
            radioButton_noon.TabIndex = 24;
            radioButton_noon.TabStop = true;
            radioButton_noon.Text = "Noon";
            radioButton_noon.UseVisualStyleBackColor = true;
            // 
            // radioButton_morning
            // 
            radioButton_morning.AutoSize = true;
            radioButton_morning.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_morning.ForeColor = Color.White;
            radioButton_morning.Location = new Point(94, 445);
            radioButton_morning.Name = "radioButton_morning";
            radioButton_morning.Size = new Size(90, 24);
            radioButton_morning.TabIndex = 23;
            radioButton_morning.TabStop = true;
            radioButton_morning.Text = "Morning";
            radioButton_morning.UseVisualStyleBackColor = true;
            // 
            // comboBox_blood
            // 
            comboBox_blood.FormattingEnabled = true;
            comboBox_blood.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            comboBox_blood.Location = new Point(150, 381);
            comboBox_blood.Name = "comboBox_blood";
            comboBox_blood.Size = new Size(151, 28);
            comboBox_blood.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(19, 384);
            label9.Name = "label9";
            label9.Size = new Size(88, 25);
            label9.TabIndex = 21;
            label9.Text = "BLOOD:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(11, 444);
            label8.Name = "label8";
            label8.Size = new Size(76, 25);
            label8.TabIndex = 19;
            label8.Text = "SHIFT:";
            // 
            // textBox_UserID
            // 
            textBox_UserID.BackColor = Color.FromArgb(124, 124, 124);
            textBox_UserID.BorderStyle = BorderStyle.None;
            textBox_UserID.ForeColor = SystemColors.InactiveBorder;
            textBox_UserID.Location = new Point(88, 8);
            textBox_UserID.Multiline = true;
            textBox_UserID.Name = "textBox_UserID";
            textBox_UserID.ReadOnly = true;
            textBox_UserID.Size = new Size(234, 29);
            textBox_UserID.TabIndex = 18;
            // 
            // button_delete
            // 
            button_delete.BackColor = SystemColors.ControlLightLight;
            button_delete.FlatAppearance.BorderSize = 0;
            button_delete.FlatStyle = FlatStyle.Popup;
            button_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = Color.Red;
            button_delete.Location = new Point(181, 501);
            button_delete.Margin = new Padding(3, 4, 3, 4);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(121, 48);
            button_delete.TabIndex = 16;
            button_delete.Text = "DELETE";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.BackColor = SystemColors.ControlLightLight;
            button_update.FlatAppearance.BorderSize = 0;
            button_update.FlatStyle = FlatStyle.Popup;
            button_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_update.ForeColor = Color.Green;
            button_update.Location = new Point(7, 501);
            button_update.Margin = new Padding(3, 4, 3, 4);
            button_update.Name = "button_update";
            button_update.Size = new Size(121, 48);
            button_update.TabIndex = 16;
            button_update.Text = "UPDATE";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // checkedListBox_gender
            // 
            checkedListBox_gender.BackColor = Color.FromArgb(18, 18, 18);
            checkedListBox_gender.BorderStyle = BorderStyle.None;
            checkedListBox_gender.ForeColor = Color.WhiteSmoke;
            checkedListBox_gender.FormattingEnabled = true;
            checkedListBox_gender.Items.AddRange(new object[] { "MALE", "FEMALE", "OTHERS" });
            checkedListBox_gender.Location = new Point(150, 283);
            checkedListBox_gender.Margin = new Padding(3, 4, 3, 4);
            checkedListBox_gender.Name = "checkedListBox_gender";
            checkedListBox_gender.Size = new Size(137, 44);
            checkedListBox_gender.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(11, 308);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 12;
            label5.Text = "GENDER:";
            // 
            // dateTimePicker_dob
            // 
            dateTimePicker_dob.Location = new Point(79, 233);
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
            label4.Location = new Point(11, 235);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 10;
            label4.Text = "DOB:";
            // 
            // textBox_email
            // 
            textBox_email.BackColor = Color.FromArgb(124, 124, 124);
            textBox_email.BorderStyle = BorderStyle.None;
            textBox_email.Location = new Point(79, 172);
            textBox_email.Multiline = true;
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(251, 29);
            textBox_email.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(3, 172);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 8;
            label3.Text = "Email:";
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.FromArgb(124, 124, 124);
            textBox_password.BorderStyle = BorderStyle.None;
            textBox_password.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_password.ForeColor = SystemColors.InactiveBorder;
            textBox_password.Location = new Point(111, 116);
            textBox_password.Multiline = true;
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(213, 29);
            textBox_password.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(3, 115);
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
            UserNameTxtBox.ForeColor = SystemColors.InactiveBorder;
            UserNameTxtBox.Location = new Point(88, 63);
            UserNameTxtBox.Multiline = true;
            UserNameTxtBox.Name = "UserNameTxtBox";
            UserNameTxtBox.Size = new Size(234, 29);
            UserNameTxtBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(7, 63);
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
            lblUserID.Location = new Point(-1, 8);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(78, 25);
            lblUserID.TabIndex = 0;
            lblUserID.Text = "UserID:";
            // 
            // dataGridView_Reps
            // 
            dataGridView_Reps.BackgroundColor = Color.FromArgb(136, 136, 136);
            dataGridView_Reps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Reps.Dock = DockStyle.Fill;
            dataGridView_Reps.Location = new Point(0, 0);
            dataGridView_Reps.Margin = new Padding(0);
            dataGridView_Reps.MultiSelect = false;
            dataGridView_Reps.Name = "dataGridView_Reps";
            dataGridView_Reps.ReadOnly = true;
            dataGridView_Reps.RowHeadersWidth = 51;
            dataGridView_Reps.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Reps.Size = new Size(633, 643);
            dataGridView_Reps.TabIndex = 1;
            // 
            // Admin_ReceptionistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 716);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(PanelProfile);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin_ReceptionistForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_ReceptionistForm";
            Load += Admin_ReceptionistForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelProfile.ResumeLayout(false);
            PanelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Reps).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton BtnReceptionist;
        private FontAwesome.Sharp.IconButton btnMechanic;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private Panel PanelProfile;
        private PictureBox pictureBox21;
        private Label label_role;
        private Label label_admin_name;
        private PictureBox pictureBox20;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView_Reps;
        private Panel panel2;
        private Button button_delete;
        private Button button_update;
        private Label label5;
        private DateTimePicker dateTimePicker_dob;
        private Label label4;
        private TextBox textBox_email;
        private Label label3;
        private TextBox textBox_password;
        private Label label2;
        private TextBox UserNameTxtBox;
        private Label label1;
        private Label lblUserID;
        private TextBox textBox_UserID;
        private Label label8;
        private CheckedListBox checkedListBox_gender;
        private RadioButton radioButton_night;
        private RadioButton radioButton_noon;
        private RadioButton radioButton_morning;
        private ComboBox comboBox_blood;
        private Label label9;
        private Button button_add_new;
    }
}