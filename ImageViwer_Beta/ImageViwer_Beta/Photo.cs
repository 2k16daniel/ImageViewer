using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViwer_Beta
{
    public partial class Photo : Form
    {
        public Photo()
        {
            InitializeComponent();
        }

        public Image imagebox
        {
            set
            {
                this.pictureBox1.Image = value;
                this.pictureBox1.Size = value.Size;
            }
        }

        private void Photo_Load(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                //pictureBox1.Dispose();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Picture_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
