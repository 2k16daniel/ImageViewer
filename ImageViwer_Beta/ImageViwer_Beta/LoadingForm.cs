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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            StartBackgroundWork();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {

        }
        private void StartBackgroundWork()
        {
            if (Application.RenderWithVisualStyles)
                progressBar.Style = ProgressBarStyle.Marquee;
            else
            {
                progressBar.Style = ProgressBarStyle.Continuous;
                progressBar.Maximum = 100;
                progressBar.Value = 0;
                timer.Enabled = true;
            }
            backgroundWorker.RunWorkerAsync();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < progressBar.Maximum)
                progressBar.Increment(5);
            else
                progressBar.Value = progressBar.Minimum;
        }
    }
}
