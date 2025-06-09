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
    public partial class ToyotaForm : Form
    {
        public ToyotaForm()
        {
            InitializeComponent();
            
        }
        private void pictureBox19_MouseEnter(object sender, EventArgs e)
        {
            pictureBox19.BackColor = Color.FromArgb(68, 68, 68);
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            pictureBox19.BackColor = Color.Transparent; 
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            


            CarSelection newForm = new CarSelection();
            newForm.Show();

            
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
        

    }
}
