namespace FullRealProject.Applications.LocalDrivingLicense
{
	partial class frmShowLocalDrivingLicenseApplication
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
			this.btnClose = new System.Windows.Forms.Button();
			this.ctlLocalDrivingLicenseApplicationInfo1 = new FullRealProject.Applications.LocalDrivingLicense.Controls.ctlLocalDrivingLicenseApplicationInfo();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnClose.Image = global::FullRealProject.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(813, 377);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 50);
			this.btnClose.TabIndex = 13;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// ctlLocalDrivingLicenseApplicationInfo1
			// 
			this.ctlLocalDrivingLicenseApplicationInfo1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ctlLocalDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.White;
			this.ctlLocalDrivingLicenseApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctlLocalDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(13, 8);
			this.ctlLocalDrivingLicenseApplicationInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ctlLocalDrivingLicenseApplicationInfo1.Name = "ctlLocalDrivingLicenseApplicationInfo1";
			this.ctlLocalDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(900, 370);
			this.ctlLocalDrivingLicenseApplicationInfo1.TabIndex = 0;
			// 
			// frmShowLocalDrivingLicenseApplication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(928, 439);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.ctlLocalDrivingLicenseApplicationInfo1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmShowLocalDrivingLicenseApplication";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmShowLocalDrivingLicenseApplication";
			this.Load += new System.EventHandler(this.frmShowLocalDrivingLicenseApplication_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.ctlLocalDrivingLicenseApplicationInfo ctlLocalDrivingLicenseApplicationInfo1;
		private System.Windows.Forms.Button btnClose;
	}
}