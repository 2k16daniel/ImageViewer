namespace ImageViwer_Beta
{
    partial class Photo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Picture_Panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Picture_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Picture_Panel
            // 
            this.Picture_Panel.AutoScroll = true;
            this.Picture_Panel.Controls.Add(this.pictureBox1);
            this.Picture_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Picture_Panel.Location = new System.Drawing.Point(0, 0);
            this.Picture_Panel.Name = "Picture_Panel";
            this.Picture_Panel.Size = new System.Drawing.Size(642, 381);
            this.Picture_Panel.TabIndex = 0;
            this.Picture_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Picture_Panel_Paint);
            // 
            // Photo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 381);
            this.Controls.Add(this.Picture_Panel);
            this.Name = "Photo";
            this.Text = "Photo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Photo_FormClosing);
            this.Load += new System.EventHandler(this.Photo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Picture_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Picture_Panel;



    }
}