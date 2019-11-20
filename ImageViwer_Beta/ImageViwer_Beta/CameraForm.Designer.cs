namespace ImageViwer_Beta
{
    partial class CameraForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseCameraDirectory = new System.Windows.Forms.TextBox();
            this.browse_btn = new System.Windows.Forms.Button();
            this.set_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Directory";
            // 
            // BrowseCameraDirectory
            // 
            this.BrowseCameraDirectory.Location = new System.Drawing.Point(12, 25);
            this.BrowseCameraDirectory.Name = "BrowseCameraDirectory";
            this.BrowseCameraDirectory.Size = new System.Drawing.Size(293, 20);
            this.BrowseCameraDirectory.TabIndex = 9;
            // 
            // browse_btn
            // 
            this.browse_btn.Location = new System.Drawing.Point(12, 51);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(129, 23);
            this.browse_btn.TabIndex = 8;
            this.browse_btn.Text = "browse";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // set_btn
            // 
            this.set_btn.Location = new System.Drawing.Point(224, 51);
            this.set_btn.Name = "set_btn";
            this.set_btn.Size = new System.Drawing.Size(81, 23);
            this.set_btn.TabIndex = 10;
            this.set_btn.Text = "Set";
            this.set_btn.UseVisualStyleBackColor = true;
            this.set_btn.Click += new System.EventHandler(this.set_btn_Click);
            // 
            // CameraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 86);
            this.Controls.Add(this.set_btn);
            this.Controls.Add(this.BrowseCameraDirectory);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.label1);
            this.Name = "CameraForm";
            this.Text = "Camera File Directory";
            this.Load += new System.EventHandler(this.CameraForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BrowseCameraDirectory;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.Button set_btn;
    }
}