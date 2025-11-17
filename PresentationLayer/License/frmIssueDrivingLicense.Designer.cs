namespace FullRealProject.License
{
	partial class frmIssueDrivingLicense
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
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.ctlLocalDrivingLicenseApplicationInfo1 = new FullRealProject.Applications.LocalDrivingLicense.Controls.ctlLocalDrivingLicenseApplicationInfo();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = global::FullRealProject.Properties.Resources.Save_32;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(814, 527);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 50);
			this.btnSave.TabIndex = 27;
			this.btnSave.Text = "Save";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::FullRealProject.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(708, 527);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 50);
			this.btnClose.TabIndex = 28;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// ctlLocalDrivingLicenseApplicationInfo1
			// 
			this.ctlLocalDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.White;
			this.ctlLocalDrivingLicenseApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctlLocalDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(13, 14);
			this.ctlLocalDrivingLicenseApplicationInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ctlLocalDrivingLicenseApplicationInfo1.Name = "ctlLocalDrivingLicenseApplicationInfo1";
			this.ctlLocalDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(900, 370);
			this.ctlLocalDrivingLicenseApplicationInfo1.TabIndex = 29;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 389);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 25);
			this.label1.TabIndex = 30;
			this.label1.Text = "Notes:";
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(124, 392);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(790, 125);
			this.txtNotes.TabIndex = 31;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::FullRealProject.Properties.Resources.Notes_32;
			this.pictureBox1.Location = new System.Drawing.Point(86, 392);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 32;
			this.pictureBox1.TabStop = false;
			// 
			// frmIssueDrivingLicense
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(926, 589);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtNotes);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ctlLocalDrivingLicenseApplicationInfo1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnClose);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmIssueDrivingLicense";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmIssueDrivingLicense";
			this.Load += new System.EventHandler(this.frmIssueDrivingLicense_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private Applications.LocalDrivingLicense.Controls.ctlLocalDrivingLicenseApplicationInfo ctlLocalDrivingLicenseApplicationInfo1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}