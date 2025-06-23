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
        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(178, 178, 178);
            }
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.FromArgb(68, 68, 68);
            }
        }

        private void ToyotaForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
