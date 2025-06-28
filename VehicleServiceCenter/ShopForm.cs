namespace VehicleServiceCenter
{
    public partial class ShopForm : Form {
        public Form _previousForm;


        private int loggedCusId;
        public ShopForm(int id) {
            this.loggedCusId = id;
            InitializeComponent();
            SetLabelText();
        }
        public ShopForm() {
            InitializeComponent();
            SetLabelText();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e) {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e) {

        }


        private void pictureBox9_Click(object sender, EventArgs e) {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }
        private void SetLabelText() {
            label5.Text = "408/1 (Old KA 66/1), Kuratoli,\t Khilkhet, Dhaka 1229, Bangladesh";
            label5.AutoSize = false;
            label5.Size = new Size(200, 60);
        }

        private void pictureBox19_Click(object sender, EventArgs e) {
            _previousForm.Show();
            this.Close();
        }

        private void ShopForm_Load(object sender, EventArgs e) {

        }
    }
}
