namespace FullRealProject
{
	partial class frmListTestTypes
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
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbMainImage
			// 
			this.pbMainImage.Image = global::FullRealProject.Properties.Resources.TestType_512;
			// 
			// lblTitle
			// 
			this.lblTitle.Location = new System.Drawing.Point(523, 224);
			this.lblTitle.Size = new System.Drawing.Size(358, 44);
			this.lblTitle.Text = "Manage Test Types";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTestToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(227, 70);
			// 
			// editTestToolStripMenuItem
			// 
			this.editTestToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.edit_32;
			this.editTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.editTestToolStripMenuItem.Name = "editTestToolStripMenuItem";
			this.editTestToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
			this.editTestToolStripMenuItem.Text = "Edit Test";
			this.editTestToolStripMenuItem.Click += new System.EventHandler(this.editTestToolStripMenuItem_Click);
			// 
			// frmListTestTypes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1404, 753);
			this.Name = "frmListTestTypes";
			this.Text = "frmListTestTypes";
			this.Load += new System.EventHandler(this.frmListTestTypes_Load);
			this.Controls.SetChildIndex(this.lblTitle, 0);
			this.Controls.SetChildIndex(this.pbMainImage, 0);
			this.Controls.SetChildIndex(this.btnClose, 0);
			((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem editTestToolStripMenuItem;
	}
}