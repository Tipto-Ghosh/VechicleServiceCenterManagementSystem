namespace VehicleServiceCenter
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            panel1 = new Panel();
            iconButton_updateSelf = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            btnHome = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            btnCustomer = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            PanelHome = new Panel();
            label15 = new Label();
            panel9 = new Panel();
            label_admin_count = new Label();
            label13 = new Label();
            panel8 = new Panel();
            label_receptionist_count = new Label();
            label11 = new Label();
            panel5 = new Panel();
            label_mech_count = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            panel7 = new Panel();
            label4 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            label_customer_count = new Label();
            PanelProfile = new Panel();
            pictureBox21 = new PictureBox();
            label7 = new Label();
            label_name = new Label();
            pictureBox20 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            PanelHome.SuspendLayout();
            PanelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 56, 56);
            panel1.Controls.Add(iconButton_updateSelf);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(iconButton4);
            panel1.Controls.Add(btnCustomer);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 537);
            panel1.TabIndex = 0;
            // 
            // iconButton_updateSelf
            // 
            iconButton_updateSelf.FlatAppearance.BorderSize = 0;
            iconButton_updateSelf.FlatStyle = FlatStyle.Flat;
            iconButton_updateSelf.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton_updateSelf.ForeColor = Color.White;
            iconButton_updateSelf.IconChar = FontAwesome.Sharp.IconChar.Edit;
            iconButton_updateSelf.IconColor = Color.White;
            iconButton_updateSelf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_updateSelf.IconSize = 32;
            iconButton_updateSelf.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton_updateSelf.Location = new Point(0, 259);
            iconButton_updateSelf.Margin = new Padding(3, 4, 3, 4);
            iconButton_updateSelf.Name = "iconButton_updateSelf";
            iconButton_updateSelf.Size = new Size(200, 48);
            iconButton_updateSelf.TabIndex = 9;
            iconButton_updateSelf.Text = "Update Info";
            iconButton_updateSelf.TextAlign = ContentAlignment.MiddleLeft;
            iconButton_updateSelf.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton_updateSelf.UseVisualStyleBackColor = true;
            iconButton_updateSelf.Click += iconButton_updateSelf_Click;
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
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(175, 45);
            btnHome.TabIndex = 0;
            btnHome.Text = "LOG OUT";
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
            iconButton3.Location = new Point(0, 168);
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
            iconButton4.Location = new Point(0, 213);
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
            btnCustomer.Location = new Point(0, 123);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(175, 45);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "CUSTOMER";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += iconButton2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 18, 18);
            panel2.Controls.Add(PanelHome);
            panel2.Controls.Add(PanelProfile);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(169, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(839, 537);
            panel2.TabIndex = 1;
            // 
            // PanelHome
            // 
            PanelHome.Controls.Add(label15);
            PanelHome.Controls.Add(panel9);
            PanelHome.Controls.Add(label_admin_count);
            PanelHome.Controls.Add(label13);
            PanelHome.Controls.Add(panel8);
            PanelHome.Controls.Add(label_receptionist_count);
            PanelHome.Controls.Add(label11);
            PanelHome.Controls.Add(panel5);
            PanelHome.Controls.Add(label_mech_count);
            PanelHome.Controls.Add(label10);
            PanelHome.Controls.Add(label9);
            PanelHome.Controls.Add(label8);
            PanelHome.Controls.Add(label5);
            PanelHome.Controls.Add(panel7);
            PanelHome.Controls.Add(label4);
            PanelHome.Controls.Add(panel6);
            PanelHome.Controls.Add(label3);
            PanelHome.Controls.Add(label1);
            PanelHome.Controls.Add(panel4);
            PanelHome.Controls.Add(label_customer_count);
            PanelHome.Dock = DockStyle.Fill;
            PanelHome.Location = new Point(0, 55);
            PanelHome.Name = "PanelHome";
            PanelHome.Size = new Size(839, 482);
            PanelHome.TabIndex = 5;
            PanelHome.Paint += PanelHome_Paint;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.FlatStyle = FlatStyle.Flat;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.WhiteSmoke;
            label15.Location = new Point(596, 307);
            label15.Name = "label15";
            label15.Size = new Size(50, 16);
            label15.TabIndex = 20;
            label15.Text = "ADMIN";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Location = new Point(587, 311);
            panel9.Name = "panel9";
            panel9.Size = new Size(3, 80);
            panel9.TabIndex = 18;
            // 
            // label_admin_count
            // 
            label_admin_count.AutoSize = true;
            label_admin_count.BackColor = Color.Transparent;
            label_admin_count.FlatStyle = FlatStyle.Flat;
            label_admin_count.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_admin_count.ForeColor = Color.WhiteSmoke;
            label_admin_count.Location = new Point(597, 323);
            label_admin_count.Name = "label_admin_count";
            label_admin_count.Size = new Size(106, 73);
            label_admin_count.TabIndex = 19;
            label_admin_count.Text = "00";
            //label_admin_count.Click += this.label_admin_count_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.WhiteSmoke;
            label13.Location = new Point(326, 307);
            label13.Name = "label13";
            label13.Size = new Size(106, 16);
            label13.TabIndex = 17;
            label13.Text = "RECEPTIONIST";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(317, 311);
            panel8.Name = "panel8";
            panel8.Size = new Size(3, 80);
            panel8.TabIndex = 15;
            // 
            // label_receptionist_count
            // 
            label_receptionist_count.AutoSize = true;
            label_receptionist_count.BackColor = Color.Transparent;
            label_receptionist_count.FlatStyle = FlatStyle.Flat;
            label_receptionist_count.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_receptionist_count.ForeColor = Color.WhiteSmoke;
            label_receptionist_count.Location = new Point(331, 323);
            label_receptionist_count.Name = "label_receptionist_count";
            label_receptionist_count.Size = new Size(106, 73);
            label_receptionist_count.TabIndex = 16;
            label_receptionist_count.Text = "00";
            label_receptionist_count.Click += label_receptionist_count_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(98, 307);
            label11.Name = "label11";
            label11.Size = new Size(77, 16);
            label11.TabIndex = 14;
            label11.Text = "MECHANIC";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(89, 311);
            panel5.Name = "panel5";
            panel5.Size = new Size(3, 80);
            panel5.TabIndex = 12;
            // 
            // label_mech_count
            // 
            label_mech_count.AutoSize = true;
            label_mech_count.BackColor = Color.Transparent;
            label_mech_count.FlatStyle = FlatStyle.Flat;
            label_mech_count.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_mech_count.ForeColor = Color.WhiteSmoke;
            label_mech_count.Location = new Point(98, 323);
            label_mech_count.Name = "label_mech_count";
            label_mech_count.Size = new Size(106, 73);
            label_mech_count.TabIndex = 13;
            label_mech_count.Text = "00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(74, 259);
            label10.Name = "label10";
            label10.Size = new Size(303, 25);
            label10.TabIndex = 11;
            label10.Text = "CUSTOMER INFORMATION";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(597, 132);
            label9.Name = "label9";
            label9.Size = new Size(112, 16);
            label9.TabIndex = 10;
            label9.Text = "WORK PENDING";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(331, 132);
            label8.Name = "label8";
            label8.Size = new Size(56, 16);
            label8.TabIndex = 9;
            label8.Text = "PROFIT";
            label8.Click += label8_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(98, 128);
            label5.Name = "label5";
            label5.Size = new Size(84, 16);
            label5.TabIndex = 8;
            label5.Text = "CUSTOMER";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(588, 132);
            panel7.Name = "panel7";
            panel7.Size = new Size(3, 80);
            panel7.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(588, 142);
            label4.Name = "label4";
            label4.Size = new Size(130, 73);
            label4.TabIndex = 7;
            label4.Text = "NO";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(322, 132);
            panel6.Name = "panel6";
            panel6.Size = new Size(3, 80);
            panel6.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(318, 142);
            label3.Name = "label3";
            label3.Size = new Size(106, 73);
            label3.TabIndex = 5;
            label3.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(73, 76);
            label1.Name = "label1";
            label1.Size = new Size(269, 25);
            label1.TabIndex = 2;
            label1.Text = "SYSTEM INFORMATION";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(89, 132);
            panel4.Name = "panel4";
            panel4.Size = new Size(3, 80);
            panel4.TabIndex = 0;
            // 
            // label_customer_count
            // 
            label_customer_count.AutoSize = true;
            label_customer_count.BackColor = Color.Transparent;
            label_customer_count.FlatStyle = FlatStyle.Flat;
            label_customer_count.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_customer_count.ForeColor = Color.WhiteSmoke;
            label_customer_count.Location = new Point(90, 142);
            label_customer_count.Name = "label_customer_count";
            label_customer_count.Size = new Size(106, 73);
            label_customer_count.TabIndex = 3;
            label_customer_count.Text = "00";
            label_customer_count.Click += label2_Click;
            // 
            // PanelProfile
            // 
            PanelProfile.BackColor = Color.FromArgb(38, 38, 38);
            PanelProfile.Controls.Add(pictureBox21);
            PanelProfile.Controls.Add(label7);
            PanelProfile.Controls.Add(label_name);
            PanelProfile.Controls.Add(pictureBox20);
            PanelProfile.Dock = DockStyle.Top;
            PanelProfile.Location = new Point(0, 0);
            PanelProfile.Margin = new Padding(0);
            PanelProfile.Name = "PanelProfile";
            PanelProfile.Size = new Size(839, 55);
            PanelProfile.TabIndex = 4;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(643, 30);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 2;
            label7.Text = "ADMIN";
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.BackColor = Color.Transparent;
            label_name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_name.ForeColor = Color.WhiteSmoke;
            label_name.Location = new Point(643, 9);
            label_name.Name = "label_name";
            label_name.Size = new Size(108, 20);
            label_name.TabIndex = 2;
            label_name.Text = "FULL NAME";
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
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 537);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            PanelHome.ResumeLayout(false);
            PanelHome.PerformLayout();
            PanelProfile.ResumeLayout(false);
            PanelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel PanelProfile;
        private PictureBox pictureBox21;
        private Label label7;
        private Label label_name;
        private PictureBox pictureBox20;
        private Panel PanelHome;
        private Label label1;
        private Panel panel4;
        private Label label_customer_count;
        private Label label5;
        private Panel panel7;
        private Label label4;
        private Panel panel6;
        private Label label3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label11;
        private Panel panel5;
        private Label label_mech_count;
        private Label label15;
        private Panel panel9;
        private Label label_admin_count;
        private Label label13;
        private Panel panel8;
        private Label label_receptionist_count;
        private Panel panelCustomer;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton iconButton_updateSelf;
    }
}