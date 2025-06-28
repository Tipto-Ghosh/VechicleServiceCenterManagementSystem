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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Mechanic));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnHome = new FontAwesome.Sharp.IconButton();
            BtnReceptionist = new FontAwesome.Sharp.IconButton();
            btnMechanic = new FontAwesome.Sharp.IconButton();
            btnCustomer = new FontAwesome.Sharp.IconButton();
            btnAdmin = new FontAwesome.Sharp.IconButton();
            PanelProfile = new Panel();
            pictureBox21 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            pictureBox20 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            button4 = new Button();
            button3 = new Button();
            checkedListBox1 = new CheckedListBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            UserNameTxtBox = new TextBox();
            label1 = new Label();
            lblUserID = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            btnHome.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            BtnReceptionist.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            // btnMechanic
            // 
            btnMechanic.FlatAppearance.BorderSize = 0;
            btnMechanic.FlatStyle = FlatStyle.Flat;
            btnMechanic.Font = new Font("Poppins", 9.75F);
            btnMechanic.ForeColor = Color.White;
            btnMechanic.IconChar = FontAwesome.Sharp.IconChar.Hammer;
            btnMechanic.IconColor = Color.White;
            btnMechanic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMechanic.IconSize = 32;
            btnMechanic.ImageAlign = ContentAlignment.MiddleLeft;
            btnMechanic.Location = new Point(0, 292);
            btnMechanic.Margin = new Padding(0);
            btnMechanic.Name = "btnMechanic";
            btnMechanic.Size = new Size(200, 60);
            btnMechanic.TabIndex = 3;
            btnMechanic.Text = "MECHANIC";
            btnMechanic.TextAlign = ContentAlignment.MiddleLeft;
            btnMechanic.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMechanic.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            // btnAdmin
            // 
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Poppins", 9.75F);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            btnAdmin.IconColor = Color.White;
            btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmin.IconSize = 32;
            btnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmin.Location = new Point(0, 355);
            btnAdmin.Margin = new Padding(0);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(200, 60);
            btnAdmin.TabIndex = 4;
            btnAdmin.Text = "INVENTORY";
            btnAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdmin.UseVisualStyleBackColor = true;
            // 
            // PanelProfile
            // 
            PanelProfile.BackColor = Color.FromArgb(38, 38, 38);
            PanelProfile.Controls.Add(pictureBox21);
            PanelProfile.Controls.Add(label7);
            PanelProfile.Controls.Add(label6);
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
            pictureBox21.Location = new Point(693, 0);
            pictureBox21.Margin = new Padding(3, 4, 3, 4);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(35, 73);
            pictureBox21.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox21.TabIndex = 3;
            pictureBox21.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(735, 40);
            label7.Name = "label7";
            label7.Size = new Size(60, 26);
            label7.TabIndex = 2;
            label7.Text = "ADMIN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(735, 12);
            label6.Name = "label6";
            label6.Size = new Size(125, 36);
            label6.TabIndex = 2;
            label6.Text = "FULL NAME";
            label6.Click += label6_Click;
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
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
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
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(checkedListBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
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
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Location = new Point(-14, 461);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(343, 3);
            panel3.TabIndex = 17;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(185, 515);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(121, 48);
            button4.TabIndex = 16;
            button4.Text = "DELETE";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Green;
            button3.Location = new Point(32, 515);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(121, 48);
            button3.TabIndex = 16;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = false;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.FromArgb(18, 18, 18);
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.ForeColor = Color.WhiteSmoke;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "MALE", "FEMALE", "OTHERS" });
            checkedListBox1.Location = new Point(98, 381);
            checkedListBox1.Margin = new Padding(3, 4, 3, 4);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(137, 66);
            checkedListBox1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(7, 369);
            label5.Name = "label5";
            label5.Size = new Size(95, 36);
            label5.TabIndex = 12;
            label5.Text = "GENDER:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(78, 324);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(7, 317);
            label4.Name = "label4";
            label4.Size = new Size(61, 36);
            label4.TabIndex = 10;
            label4.Text = "DOB:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(124, 124, 124);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(17, 268);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 29);
            textBox2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(7, 233);
            label3.Name = "label3";
            label3.Size = new Size(121, 36);
            label3.TabIndex = 8;
            label3.Text = "User Email:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(124, 124, 124);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(17, 183);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 29);
            textBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(7, 148);
            label2.Name = "label2";
            label2.Size = new Size(114, 36);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // UserNameTxtBox
            // 
            UserNameTxtBox.BackColor = Color.FromArgb(124, 124, 124);
            UserNameTxtBox.BorderStyle = BorderStyle.None;
            UserNameTxtBox.Location = new Point(17, 97);
            UserNameTxtBox.Multiline = true;
            UserNameTxtBox.Name = "UserNameTxtBox";
            UserNameTxtBox.Size = new Size(295, 29);
            UserNameTxtBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(7, 63);
            label1.Name = "label1";
            label1.Size = new Size(127, 36);
            label1.TabIndex = 1;
            label1.Text = "User Name:";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.BackColor = Color.Transparent;
            lblUserID.FlatStyle = FlatStyle.Flat;
            lblUserID.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = SystemColors.ControlLightLight;
            lblUserID.Location = new Point(-1, 8);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(86, 36);
            lblUserID.TabIndex = 0;
            lblUserID.Text = "User ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(633, 643);
            dataGridView1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label7;
        private Label label6;
        private PictureBox pictureBox20;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel3;
        private Button button4;
        private Button button3;
        private CheckedListBox checkedListBox1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox UserNameTxtBox;
        private Label label1;
        private Label lblUserID;
    }
}