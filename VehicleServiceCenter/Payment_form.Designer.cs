﻿namespace VehicleServiceCenter
{
    partial class Payment_form
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
            profilePanel = new Panel();
            pictureBox4 = new PictureBox();
            iconButton_back = new FontAwesome.Sharp.IconButton();
            label_admin_name = new Label();
            settingsPictureBox = new PictureBox();
            notificationPictureBox = new PictureBox();
            fullNameLabel = new Label();
            label1 = new Label();
            UserNameTxtBox = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button_update = new Button();
            button_delete = new Button();
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settingsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)notificationPictureBox).BeginInit();
            SuspendLayout();
            // 
            // profilePanel
            // 
            profilePanel.BackColor = Color.FromArgb(38, 38, 38);
            profilePanel.Controls.Add(pictureBox4);
            profilePanel.Controls.Add(iconButton_back);
            profilePanel.Controls.Add(label_admin_name);
            profilePanel.Controls.Add(settingsPictureBox);
            profilePanel.Controls.Add(notificationPictureBox);
            profilePanel.Controls.Add(fullNameLabel);
            profilePanel.Dock = DockStyle.Top;
            profilePanel.Location = new Point(0, 0);
            profilePanel.Margin = new Padding(0);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(1008, 55);
            profilePanel.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_close_50;
            pictureBox4.Location = new Point(957, 7);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
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
            iconButton_back.Location = new Point(10, 10);
            iconButton_back.Name = "iconButton_back";
            iconButton_back.Size = new Size(39, 40);
            iconButton_back.TabIndex = 32;
            iconButton_back.UseVisualStyleBackColor = true;
            // 
            // label_admin_name
            // 
            label_admin_name.AutoSize = true;
            label_admin_name.BackColor = Color.Transparent;
            label_admin_name.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_admin_name.ForeColor = Color.WhiteSmoke;
            label_admin_name.Location = new Point(509, 20);
            label_admin_name.Name = "label_admin_name";
            label_admin_name.Size = new Size(126, 26);
            label_admin_name.TabIndex = 6;
            label_admin_name.Text = "PAYMENT";
            // 
            // settingsPictureBox
            // 
            settingsPictureBox.Image = Properties.Resources.car_maintenance_17073141;
            settingsPictureBox.Location = new Point(447, 3);
            settingsPictureBox.Name = "settingsPictureBox";
            settingsPictureBox.Size = new Size(57, 55);
            settingsPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            settingsPictureBox.TabIndex = 3;
            settingsPictureBox.TabStop = false;
            // 
            // notificationPictureBox
            // 
            notificationPictureBox.Image = Properties.Resources.icons8_customer_64;
            notificationPictureBox.Location = new Point(765, -3);
            notificationPictureBox.Name = "notificationPictureBox";
            notificationPictureBox.Size = new Size(31, 55);
            notificationPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            notificationPictureBox.TabIndex = 3;
            notificationPictureBox.TabStop = false;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.BackColor = Color.Transparent;
            fullNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameLabel.ForeColor = Color.WhiteSmoke;
            fullNameLabel.Location = new Point(801, 7);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(108, 20);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "FULL NAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(147, 100);
            label1.Name = "label1";
            label1.Size = new Size(197, 26);
            label1.TabIndex = 7;
            label1.Text = "DUE PAYMENT :";
            // 
            // UserNameTxtBox
            // 
            UserNameTxtBox.BackColor = Color.FromArgb(124, 124, 124);
            UserNameTxtBox.BorderStyle = BorderStyle.None;
            UserNameTxtBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameTxtBox.ForeColor = SystemColors.InactiveBorder;
            UserNameTxtBox.Location = new Point(447, 95);
            UserNameTxtBox.Margin = new Padding(3, 2, 3, 2);
            UserNameTxtBox.Multiline = true;
            UserNameTxtBox.Name = "UserNameTxtBox";
            UserNameTxtBox.Size = new Size(292, 29);
            UserNameTxtBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(147, 178);
            label2.Name = "label2";
            label2.Size = new Size(188, 26);
            label2.TabIndex = 9;
            label2.Text = "WANT TO PAY :";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(124, 124, 124);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(447, 173);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 29);
            textBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(147, 260);
            label3.Name = "label3";
            label3.Size = new Size(247, 26);
            label3.TabIndex = 11;
            label3.Text = "PAYMENT METHOD :";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(124, 124, 124);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BKASH", "NAGAN", "BANK" });
            comboBox1.Location = new Point(447, 260);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(293, 23);
            comboBox1.TabIndex = 12;
            // 
            // button_update
            // 
            button_update.BackColor = SystemColors.ControlLightLight;
            button_update.FlatAppearance.BorderSize = 0;
            button_update.FlatStyle = FlatStyle.Popup;
            button_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_update.ForeColor = Color.Green;
            button_update.Location = new Point(312, 391);
            button_update.Name = "button_update";
            button_update.Size = new Size(106, 36);
            button_update.TabIndex = 17;
            button_update.Text = "PAY";
            button_update.UseVisualStyleBackColor = false;
            // 
            // button_delete
            // 
            button_delete.BackColor = SystemColors.ControlLightLight;
            button_delete.FlatAppearance.BorderSize = 0;
            button_delete.FlatStyle = FlatStyle.Popup;
            button_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = Color.Red;
            button_delete.Location = new Point(509, 391);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(106, 36);
            button_delete.TabIndex = 18;
            button_delete.Text = "CANCEL";
            button_delete.UseVisualStyleBackColor = false;
            // 
            // Payment_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1008, 537);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(UserNameTxtBox);
            Controls.Add(label1);
            Controls.Add(profilePanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Payment_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Payment_form_Load;
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)settingsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)notificationPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel profilePanel;
        private PictureBox settingsPictureBox;
        private PictureBox notificationPictureBox;
        private Label fullNameLabel;
        private Label label_admin_name;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton_back;
        private PictureBox pictureBox4;
        private TextBox UserNameTxtBox;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Button button_update;
        private Button button_delete;
    }
}