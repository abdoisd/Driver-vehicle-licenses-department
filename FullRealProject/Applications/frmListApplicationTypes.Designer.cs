namespace FullRealProject
{
	partial class frmListApplicationTypes
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
			((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(1291, 690);
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pbMainImage
			// 
			this.pbMainImage.Image = global::FullRealProject.Properties.Resources.Application_Types_512;
			// 
			// lblTitle
			// 
			this.lblTitle.Location = new System.Drawing.Point(496, 224);
			this.lblTitle.Size = new System.Drawing.Size(412, 44);
			this.lblTitle.Text = "List Application Types";
			// 
			// frmListApplicationTypes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1404, 753);
			this.Margin = new System.Windows.Forms.Padding(1);
			this.Name = "frmListApplicationTypes";
			this.Text = "frmListApplicationTypes";
			this.Load += new System.EventHandler(this.frmListApplicationTypes_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
	}
}