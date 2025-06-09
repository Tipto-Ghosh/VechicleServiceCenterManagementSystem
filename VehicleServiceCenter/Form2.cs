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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SetLabelText();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }


        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void SetLabelText()
        {
            label5.Text = "408/1 (Old KA 66/1), Kuratoli,\t Khilkhet, Dhaka 1229, Bangladesh";
            label5.AutoSize = false;
            label5.Size = new Size(200, 60);
        }

        }
    }
