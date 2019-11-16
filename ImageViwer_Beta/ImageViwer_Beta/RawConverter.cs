using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick;
using System.Threading;

namespace ImageViwer_Beta
{
    public partial class RawConverter : Form
    {
        private readonly SynchronizationContext synchronizationContext;
        private DateTime previousTime = DateTime.Now;  
        List<string> rawlistvariable = new List<string>();
        string savePath;
        int pCurrentImage = -1;
        public RawConverter()
        {
            InitializeComponent();
            synchronizationContext = SynchronizationContext.Current;
            //this.comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.convert_combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void RawConverter_shown(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void openRaw_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "CANON|*.cr2;*.crw|NIKON|*.ORF|FUJI|*.raf|GIF|*.gif|TIFF|*.tiff";

            open.Multiselect = true;
            open.ValidateNames = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in open.FileNames)
                {
                    //FileInfo imginfo = new FileInfo(filename);
                    FileInfo rawinfo = new FileInfo(filename);
                    //imagelist.Add(imginfo.FullName);
                    //ImageListview.Items.Add(imginfo.Name, 0);
                    rawlistvariable.Add(rawinfo.FullName);
                    RawList.Items.Add(rawinfo.Name);
                }
            }
        }

        private void RawConverter_Load(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();

            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                savePath = folderBrowserDialog1.SelectedPath;
                SaveFileLocation.Text = savePath;
            }
        }

        private async void convert_btn_Click(object sender, EventArgs e)
        {
            string extention;
            extention = convert_combo.Text;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            timer.Start();
            progressBar1.Style = ProgressBarStyle.Continuous;
            try
            {
                await Task.Run(() =>
                {
                    foreach (string imageinraw in rawlistvariable)
                    {
                        using (MagickImage image = new MagickImage(imageinraw))
                        {
                            var oldfn = Path.GetFileName(imageinraw);
                            var newfn = Path.ChangeExtension(oldfn, extention);
                            var combine = Path.Combine(savePath, newfn);
                            image.Write(combine);
                        }
                        
                    }
                    progressBar1.Increment(100);
                    progressBar1.MarqueeAnimationSpeed = 0;
                    timer.Stop();
                });
            }
            catch (InvalidOperationException)
            {
                this.ShowDialog();
            }
            
        }
        public void UpdateUI(int value)
        {
            var timeNow = DateTime.Now;

            //Here we only refresh our UI each 50 ms  
            if ((DateTime.Now - previousTime).Milliseconds <= 50) return;

            //Send the update to our UI thread  
            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                label1.Text = @"Count : " + (int)o;
            }), value);

            previousTime = timeNow;
        } 

        private void RawList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 2;
            if(progressBar1.Value > 99){
                RawConverter rawloading = new RawConverter();
                rawloading.Show();
                this.Hide();
                timer.Enabled = false;
            }
        }

        private void remover_btn_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(RawList);
            if(RawList.SelectedIndex != -1){
                for (int i = selectedItems.Count - 1; i >= 0; i-- )
                {
                    RawList.Items.Remove(selectedItems[i]);
                }
                MessageBox.Show("Item removed");
            }
        }
    }
}
