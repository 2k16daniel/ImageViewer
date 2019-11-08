namespace ImageViwer_Beta
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ImageListview = new System.Windows.Forms.ListView();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRawPhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFullsizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseStudyTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bg2.png");
            // 
            // ImageListview
            // 
            this.ImageListview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageListview.LargeImageList = this.imageList1;
            this.ImageListview.Location = new System.Drawing.Point(12, 35);
            this.ImageListview.Name = "ImageListview";
            this.ImageListview.Size = new System.Drawing.Size(207, 257);
            this.ImageListview.TabIndex = 2;
            this.ImageListview.UseCompatibleStateImageBehavior = false;
            this.ImageListview.ItemActivate += new System.EventHandler(this.ImageListview_ItemActivate);
            this.ImageListview.SelectedIndexChanged += new System.EventHandler(this.ImageList_SelectedIndexChanged);
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Location = new System.Drawing.Point(34, 23);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(751, 442);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPictureBox.TabIndex = 6;
            this.MainPictureBox.TabStop = false;
            this.MainPictureBox.Click += new System.EventHandler(this.MainPictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.MainPictureBox);
            this.panel1.Location = new System.Drawing.Point(243, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 489);
            this.panel1.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPhotoToolStripMenuItem,
            this.openRawPhotoToolStripMenuItem,
            this.rawConverterToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageMetadataToolStripMenuItem});
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.propertiesToolStripMenuItem.Text = "Properties";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewFullsizeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caseStudyTeamToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.tutorialToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openPhotoToolStripMenuItem
            // 
            this.openPhotoToolStripMenuItem.Name = "openPhotoToolStripMenuItem";
            this.openPhotoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openPhotoToolStripMenuItem.Text = "Open Photo";
            // 
            // openRawPhotoToolStripMenuItem
            // 
            this.openRawPhotoToolStripMenuItem.Name = "openRawPhotoToolStripMenuItem";
            this.openRawPhotoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openRawPhotoToolStripMenuItem.Text = "Open Raw Photo";
            // 
            // rawConverterToolStripMenuItem
            // 
            this.rawConverterToolStripMenuItem.Name = "rawConverterToolStripMenuItem";
            this.rawConverterToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.rawConverterToolStripMenuItem.Text = "Raw Converter";
            // 
            // imageMetadataToolStripMenuItem
            // 
            this.imageMetadataToolStripMenuItem.Name = "imageMetadataToolStripMenuItem";
            this.imageMetadataToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.imageMetadataToolStripMenuItem.Text = "Image Metadata";
            // 
            // viewFullsizeToolStripMenuItem
            // 
            this.viewFullsizeToolStripMenuItem.Name = "viewFullsizeToolStripMenuItem";
            this.viewFullsizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewFullsizeToolStripMenuItem.Text = "View Full-size ";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.tutorialToolStripMenuItem.Text = "Tutorial";
            // 
            // caseStudyTeamToolStripMenuItem
            // 
            this.caseStudyTeamToolStripMenuItem.Name = "caseStudyTeamToolStripMenuItem";
            this.caseStudyTeamToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.caseStudyTeamToolStripMenuItem.Text = "Case Study Team";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ImageListview);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ImageListview;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPhotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRawPhotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawConverterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageMetadataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFullsizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caseStudyTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
    }
}

