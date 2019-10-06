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
            this.Button_PicOpen = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ImageListview = new System.Windows.Forms.ListView();
            this.bttn_fullsize = new System.Windows.Forms.Button();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_PicOpen
            // 
            this.Button_PicOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_PicOpen.Location = new System.Drawing.Point(12, 463);
            this.Button_PicOpen.Name = "Button_PicOpen";
            this.Button_PicOpen.Size = new System.Drawing.Size(104, 32);
            this.Button_PicOpen.TabIndex = 1;
            this.Button_PicOpen.Text = "OPEN";
            this.Button_PicOpen.UseVisualStyleBackColor = true;
            this.Button_PicOpen.Click += new System.EventHandler(this.Button_PicOpen_Click);
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
            this.ImageListview.Location = new System.Drawing.Point(12, 12);
            this.ImageListview.Name = "ImageListview";
            this.ImageListview.Size = new System.Drawing.Size(201, 445);
            this.ImageListview.TabIndex = 2;
            this.ImageListview.UseCompatibleStateImageBehavior = false;
            this.ImageListview.ItemActivate += new System.EventHandler(this.ImageListview_ItemActivate);
            this.ImageListview.SelectedIndexChanged += new System.EventHandler(this.ImageList_SelectedIndexChanged);
            // 
            // bttn_fullsize
            // 
            this.bttn_fullsize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_fullsize.AutoSize = true;
            this.bttn_fullsize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttn_fullsize.Location = new System.Drawing.Point(698, 500);
            this.bttn_fullsize.Name = "bttn_fullsize";
            this.bttn_fullsize.Size = new System.Drawing.Size(114, 23);
            this.bttn_fullsize.TabIndex = 5;
            this.bttn_fullsize.Text = "View in fullsize mode";
            this.bttn_fullsize.UseVisualStyleBackColor = true;
            this.bttn_fullsize.Click += new System.EventHandler(this.bttn_fullsize_Click);
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Location = new System.Drawing.Point(39, 41);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(751, 442);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPictureBox.TabIndex = 6;
            this.MainPictureBox.TabStop = false;
            this.MainPictureBox.Click += new System.EventHandler(this.MainPictureBox_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(99, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Metadata Tester";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.MainPictureBox);
            this.panel1.Controls.Add(this.bttn_fullsize);
            this.panel1.Location = new System.Drawing.Point(236, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 538);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ImageListview);
            this.Controls.Add(this.Button_PicOpen);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_PicOpen;
        private System.Windows.Forms.ListView ImageListview;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button bttn_fullsize;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

