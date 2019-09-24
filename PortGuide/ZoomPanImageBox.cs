/* 
 * Developed by Shannon Young.  http://www.smallwisdom.com
 * Copyright 2005
 * 
 * You are welcome to use, edit, and redistribute this code.
 * 
 */

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Smallwisdom.Windows.Forms
{
	/// <summary>
	/// ZoomPanImageBox is a specialized ImageBox with Pan and Zoom control.
	/// </summary>
	public class ZoomPanImageBox : System.Windows.Forms.UserControl
	{
		/// <summary>
		/// The zoom factor for this control.  Currently, it is hardcoded, 
		/// but perhaps a nice addition would be to set this?
		/// </summary>
		private double[] zoomFactor = {.25, .33, .50, .66, .80, 1, 1.25, 1.5, 2.0, 2.5, 3.0};
		private System.Windows.Forms.Panel imagePanel;
		private System.Windows.Forms.PictureBox imgBox;

		// zoom controls
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TrackBar scrollZoom;
		private System.Windows.Forms.Label lblMax;
		private System.Windows.Forms.Label lblMin;
		private System.Windows.Forms.Label lblCenter;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		#region Construct, Dispose

		public ZoomPanImageBox()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Initialize anything not included in the designer
			init();
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblMax = new System.Windows.Forms.Label();
			this.lblMin = new System.Windows.Forms.Label();
			this.lblCenter = new System.Windows.Forms.Label();
			this.scrollZoom = new System.Windows.Forms.TrackBar();
			this.imgBox = new System.Windows.Forms.PictureBox();
			this.imagePanel = new System.Windows.Forms.Panel();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scrollZoom)).BeginInit();
			this.imagePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lblMax);
			this.groupBox1.Controls.Add(this.lblMin);
			this.groupBox1.Controls.Add(this.lblCenter);
			this.groupBox1.Controls.Add(this.scrollZoom);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(817, 96);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Zoom Control";
			// 
			// lblMax
			// 
			this.lblMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMax.Location = new System.Drawing.Point(736, 64);
			this.lblMax.Name = "lblMax";
			this.lblMax.Size = new System.Drawing.Size(72, 23);
			this.lblMax.TabIndex = 3;
			this.lblMax.Text = "300%";
			this.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblMin
			// 
			this.lblMin.Location = new System.Drawing.Point(16, 64);
			this.lblMin.Name = "lblMin";
			this.lblMin.Size = new System.Drawing.Size(56, 23);
			this.lblMin.TabIndex = 2;
			this.lblMin.Text = "25%";
			this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCenter
			// 
			this.lblCenter.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblCenter.Location = new System.Drawing.Point(380, 64);
			this.lblCenter.Name = "lblCenter";
			this.lblCenter.Size = new System.Drawing.Size(64, 23);
			this.lblCenter.TabIndex = 1;
			this.lblCenter.Text = "100%";
			this.lblCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// scrollZoom
			// 
			this.scrollZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.scrollZoom.Enabled = false;
			this.scrollZoom.LargeChange = 1;
			this.scrollZoom.Location = new System.Drawing.Point(16, 24);
			this.scrollZoom.Name = "scrollZoom";
			this.scrollZoom.Size = new System.Drawing.Size(792, 64);
			this.scrollZoom.TabIndex = 0;
			this.scrollZoom.Value = 5;
			this.scrollZoom.Scroll += new System.EventHandler(this.scrollZoom_Scroll);
			// 
			// imgBox
			// 
			this.imgBox.Location = new System.Drawing.Point(0, 0);
			this.imgBox.Name = "imgBox";
			this.imgBox.Size = new System.Drawing.Size(200, 200);
			this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgBox.TabIndex = 6;
			this.imgBox.TabStop = false;
			// 
			// imagePanel
			// 
			this.imagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.imagePanel.AutoScroll = true;
			this.imagePanel.Controls.Add(this.imgBox);
			this.imagePanel.Location = new System.Drawing.Point(0, 96);
			this.imagePanel.Name = "imagePanel";
			this.imagePanel.Size = new System.Drawing.Size(816, 512);
			this.imagePanel.TabIndex = 7;
			// 
			// ZoomPanImageBox
			// 
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.imagePanel);
			this.Name = "ZoomPanImageBox";
			this.Size = new System.Drawing.Size(824, 608);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scrollZoom)).EndInit();
			this.imagePanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Initialization code goes here.
		/// </summary>
		private void init()
		{
			// Add keydown event handler to check if this is a Ctrl+ or Ctrl-
			// If so, then it will change the zoom scroll.
			this.KeyDown +=new KeyEventHandler(ImageBoxPanZoom_KeyDown);
		}

		/// <summary>
		/// Image loaded into the box.
		/// </summary>
		[Browsable(true),
		Description("Image loaded into the box.")]
		public Image Image
		{
			get
			{
				return imgBox.Image;
			}
			set
			{
				// Set the image value
				imgBox.Image = value;

				// enable the zoom control if this is not a null image
				scrollZoom.Enabled = (value != null);

				if (scrollZoom.Enabled)
				{
					// reset zoom control
					scrollZoom.Value = this.scrollZoom.Maximum/2;

					// Initially, the zoom factor is 100% so set the
					// ImageBox size equal to the Image size.
					imgBox.Size = value.Size;
				}
				else
				{
					// If null image, then reset the imgBox size
					// to the size of the panel so that there are no
					// scroll bars.
					imgBox.Size = imagePanel.Size;
				}
			}
		}

		private void ImageBoxPanZoom_KeyDown(object sender, KeyEventArgs e)
		{
			// Was the key combination that was pressed Ctrl+ or Ctrl-?
			// If so, then change the zoom level (but only if the zoom
			// is enabled)
			if (scrollZoom.Enabled) 
			{
				// Note: The e.KeyData is the combination of all the
				// keys currently pressed down.  To find out if this is
				// the Ctrl key *and* the + key, you "or" the Keys 
				// together. This is a bitwise "or" rather than the 
				// || symbol used for boolean logic.

				if((e.KeyData == (Keys.Oemplus | Keys.Control)) &&
					(scrollZoom.Value != scrollZoom.Maximum))
				{
					scrollZoom.Value++;
					setZoom();
				}
				else if ((e.KeyData == (Keys.OemMinus | Keys.Control)) &&
					(scrollZoom.Value != scrollZoom.Minimum))
				{
					scrollZoom.Value--;
					setZoom();
				}
			}
		}

		private void scrollZoom_Scroll(object sender, System.EventArgs e)
		{
			setZoom();
		}

		private void setZoom()
		{
			// The scrollZoom changed so reset the zoom factor
			// based on the scrollZoom TrackBar position.
			double newZoom = zoomFactor[scrollZoom.Value];

			// Set the ImageBox width and height to the new zoom
			// factor by multiplying the Image inside the Imagebox
			// by the new zoom factor.
			imgBox.Width = Convert.ToInt32 ( imgBox.Image.Width * newZoom); 
			imgBox.Height = Convert.ToInt32 ( imgBox.Image.Height * newZoom );
		}

	}// end class
}// end namespace
