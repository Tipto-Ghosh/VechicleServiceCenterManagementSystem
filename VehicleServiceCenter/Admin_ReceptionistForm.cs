using FontAwesome.Sharp;
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
    public partial class Admin_ReceptionistForm : Form
    {
        
        public Admin_ReceptionistForm()
        {
            InitializeComponent();
            BtnReceptionist.BackColor = Color.FromArgb(136, 136, 136);
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

        private void btnMechanic_Click(object sender, EventArgs e)
        {
            Admin_Mechanic m1 = new Admin_Mechanic();   
            m1.Show();
            this.Hide();
        }
    }
}
