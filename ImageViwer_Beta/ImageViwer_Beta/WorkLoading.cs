using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViwer_Beta
{
    public partial class WorkLoading : Form
    {
        private readonly SynchronizationContext synchronizationContext;  
        private DateTime previousTime = DateTime.Now; 

        public WorkLoading()
        {
            InitializeComponent();
            toggleLoadingScreen();
            synchronizationContext = SynchronizationContext.Current;
            
        }

        private void WorkLoading_Load(object sender, EventArgs e)
        {

        }
        void WorkLoading_shown(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        void toggleLoadingScreen()
        {
            
        }
        
}
}