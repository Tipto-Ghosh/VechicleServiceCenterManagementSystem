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
    public partial class Payment_form : Form
    {
        public Payment_form()
        {
            InitializeComponent();
        }

        private void Payment_form_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1024, 576);
            this.MaximumSize = new Size(1024, 576);
            this.MinimumSize = new Size(1024, 576);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
