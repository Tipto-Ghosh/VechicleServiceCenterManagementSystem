namespace VehicleServiceCenter
{
    partial class Mechanic_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mechanic_Form));
            panel1 = new Panel();
            radioButton_other = new RadioButton();
            radioButton_female = new RadioButton();
            radioButton_male = new RadioButton();
            textBox_UserID = new TextBox();
            label_userID = new Label();
            DOBPicker = new DateTimePicker();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            back_button = new Button();
            GenderLbl = new Label();
            DobLbl = new Label();
            EmailTxtBox = new TextBox();
            EmailLbl = new Label();
            PassTxtBox = new TextBox();
            PassLbl = new Label();
            UserNameTxtBox = new TextBox();
            UserNameLbl = new Label();
            reset_button = new Button();
            pictureBox1 = new PictureBox();
            InsertButton = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            BloodGroupComboBox = new ComboBox();
            comboBox_status = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBox_rating = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 18, 18);
            panel1.Controls.Add(textBox_rating);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox_status);
            panel1.Controls.Add(BloodGroupComboBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(radioButton_other);
            panel1.Controls.Add(radioButton_female);
            panel1.Controls.Add(radioButton_male);
            panel1.Controls.Add(textBox_UserID);
            panel1.Controls.Add(label_userID);
            panel1.Controls.Add(DOBPicker);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(back_button);
            panel1.Controls.Add(GenderLbl);
            panel1.Controls.Add(DobLbl);
            panel1.Controls.Add(EmailTxtBox);
            panel1.Controls.Add(EmailLbl);
            panel1.Controls.Add(PassTxtBox);
            panel1.Controls.Add(PassLbl);
            panel1.Controls.Add(UserNameTxtBox);
            panel1.Controls.Add(UserNameLbl);
            panel1.Controls.Add(reset_button);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(InsertButton);
            panel1.Dock = DockStyle.Right;
            panel1.ForeColor = Color.FromArgb(18, 18, 18);
            panel1.Location = new Point(663, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 654);
            panel1.TabIndex = 4;
            // 
            // radioButton_other
            // 
            radioButton_other.AutoSize = true;
            radioButton_other.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_other.ForeColor = Color.White;
            radioButton_other.Location = new Point(332, 309);
            radioButton_other.Name = "radioButton_other";
            radioButton_other.Size = new Size(75, 27);
            radioButton_other.TabIndex = 37;
            radioButton_other.TabStop = true;
            radioButton_other.Text = "Other";
            radioButton_other.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            radioButton_female.AutoSize = true;
            radioButton_female.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_female.ForeColor = Color.White;
            radioButton_female.Location = new Point(220, 309);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(86, 27);
            radioButton_female.TabIndex = 36;
            radioButton_female.TabStop = true;
            radioButton_female.Text = "Female";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            radioButton_male.AutoSize = true;
            radioButton_male.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_male.ForeColor = Color.White;
            radioButton_male.Location = new Point(140, 309);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(69, 27);
            radioButton_male.TabIndex = 35;
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
            textBox_UserID.Location = new Point(140, 111);
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
            label_userID.Location = new Point(8, 109);
            label_userID.Name = "label_userID";
            label_userID.Size = new Size(80, 22);
            label_userID.TabIndex = 29;
            label_userID.Text = "USER ID";
            // 
            // DOBPicker
            // 
            DOBPicker.Location = new Point(140, 355);
            DOBPicker.Margin = new Padding(3, 4, 3, 4);
            DOBPicker.Name = "DOBPicker";
            DOBPicker.Size = new Size(285, 27);
            DOBPicker.TabIndex = 28;
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
            // back_button
            // 
            back_button.BackColor = Color.FromArgb(208, 206, 206);
            back_button.Font = new Font("Microsoft Sans Serif", 13.8F);
            back_button.Location = new Point(165, 598);
            back_button.Margin = new Padding(3, 4, 3, 4);
            back_button.Name = "back_button";
            back_button.Size = new Size(124, 43);
            back_button.TabIndex = 15;
            back_button.Text = "BACK";
            back_button.UseVisualStyleBackColor = false;
            // 
            // GenderLbl
            // 
            GenderLbl.AutoSize = true;
            GenderLbl.Font = new Font("Cascadia Code", 10F);
            GenderLbl.ForeColor = Color.White;
            GenderLbl.Location = new Point(8, 309);
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
            DobLbl.Location = new Point(10, 355);
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
            EmailTxtBox.Location = new Point(140, 257);
            EmailTxtBox.Margin = new Padding(3, 4, 3, 4);
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
            EmailLbl.Location = new Point(8, 257);
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
            PassTxtBox.Location = new Point(140, 211);
            PassTxtBox.Margin = new Padding(3, 4, 3, 4);
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
            PassLbl.Location = new Point(7, 211);
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
            UserNameTxtBox.Location = new Point(140, 167);
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
            UserNameLbl.Location = new Point(7, 167);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new Size(100, 22);
            UserNameLbl.TabIndex = 3;
            UserNameLbl.Text = "USER NAME";
            // 
            // reset_button
            // 
            reset_button.BackColor = Color.FromArgb(18, 18, 18);
            reset_button.Font = new Font("Microsoft Sans Serif", 12F);
            reset_button.ForeColor = Color.FromArgb(208, 206, 206);
            reset_button.Location = new Point(256, 538);
            reset_button.Margin = new Padding(3, 4, 3, 4);
            reset_button.Name = "reset_button";
            reset_button.Size = new Size(114, 43);
            reset_button.TabIndex = 2;
            reset_button.Text = "RESET";
            reset_button.UseVisualStyleBackColor = false;
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
            // InsertButton
            // 
            InsertButton.BackColor = Color.FromArgb(208, 206, 206);
            InsertButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            InsertButton.ForeColor = Color.FromArgb(18, 18, 18);
            InsertButton.Location = new Point(62, 538);
            InsertButton.Margin = new Padding(3, 4, 3, 4);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(114, 43);
            InsertButton.TabIndex = 0;
            InsertButton.Text = "INSERT";
            InsertButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(664, 654);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 398);
            label1.Name = "label1";
            label1.Size = new Size(120, 22);
            label1.TabIndex = 38;
            label1.Text = "BLOOD GROUP";
            // 
            // BloodGroupComboBox
            // 
            BloodGroupComboBox.AutoCompleteCustomSource.AddRange(new string[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O- " });
            BloodGroupComboBox.BackColor = SystemColors.WindowFrame;
            BloodGroupComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BloodGroupComboBox.ForeColor = SystemColors.ButtonHighlight;
            BloodGroupComboBox.FormattingEnabled = true;
            BloodGroupComboBox.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            BloodGroupComboBox.Location = new Point(140, 390);
            BloodGroupComboBox.Margin = new Padding(3, 4, 3, 4);
            BloodGroupComboBox.Name = "BloodGroupComboBox";
            BloodGroupComboBox.Size = new Size(171, 36);
            BloodGroupComboBox.TabIndex = 39;
            // 
            // comboBox_status
            // 
            comboBox_status.AutoCompleteCustomSource.AddRange(new string[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O- " });
            comboBox_status.BackColor = SystemColors.WindowFrame;
            comboBox_status.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_status.ForeColor = SystemColors.ButtonHighlight;
            comboBox_status.FormattingEnabled = true;
            comboBox_status.Items.AddRange(new object[] { "Available", "Busy", "On Leave" });
            comboBox_status.Location = new Point(140, 434);
            comboBox_status.Margin = new Padding(3, 4, 3, 4);
            comboBox_status.Name = "comboBox_status";
            comboBox_status.Size = new Size(171, 36);
            comboBox_status.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 442);
            label2.Name = "label2";
            label2.Size = new Size(70, 22);
            label2.TabIndex = 41;
            label2.Text = "STATUS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 487);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 42;
            label3.Text = "RATING";
            // 
            // textBox_rating
            // 
            textBox_rating.BackColor = Color.FromArgb(124, 124, 124);
            textBox_rating.BorderStyle = BorderStyle.None;
            textBox_rating.Location = new Point(140, 487);
            textBox_rating.Multiline = true;
            textBox_rating.Name = "textBox_rating";
            textBox_rating.Size = new Size(183, 29);
            textBox_rating.TabIndex = 43;
            // 
            // Mechanic_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 654);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "Mechanic_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mechanic Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RadioButton radioButton_other;
        private RadioButton radioButton_female;
        private RadioButton radioButton_male;
        private TextBox textBox_UserID;
        private Label label_userID;
        private DateTimePicker DOBPicker;
        private PictureBox pictureBox4;
        private Label label6;
        private Button back_button;
        private Label GenderLbl;
        private Label DobLbl;
        private TextBox EmailTxtBox;
        private Label EmailLbl;
        private TextBox PassTxtBox;
        private Label PassLbl;
        private TextBox UserNameTxtBox;
        private Label UserNameLbl;
        private Button reset_button;
        private PictureBox pictureBox1;
        private Button InsertButton;
        private PictureBox pictureBox2;
        private Label label1;
        private ComboBox BloodGroupComboBox;
        private ComboBox comboBox_status;
        private Label label3;
        private Label label2;
        private TextBox textBox_rating;
    }
}