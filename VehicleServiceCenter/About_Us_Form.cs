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
    public partial class About_Us_Form : Form
    {
        public About_Us_Form()
        {
            InitializeComponent();
        }

        private void PanelProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void About_Us_Form_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1024, 576);
            this.MaximumSize = new Size(1024, 576);
            this.MinimumSize = new Size(1024, 576);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
    }
}
