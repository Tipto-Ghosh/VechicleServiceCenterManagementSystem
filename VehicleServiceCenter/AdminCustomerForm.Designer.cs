namespace VehicleServiceCenter
{
    partial class AdminCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCustomerForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnHome = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            btnCustomer = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            PanelProfile = new Panel();
            pictureBox21 = new PictureBox();
            label_role = new Label();
            label_name = new Label();
            pictureBox20 = new PictureBox();
            PanelHome = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewCustomers = new DataGridView();
            panel2 = new Panel();
            button_cancel = new Button();
            button_add_new = new Button();
            label6 = new Label();
            comboBox_blood = new ComboBox();
            textBox_phone = new TextBox();
            textBox_UserID = new TextBox();
            panel4 = new Panel();
            panel3 = new Panel();
            button_delete = new Button();
            button_Update = new Button();
            checkedListBox_gender = new CheckedListBox();
            label5 = new Label();
            dateTimePicker_dob = new DateTimePicker();
            label4 = new Label();
            textBox_email = new TextBox();
            label3 = new Label();
            textBox_password = new TextBox();
            label_phone = new Label();
            label2 = new Label();
            UserNameTxtBox = new TextBox();
            label1 = new Label();
            lblUserID = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            PanelHome.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 56, 56);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(iconButton4);
            panel1.Controls.Add(btnCustomer);
            panel1.Controls.Add(iconButton5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 537);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.car_maintenance_17073141;
            pictureBox1.Location = new Point(34, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
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
            btnHome.Location = new Point(0, 78);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(175, 45);
            btnHome.TabIndex = 0;
            btnHome.Text = "HOME";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // iconButton3
            // 
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Headset;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 32;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 172);
            iconButton3.Margin = new Padding(0);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(175, 45);
            iconButton3.TabIndex = 2;
            iconButton3.Text = "RECEPTIONIST";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton4
            // 
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Microsoft Sans Serif", 9.75F);
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Hammer;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 32;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 219);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(175, 45);
            iconButton4.TabIndex = 3;
            iconButton4.Text = "MECHANIC";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
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
            btnCustomer.Location = new Point(0, 125);
            btnCustomer.Margin = new Padding(0);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(175, 45);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "CUSTOMER";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Microsoft Sans Serif", 9.75F);
            iconButton5.ForeColor = Color.White;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            iconButton5.IconColor = Color.White;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 32;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(0, 266);
            iconButton5.Margin = new Padding(0);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(169, 45);
            iconButton5.TabIndex = 4;
            iconButton5.Text = "INVENTORY";
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            // 
            // PanelProfile
            // 
            PanelProfile.BackColor = Color.FromArgb(38, 38, 38);
            PanelProfile.Controls.Add(pictureBox21);
            PanelProfile.Controls.Add(label_role);
            PanelProfile.Controls.Add(label_name);
            PanelProfile.Controls.Add(pictureBox20);
            PanelProfile.Dock = DockStyle.Top;
            PanelProfile.Location = new Point(169, 0);
            PanelProfile.Margin = new Padding(0);
            PanelProfile.Name = "PanelProfile";
            PanelProfile.Size = new Size(839, 55);
            PanelProfile.TabIndex = 5;
            // 
            // pictureBox21
            // 
            pictureBox21.Image = (Image)resources.GetObject("pictureBox21.Image");
            pictureBox21.Location = new Point(606, 0);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(31, 55);
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
            label_role.Location = new Point(643, 30);
            label_role.Name = "label_role";
            label_role.Size = new Size(46, 15);
            label_role.TabIndex = 2;
            label_role.Text = "ADMIN";
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.BackColor = Color.Transparent;
            label_name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_name.ForeColor = Color.WhiteSmoke;
            label_name.Location = new Point(643, 9);
            label_name.Name = "label_name";
            label_name.Size = new Size(113, 20);
            label_name.TabIndex = 2;
            label_name.Text = " FULL NAME";
            // 
            // pictureBox20
            // 
            pictureBox20.Image = Properties.Resources.icons8_sign_out_501;
            pictureBox20.Location = new Point(804, 0);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(28, 55);
            pictureBox20.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox20.TabIndex = 1;
            pictureBox20.TabStop = false;
            // 
            // PanelHome
            // 
            PanelHome.BackColor = Color.FromArgb(18, 18, 18);
            PanelHome.Controls.Add(tableLayoutPanel1);
            PanelHome.Dock = DockStyle.Fill;
            PanelHome.Location = new Point(169, 55);
            PanelHome.Margin = new Padding(0);
            PanelHome.Name = "PanelHome";
            PanelHome.Size = new Size(839, 482);
            PanelHome.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.67342F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 285F));
            tableLayoutPanel1.Controls.Add(dataGridViewCustomers, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1659756F));
            tableLayoutPanel1.Size = new Size(839, 482);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.BackgroundColor = Color.FromArgb(136, 136, 136);
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Dock = DockStyle.Fill;
            dataGridViewCustomers.Location = new Point(0, 0);
            dataGridViewCustomers.Margin = new Padding(0);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 51;
            dataGridViewCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCustomers.Size = new Size(554, 482);
            dataGridViewCustomers.TabIndex = 0;
            dataGridViewCustomers.SelectionChanged += dataGridViewCustomers_SelectionChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(button_cancel);
            panel2.Controls.Add(button_add_new);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(comboBox_blood);
            panel2.Controls.Add(textBox_phone);
            panel2.Controls.Add(textBox_UserID);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button_delete);
            panel2.Controls.Add(button_Update);
            panel2.Controls.Add(checkedListBox_gender);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dateTimePicker_dob);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox_email);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox_password);
            panel2.Controls.Add(label_phone);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(UserNameTxtBox);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblUserID);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(554, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 482);
            panel2.TabIndex = 1;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = SystemColors.ControlLightLight;
            button_cancel.FlatAppearance.BorderSize = 0;
            button_cancel.FlatStyle = FlatStyle.Popup;
            button_cancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_cancel.ForeColor = Color.Green;
            button_cancel.Location = new Point(158, 358);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(106, 36);
            button_cancel.TabIndex = 23;
            button_cancel.Text = "CANCEL";
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_add_new
            // 
            button_add_new.BackColor = SystemColors.ControlLightLight;
            button_add_new.FlatAppearance.BorderSize = 0;
            button_add_new.FlatStyle = FlatStyle.Popup;
            button_add_new.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_add_new.ForeColor = Color.Green;
            button_add_new.Location = new Point(28, 358);
            button_add_new.Name = "button_add_new";
            button_add_new.Size = new Size(106, 36);
            button_add_new.TabIndex = 22;
            button_add_new.Text = "Add New";
            button_add_new.UseVisualStyleBackColor = false;
            button_add_new.Click += button_add_new_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(3, 312);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 21;
            label6.Text = "Blood:";
            // 
            // comboBox_blood
            // 
            comboBox_blood.AutoCompleteCustomSource.AddRange(new string[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            comboBox_blood.FormattingEnabled = true;
            comboBox_blood.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            comboBox_blood.Location = new Point(107, 310);
            comboBox_blood.Margin = new Padding(3, 2, 3, 2);
            comboBox_blood.Name = "comboBox_blood";
            comboBox_blood.Size = new Size(133, 23);
            comboBox_blood.TabIndex = 20;
            // 
            // textBox_phone
            // 
            textBox_phone.BackColor = Color.FromArgb(124, 124, 124);
            textBox_phone.BorderStyle = BorderStyle.None;
            textBox_phone.ForeColor = SystemColors.InactiveBorder;
            textBox_phone.Location = new Point(72, 212);
            textBox_phone.Margin = new Padding(3, 2, 3, 2);
            textBox_phone.Multiline = true;
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(204, 22);
            textBox_phone.TabIndex = 19;
            // 
            // textBox_UserID
            // 
            textBox_UserID.BackColor = Color.FromArgb(124, 124, 124);
            textBox_UserID.BorderStyle = BorderStyle.None;
            textBox_UserID.ForeColor = SystemColors.InactiveBorder;
            textBox_UserID.Location = new Point(89, 6);
            textBox_UserID.Margin = new Padding(3, 2, 3, 2);
            textBox_UserID.Multiline = true;
            textBox_UserID.Name = "textBox_UserID";
            textBox_UserID.ReadOnly = true;
            textBox_UserID.Size = new Size(187, 22);
            textBox_UserID.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDarkDark;
            panel4.Location = new Point(-15, 400);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 2);
            panel4.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Location = new Point(-12, 346);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 2);
            panel3.TabIndex = 17;
            // 
            // button_delete
            // 
            button_delete.BackColor = SystemColors.ControlLightLight;
            button_delete.FlatAppearance.BorderSize = 0;
            button_delete.FlatStyle = FlatStyle.Popup;
            button_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = Color.Red;
            button_delete.Location = new Point(162, 421);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(106, 36);
            button_delete.TabIndex = 16;
            button_delete.Text = "DELETE";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_Update
            // 
            button_Update.BackColor = SystemColors.ControlLightLight;
            button_Update.FlatAppearance.BorderSize = 0;
            button_Update.FlatStyle = FlatStyle.Popup;
            button_Update.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_Update.ForeColor = Color.Green;
            button_Update.Location = new Point(28, 421);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(106, 36);
            button_Update.TabIndex = 16;
            button_Update.Text = "UPDATE";
            button_Update.UseVisualStyleBackColor = false;
            button_Update.Click += button_Update_Click;
            // 
            // checkedListBox_gender
            // 
            checkedListBox_gender.BackColor = Color.FromArgb(18, 18, 18);
            checkedListBox_gender.BorderStyle = BorderStyle.None;
            checkedListBox_gender.ForeColor = Color.WhiteSmoke;
            checkedListBox_gender.FormattingEnabled = true;
            checkedListBox_gender.Items.AddRange(new object[] { "male", "female", "other" });
            checkedListBox_gender.Location = new Point(119, 245);
            checkedListBox_gender.Name = "checkedListBox_gender";
            checkedListBox_gender.Size = new Size(120, 36);
            checkedListBox_gender.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(-1, 256);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 12;
            label5.Text = "GENDER:";
            // 
            // dateTimePicker_dob
            // 
            dateTimePicker_dob.Location = new Point(72, 170);
            dateTimePicker_dob.Name = "dateTimePicker_dob";
            dateTimePicker_dob.Size = new Size(204, 23);
            dateTimePicker_dob.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(-1, 174);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 10;
            label4.Text = "DOB:";
            // 
            // textBox_email
            // 
            textBox_email.BackColor = Color.FromArgb(124, 124, 124);
            textBox_email.BorderStyle = BorderStyle.None;
            textBox_email.ForeColor = SystemColors.InactiveBorder;
            textBox_email.Location = new Point(72, 129);
            textBox_email.Margin = new Padding(3, 2, 3, 2);
            textBox_email.Multiline = true;
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(204, 22);
            textBox_email.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(-1, 132);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 8;
            label3.Text = "Email:";
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.FromArgb(124, 124, 124);
            textBox_password.BorderStyle = BorderStyle.None;
            textBox_password.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_password.ForeColor = SystemColors.InactiveBorder;
            textBox_password.Location = new Point(90, 88);
            textBox_password.Margin = new Padding(3, 2, 3, 2);
            textBox_password.Multiline = true;
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(186, 22);
            textBox_password.TabIndex = 7;
            // 
            // label_phone
            // 
            label_phone.AutoSize = true;
            label_phone.BackColor = Color.Transparent;
            label_phone.FlatStyle = FlatStyle.Flat;
            label_phone.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_phone.ForeColor = SystemColors.ControlLightLight;
            label_phone.Location = new Point(-1, 216);
            label_phone.Name = "label_phone";
            label_phone.Size = new Size(61, 18);
            label_phone.TabIndex = 6;
            label_phone.Text = "Phone:";
            label_phone.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(-1, 90);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // UserNameTxtBox
            // 
            UserNameTxtBox.BackColor = Color.FromArgb(124, 124, 124);
            UserNameTxtBox.BorderStyle = BorderStyle.None;
            UserNameTxtBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameTxtBox.ForeColor = SystemColors.InactiveBorder;
            UserNameTxtBox.Location = new Point(89, 47);
            UserNameTxtBox.Margin = new Padding(3, 2, 3, 2);
            UserNameTxtBox.Multiline = true;
            UserNameTxtBox.Name = "UserNameTxtBox";
            UserNameTxtBox.Size = new Size(187, 22);
            UserNameTxtBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(-1, 48);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
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
            lblUserID.Location = new Point(-1, 6);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(68, 20);
            lblUserID.TabIndex = 0;
            lblUserID.Text = "User ID:";
            // 
            // AdminCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1008, 537);
            Controls.Add(PanelHome);
            Controls.Add(PanelProfile);
            Controls.Add(panel1);
            Name = "AdminCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            Load += AdminCustomerForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelProfile.ResumeLayout(false);
            PanelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            PanelHome.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Panel PanelProfile;
        private PictureBox pictureBox21;
        private Label label_role;
        private Label label_name;
        private PictureBox pictureBox20;
        private Panel PanelHome;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewCustomers;
        private Panel panel2;
        private Label lblUserID;
        private Label label1;
        private TextBox textBox_email;
        private Label label3;
        private TextBox textBox_password;
        private Label label2;
        private TextBox UserNameTxtBox;
        private Label label5;
        private DateTimePicker dateTimePicker_dob;
        private Label label4;
        private CheckedListBox checkedListBox_gender;
        private Label label_phone;
        private Button button_delete;
        private Button button_Update;
        private Panel panel3;
        private Panel panel4;
        private TextBox textBox_UserID;
        private TextBox textBox_phone;
        private Label label6;
        private ComboBox comboBox_blood;
        private Button button_add_new;
        private Button button_cancel;
    }
}