namespace FullRealProject.Test
{
	partial class frmListTestAppointments
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
			this.btnAddAppointment = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvList = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnClose = new System.Windows.Forms.Button();
			this.pbTitleImage = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.ctlLocalDrivingLicenseApplicationInfo1 = new FullRealProject.Applications.LocalDrivingLicense.Controls.ctlLocalDrivingLicenseApplicationInfo();
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbTitleImage)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAddAppointment
			// 
			this.btnAddAppointment.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnAddAppointment.BackColor = System.Drawing.Color.White;
			this.btnAddAppointment.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddAppointment.Image = global::FullRealProject.Properties.Resources.AddAppointment_32;
			this.btnAddAppointment.Location = new System.Drawing.Point(867, 576);
			this.btnAddAppointment.Name = "btnAddAppointment";
			this.btnAddAppointment.Size = new System.Drawing.Size(45, 45);
			this.btnAddAppointment.TabIndex = 1;
			this.btnAddAppointment.UseVisualStyleBackColor = false;
			this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 573);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Appointments";
			// 
			// dgvList
			// 
			this.dgvList.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dgvList.BackgroundColor = System.Drawing.Color.White;
			this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvList.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvList.Location = new System.Drawing.Point(13, 627);
			this.dgvList.Name = "dgvList";
			this.dgvList.RowHeadersWidth = 51;
			this.dgvList.RowTemplate.Height = 24;
			this.dgvList.Size = new System.Drawing.Size(899, 128);
			this.dgvList.TabIndex = 3;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeTestToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(154, 42);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// takeTestToolStripMenuItem
			// 
			this.takeTestToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.Test_32;
			this.takeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
			this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(153, 38);
			this.takeTestToolStripMenuItem.Text = "Take Test";
			this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::FullRealProject.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(812, 761);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 45);
			this.btnClose.TabIndex = 15;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pbTitleImage
			// 
			this.pbTitleImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pbTitleImage.Image = global::FullRealProject.Properties.Resources.Vision_512;
			this.pbTitleImage.Location = new System.Drawing.Point(386, 0);
			this.pbTitleImage.Name = "pbTitleImage";
			this.pbTitleImage.Size = new System.Drawing.Size(150, 150);
			this.pbTitleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbTitleImage.TabIndex = 5;
			this.pbTitleImage.TabStop = false;
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.Red;
			this.lblTitle.Location = new System.Drawing.Point(354, 146);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(214, 42);
			this.lblTitle.TabIndex = 4;
			this.lblTitle.Text = "Vision Test";
			// 
			// ctlLocalDrivingLicenseApplicationInfo1
			// 
			this.ctlLocalDrivingLicenseApplicationInfo1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ctlLocalDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.White;
			this.ctlLocalDrivingLicenseApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctlLocalDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(11, 198);
			this.ctlLocalDrivingLicenseApplicationInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ctlLocalDrivingLicenseApplicationInfo1.Name = "ctlLocalDrivingLicenseApplicationInfo1";
			this.ctlLocalDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(900, 370);
			this.ctlLocalDrivingLicenseApplicationInfo1.TabIndex = 0;
			// 
			// frmListTestAppointments
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(924, 813);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.dgvList);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAddAppointment);
			this.Controls.Add(this.ctlLocalDrivingLicenseApplicationInfo1);
			this.Controls.Add(this.pbTitleImage);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmListTestAppointments";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmListTestAppointments";
			this.Load += new System.EventHandler(this.frmListTestAppointments_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbTitleImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Applications.LocalDrivingLicense.Controls.ctlLocalDrivingLicenseApplicationInfo ctlLocalDrivingLicenseApplicationInfo1;
		private System.Windows.Forms.Button btnAddAppointment;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvList;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.PictureBox pbTitleImage;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
	}
}