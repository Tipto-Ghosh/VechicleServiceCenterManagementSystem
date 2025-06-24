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
    public partial class Admin_Mechanic : Form
    {
        public Admin_Mechanic()
        {
            InitializeComponent();
            btnMechanic.BackColor = Color.FromArgb(136, 136, 136);
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminForm a1 = new AdminForm();
            a1.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            AdminCustomerForm a1 = new AdminCustomerForm();
            a1.Show();
            this.Hide();
        }

        private void BtnReceptionist_Click(object sender, EventArgs e)
        {
            Admin_ReceptionistForm r1 = new Admin_ReceptionistForm();
            r1.Show();
            this.Hide();
        }
    }
}
