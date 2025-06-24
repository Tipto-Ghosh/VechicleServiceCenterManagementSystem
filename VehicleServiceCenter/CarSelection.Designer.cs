namespace VehicleServiceCenter
{
    partial class CarSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarSelection));
            mainTableLayout = new TableLayoutPanel();
            profilePanel = new Panel();
            settingsPictureBox = new PictureBox();
            notificationPictureBox = new PictureBox();
            customerTypeLabel = new Label();
            fullNameLabel = new Label();
            signOutPictureBox = new PictureBox();
            brandsTableLayout = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            otherBrandPanelContainer = new Panel();
            otherBrandPanel = new Panel();
            otherBrandLabel = new Label();
            brandFourPanelContainer = new Panel();
            brandFourPanel = new Panel();
            pictureBox2 = new PictureBox();
            brandFourPictureBox = new PictureBox();
            brandThreePanelContainer = new Panel();
            brandThreePanel = new Panel();
            pictureBox3 = new PictureBox();
            brandTwoPanelContainer = new Panel();
            brandTwoPanel = new Panel();
            brandTwoPictureBox = new PictureBox();
            brandOnePanelContainer = new Panel();
            brandOnePanel = new Panel();
            brandOnePictureBox = new PictureBox();
            selectionInstructionPanel = new Panel();
            selectionInstructionLabel = new Label();
            mainTableLayout.SuspendLayout();
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)settingsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)notificationPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signOutPictureBox).BeginInit();
            brandsTableLayout.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            otherBrandPanelContainer.SuspendLayout();
            otherBrandPanel.SuspendLayout();
            brandFourPanelContainer.SuspendLayout();
            brandFourPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brandFourPictureBox).BeginInit();
            brandThreePanelContainer.SuspendLayout();
            brandThreePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            brandTwoPanelContainer.SuspendLayout();
            brandTwoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brandTwoPictureBox).BeginInit();
            brandOnePanelContainer.SuspendLayout();
            brandOnePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brandOnePictureBox).BeginInit();
            selectionInstructionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayout
            // 
            mainTableLayout.ColumnCount = 1;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayout.Controls.Add(profilePanel, 0, 0);
            mainTableLayout.Controls.Add(brandsTableLayout, 0, 1);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 0);
            mainTableLayout.Margin = new Padding(0);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 2;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayout.Size = new Size(1152, 716);
            mainTableLayout.TabIndex = 0;
            // 
            // profilePanel
            // 
            profilePanel.BackColor = Color.FromArgb(38, 38, 38);
            profilePanel.Controls.Add(settingsPictureBox);
            profilePanel.Controls.Add(notificationPictureBox);
            profilePanel.Controls.Add(customerTypeLabel);
            profilePanel.Controls.Add(fullNameLabel);
            profilePanel.Controls.Add(signOutPictureBox);
            profilePanel.Dock = DockStyle.Top;
            profilePanel.Location = new Point(0, 0);
            profilePanel.Margin = new Padding(0);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(1152, 73);
            profilePanel.TabIndex = 3;
            // 
            // settingsPictureBox
            // 
            settingsPictureBox.Image = Properties.Resources.car_maintenance_17073141;
            settingsPictureBox.Location = new Point(542, 0);
            settingsPictureBox.Margin = new Padding(3, 4, 3, 4);
            settingsPictureBox.Name = "settingsPictureBox";
            settingsPictureBox.Size = new Size(65, 73);
            settingsPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            settingsPictureBox.TabIndex = 3;
            settingsPictureBox.TabStop = false;
            // 
            // notificationPictureBox
            // 
            notificationPictureBox.Image = Properties.Resources.icons8_customer_64;
            notificationPictureBox.Location = new Point(886, 0);
            notificationPictureBox.Margin = new Padding(3, 4, 3, 4);
            notificationPictureBox.Name = "notificationPictureBox";
            notificationPictureBox.Size = new Size(35, 73);
            notificationPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            notificationPictureBox.TabIndex = 3;
            notificationPictureBox.TabStop = false;
            // 
            // customerTypeLabel
            // 
            customerTypeLabel.AutoSize = true;
            customerTypeLabel.BackColor = Color.Transparent;
            customerTypeLabel.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerTypeLabel.ForeColor = Color.Gainsboro;
            customerTypeLabel.Location = new Point(928, 40);
            customerTypeLabel.Name = "customerTypeLabel";
            customerTypeLabel.Size = new Size(92, 26);
            customerTypeLabel.TabIndex = 2;
            customerTypeLabel.Text = "CUSTOMER";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.BackColor = Color.Transparent;
            fullNameLabel.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameLabel.ForeColor = Color.WhiteSmoke;
            fullNameLabel.Location = new Point(928, 12);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(125, 36);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "FULL NAME";
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
            // brandsTableLayout
            // 
            brandsTableLayout.BackColor = Color.FromArgb(18, 18, 18);
            brandsTableLayout.ColumnCount = 3;
            brandsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            brandsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            brandsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            brandsTableLayout.Controls.Add(panel1, 2, 0);
            brandsTableLayout.Controls.Add(otherBrandPanelContainer, 2, 1);
            brandsTableLayout.Controls.Add(brandFourPanelContainer, 1, 1);
            brandsTableLayout.Controls.Add(brandThreePanelContainer, 0, 1);
            brandsTableLayout.Controls.Add(brandTwoPanelContainer, 1, 0);
            brandsTableLayout.Controls.Add(brandOnePanelContainer, 0, 0);
            brandsTableLayout.Controls.Add(selectionInstructionPanel, 1, 2);
            brandsTableLayout.Dock = DockStyle.Fill;
            brandsTableLayout.Location = new Point(0, 73);
            brandsTableLayout.Margin = new Padding(0);
            brandsTableLayout.Name = "brandsTableLayout";
            brandsTableLayout.RowCount = 3;
            brandsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            brandsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            brandsTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            brandsTableLayout.Size = new Size(1152, 643);
            brandsTableLayout.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(768, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(29, 33, 29, 33);
            panel1.Size = new Size(384, 293);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(68, 68, 68);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(29, 33);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(326, 227);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngwing_com__4_;
            pictureBox1.Location = new Point(54, 20);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox_MouseEnter;
            pictureBox1.MouseLeave += pictureBox_MouseLeave;
            // 
            // otherBrandPanelContainer
            // 
            otherBrandPanelContainer.Controls.Add(otherBrandPanel);
            otherBrandPanelContainer.Dock = DockStyle.Fill;
            otherBrandPanelContainer.Location = new Point(768, 293);
            otherBrandPanelContainer.Margin = new Padding(0);
            otherBrandPanelContainer.Name = "otherBrandPanelContainer";
            otherBrandPanelContainer.Padding = new Padding(29, 33, 29, 33);
            otherBrandPanelContainer.Size = new Size(384, 293);
            otherBrandPanelContainer.TabIndex = 5;
            // 
            // otherBrandPanel
            // 
            otherBrandPanel.BackColor = Color.FromArgb(68, 68, 68);
            otherBrandPanel.Controls.Add(otherBrandLabel);
            otherBrandPanel.Dock = DockStyle.Fill;
            otherBrandPanel.Location = new Point(29, 33);
            otherBrandPanel.Margin = new Padding(3, 4, 3, 4);
            otherBrandPanel.Name = "otherBrandPanel";
            otherBrandPanel.Size = new Size(326, 227);
            otherBrandPanel.TabIndex = 0;
            // 
            // otherBrandLabel
            // 
            otherBrandLabel.Dock = DockStyle.Fill;
            otherBrandLabel.Font = new Font("Poppins", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            otherBrandLabel.ForeColor = SystemColors.Control;
            otherBrandLabel.Location = new Point(0, 0);
            otherBrandLabel.Name = "otherBrandLabel";
            otherBrandLabel.Size = new Size(326, 227);
            otherBrandLabel.TabIndex = 0;
            otherBrandLabel.Text = "OTHER";
            otherBrandLabel.TextAlign = ContentAlignment.MiddleCenter;
            otherBrandLabel.Click += label1_Click;
            otherBrandLabel.MouseEnter += Control_MouseEnter;
            otherBrandLabel.MouseLeave += Control_MouseLeave;
            // 
            // brandFourPanelContainer
            // 
            brandFourPanelContainer.Controls.Add(brandFourPanel);
            brandFourPanelContainer.Dock = DockStyle.Fill;
            brandFourPanelContainer.Location = new Point(384, 293);
            brandFourPanelContainer.Margin = new Padding(0);
            brandFourPanelContainer.Name = "brandFourPanelContainer";
            brandFourPanelContainer.Padding = new Padding(29, 33, 29, 33);
            brandFourPanelContainer.Size = new Size(384, 293);
            brandFourPanelContainer.TabIndex = 4;
            // 
            // brandFourPanel
            // 
            brandFourPanel.BackColor = Color.FromArgb(68, 68, 68);
            brandFourPanel.Controls.Add(pictureBox2);
            brandFourPanel.Controls.Add(brandFourPictureBox);
            brandFourPanel.Dock = DockStyle.Fill;
            brandFourPanel.Location = new Point(29, 33);
            brandFourPanel.Margin = new Padding(3, 4, 3, 4);
            brandFourPanel.Name = "brandFourPanel";
            brandFourPanel.Size = new Size(326, 227);
            brandFourPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngwing_com__2_;
            pictureBox2.Location = new Point(53, 17);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(223, 192);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseEnter += pictureBox_MouseEnter;
            pictureBox2.MouseLeave += pictureBox_MouseLeave;
            // 
            // brandFourPictureBox
            // 
            brandFourPictureBox.Location = new Point(0, -9);
            brandFourPictureBox.Margin = new Padding(3, 4, 3, 4);
            brandFourPictureBox.Name = "brandFourPictureBox";
            brandFourPictureBox.Size = new Size(326, 237);
            brandFourPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            brandFourPictureBox.TabIndex = 1;
            brandFourPictureBox.TabStop = false;
            // 
            // brandThreePanelContainer
            // 
            brandThreePanelContainer.Controls.Add(brandThreePanel);
            brandThreePanelContainer.Dock = DockStyle.Fill;
            brandThreePanelContainer.Location = new Point(0, 293);
            brandThreePanelContainer.Margin = new Padding(0);
            brandThreePanelContainer.Name = "brandThreePanelContainer";
            brandThreePanelContainer.Padding = new Padding(29, 33, 29, 33);
            brandThreePanelContainer.Size = new Size(384, 293);
            brandThreePanelContainer.TabIndex = 3;
            // 
            // brandThreePanel
            // 
            brandThreePanel.BackColor = Color.FromArgb(68, 68, 68);
            brandThreePanel.Controls.Add(pictureBox3);
            brandThreePanel.Dock = DockStyle.Fill;
            brandThreePanel.Location = new Point(29, 33);
            brandThreePanel.Margin = new Padding(3, 4, 3, 4);
            brandThreePanel.Name = "brandThreePanel";
            brandThreePanel.Size = new Size(326, 227);
            brandThreePanel.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pngwing2;
            pictureBox3.Location = new Point(69, 17);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(193, 191);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            pictureBox3.MouseEnter += pictureBox_MouseEnter;
            pictureBox3.MouseLeave += pictureBox_MouseLeave;
            // 
            // brandTwoPanelContainer
            // 
            brandTwoPanelContainer.Controls.Add(brandTwoPanel);
            brandTwoPanelContainer.Dock = DockStyle.Fill;
            brandTwoPanelContainer.Location = new Point(384, 0);
            brandTwoPanelContainer.Margin = new Padding(0);
            brandTwoPanelContainer.Name = "brandTwoPanelContainer";
            brandTwoPanelContainer.Padding = new Padding(29, 33, 29, 33);
            brandTwoPanelContainer.Size = new Size(384, 293);
            brandTwoPanelContainer.TabIndex = 2;
            // 
            // brandTwoPanel
            // 
            brandTwoPanel.BackColor = Color.FromArgb(68, 68, 68);
            brandTwoPanel.Controls.Add(brandTwoPictureBox);
            brandTwoPanel.Dock = DockStyle.Fill;
            brandTwoPanel.Location = new Point(29, 33);
            brandTwoPanel.Margin = new Padding(3, 4, 3, 4);
            brandTwoPanel.Name = "brandTwoPanel";
            brandTwoPanel.Size = new Size(326, 227);
            brandTwoPanel.TabIndex = 0;
            // 
            // brandTwoPictureBox
            // 
            brandTwoPictureBox.Image = Properties.Resources.pngwing_com__1_;
            brandTwoPictureBox.Location = new Point(54, 20);
            brandTwoPictureBox.Margin = new Padding(3, 4, 3, 4);
            brandTwoPictureBox.Name = "brandTwoPictureBox";
            brandTwoPictureBox.Size = new Size(223, 192);
            brandTwoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            brandTwoPictureBox.TabIndex = 1;
            brandTwoPictureBox.TabStop = false;
            brandTwoPictureBox.Click += brandTwoPictureBox_Click;
            brandTwoPictureBox.MouseEnter += pictureBox_MouseEnter;
            brandTwoPictureBox.MouseLeave += pictureBox_MouseLeave;
            // 
            // brandOnePanelContainer
            // 
            brandOnePanelContainer.Controls.Add(brandOnePanel);
            brandOnePanelContainer.Dock = DockStyle.Fill;
            brandOnePanelContainer.Location = new Point(0, 0);
            brandOnePanelContainer.Margin = new Padding(0);
            brandOnePanelContainer.Name = "brandOnePanelContainer";
            brandOnePanelContainer.Padding = new Padding(29, 33, 29, 33);
            brandOnePanelContainer.Size = new Size(384, 293);
            brandOnePanelContainer.TabIndex = 0;
            // 
            // brandOnePanel
            // 
            brandOnePanel.BackColor = Color.FromArgb(68, 68, 68);
            brandOnePanel.Controls.Add(brandOnePictureBox);
            brandOnePanel.Dock = DockStyle.Fill;
            brandOnePanel.Location = new Point(29, 33);
            brandOnePanel.Margin = new Padding(3, 4, 3, 4);
            brandOnePanel.Name = "brandOnePanel";
            brandOnePanel.Size = new Size(326, 227);
            brandOnePanel.TabIndex = 0;
            // 
            // brandOnePictureBox
            // 
            brandOnePictureBox.BackColor = Color.Transparent;
            brandOnePictureBox.Image = (Image)resources.GetObject("brandOnePictureBox.Image");
            brandOnePictureBox.Location = new Point(57, 27);
            brandOnePictureBox.Margin = new Padding(3, 4, 3, 4);
            brandOnePictureBox.Name = "brandOnePictureBox";
            brandOnePictureBox.Size = new Size(216, 171);
            brandOnePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            brandOnePictureBox.TabIndex = 0;
            brandOnePictureBox.TabStop = false;
            brandOnePictureBox.Click += brandOnePictureBox_Click;
            brandOnePictureBox.MouseEnter += pictureBox_MouseEnter;
            brandOnePictureBox.MouseLeave += pictureBox_MouseLeave;
            // 
            // selectionInstructionPanel
            // 
            selectionInstructionPanel.Controls.Add(selectionInstructionLabel);
            selectionInstructionPanel.Dock = DockStyle.Fill;
            selectionInstructionPanel.Location = new Point(387, 590);
            selectionInstructionPanel.Margin = new Padding(3, 4, 3, 4);
            selectionInstructionPanel.Name = "selectionInstructionPanel";
            selectionInstructionPanel.Size = new Size(378, 49);
            selectionInstructionPanel.TabIndex = 6;
            // 
            // selectionInstructionLabel
            // 
            selectionInstructionLabel.AutoSize = true;
            selectionInstructionLabel.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectionInstructionLabel.ForeColor = SystemColors.Control;
            selectionInstructionLabel.Location = new Point(97, 5);
            selectionInstructionLabel.Name = "selectionInstructionLabel";
            selectionInstructionLabel.Size = new Size(240, 34);
            selectionInstructionLabel.TabIndex = 1;
            selectionInstructionLabel.Text = "SELECT YOUR CAR BRAND";
            // 
            // CarSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 716);
            Controls.Add(mainTableLayout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CarSelection";
            Text = "CarSelection";
            mainTableLayout.ResumeLayout(false);
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)settingsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)notificationPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)signOutPictureBox).EndInit();
            brandsTableLayout.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            otherBrandPanelContainer.ResumeLayout(false);
            otherBrandPanel.ResumeLayout(false);
            brandFourPanelContainer.ResumeLayout(false);
            brandFourPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)brandFourPictureBox).EndInit();
            brandThreePanelContainer.ResumeLayout(false);
            brandThreePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            brandTwoPanelContainer.ResumeLayout(false);
            brandTwoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)brandTwoPictureBox).EndInit();
            brandOnePanelContainer.ResumeLayout(false);
            brandOnePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)brandOnePictureBox).EndInit();
            selectionInstructionPanel.ResumeLayout(false);
            selectionInstructionPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayout;
        private Panel profilePanel;
        private PictureBox settingsPictureBox;
        private PictureBox notificationPictureBox;
        private Label customerTypeLabel;
        private Label fullNameLabel;
        private PictureBox signOutPictureBox;
        private TableLayoutPanel brandsTableLayout;
        private Panel otherBrandPanelContainer;
        private Panel otherBrandPanel;
        private Panel brandFourPanelContainer;
        private Panel brandFourPanel;
        private Panel brandThreePanelContainer;
        private Panel brandThreePanel;
        private Panel brandTwoPanelContainer; // Corrected usage for brand two
        private Panel brandTwoPanel; // Corrected usage for brand two
        private Panel brandOnePanelContainer;
        private Panel brandOnePanel;
        private PictureBox brandOnePictureBox;
        private Label otherBrandLabel;
        private PictureBox brandFourPictureBox;
        private PictureBox brandTwoPictureBox; // Corrected usage for brand two
        private Panel selectionInstructionPanel;
        private Label selectionInstructionLabel;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}