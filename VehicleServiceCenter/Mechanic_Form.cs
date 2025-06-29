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
    public partial class Mechanic_Form : Form {
        private int loggedUserId;

        public Mechanic_Form(int id) {
            this.loggedUserId = id;
            InitializeComponent();
        }

        public Mechanic_Form() {
            InitializeComponent();
        }

        private void Mechanic_Form_Load(object sender, EventArgs e) {

        }
    }
}
