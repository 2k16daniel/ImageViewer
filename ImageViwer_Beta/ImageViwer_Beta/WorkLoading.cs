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
    public partial class WorkLoading : Form
    {
        public WorkLoading()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 2;
            if (progressBar1.Value > 99)
            {
                RawConverter rawloading = new RawConverter();
                rawloading.Show();
                this.Hide();
                timer.Enabled = false;
            }
        }
    

        private void WorkLoading_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }
}
}