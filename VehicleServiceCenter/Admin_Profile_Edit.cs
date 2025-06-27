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
    public partial class Admin_Profile_Edit : Form
    {
        public Admin_Profile_Edit()
        {
            InitializeComponent();
        }

        private void signOutPictureBox_Click(object sender, EventArgs e)
        {
          
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AdminForm a1 = new AdminForm();
            a1.Show();
            this.Hide();
        }
    }
}
