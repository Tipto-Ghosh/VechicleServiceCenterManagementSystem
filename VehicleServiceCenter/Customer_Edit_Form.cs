using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleServiceCenter
{
    public partial class Customer_Edit_Form : Form
    {
        public Customer_Edit_Form()
        {
            InitializeComponent();
            iconButton3.BackColor = Color.FromArgb(136, 136, 136);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Customer_HomeForm c1 = new Customer_HomeForm();
            c1.Show();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ShopForm s1 = new ShopForm();
            s1._previousForm = this;
            s1.Show();
            this.Hide();
        }
    }
}
