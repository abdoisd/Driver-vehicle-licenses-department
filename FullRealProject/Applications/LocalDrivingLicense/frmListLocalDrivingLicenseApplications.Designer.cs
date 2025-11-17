namespace FullRealProject.Applications
{
	partial class frmListLocalDrivingLicenseApplications
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
			this.cbFilter = new System.Windows.Forms.ComboBox();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbFilterBy = new System.Windows.Forms.ComboBox();
			this.btnAddPerson = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editLocalDrivingLicenseApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.scheduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.visionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.writtenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.streetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.issueDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pbMainImage
			// 
			this.pbMainImage.Image = global::FullRealProject.Properties.Resources.Application_Types_512;
			this.pbMainImage.Location = new System.Drawing.Point(602, 64);
			// 
			// lblTitle
			// 
			this.lblTitle.Location = new System.Drawing.Point(383, 9);
			this.lblTitle.Size = new System.Drawing.Size(638, 44);
			this.lblTitle.Text = "Local Driving License Applications";
			// 
			// cbFilter
			// 
			this.cbFilter.FormattingEnabled = true;
			this.cbFilter.Location = new System.Drawing.Point(126, 236);
			this.cbFilter.Margin = new System.Windows.Forms.Padding(33, 13, 33, 13);
			this.cbFilter.Name = "cbFilter";
			this.cbFilter.Size = new System.Drawing.Size(195, 33);
			this.cbFilter.TabIndex = 22;
			this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
			// 
			// txtFilter
			// 
			this.txtFilter.Location = new System.Drawing.Point(336, 236);
			this.txtFilter.Margin = new System.Windows.Forms.Padding(33, 13, 33, 13);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(163, 30);
			this.txtFilter.TabIndex = 21;
			this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
			this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 236);
			this.label2.Margin = new System.Windows.Forms.Padding(33, 0, 33, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 28);
			this.label2.TabIndex = 20;
			this.label2.Text = "Filter By:";
			// 
			// cbFilterBy
			// 
			this.cbFilterBy.FormattingEnabled = true;
			this.cbFilterBy.Location = new System.Drawing.Point(336, 236);
			this.cbFilterBy.Margin = new System.Windows.Forms.Padding(33, 13, 33, 13);
			this.cbFilterBy.Name = "cbFilterBy";
			this.cbFilterBy.Size = new System.Drawing.Size(163, 33);
			this.cbFilterBy.TabIndex = 23;
			this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
			// 
			// btnAddPerson
			// 
			this.btnAddPerson.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnAddPerson.AutoSize = true;
			this.btnAddPerson.BackColor = System.Drawing.Color.White;
			this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddPerson.Image = global::FullRealProject.Properties.Resources.ApplicationType1;
			this.btnAddPerson.Location = new System.Drawing.Point(1316, 214);
			this.btnAddPerson.Margin = new System.Windows.Forms.Padding(55, 26, 55, 26);
			this.btnAddPerson.Name = "btnAddPerson";
			this.btnAddPerson.Size = new System.Drawing.Size(75, 55);
			this.btnAddPerson.TabIndex = 24;
			this.btnAddPerson.UseVisualStyleBackColor = false;
			this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripMenuItem,
            this.toolStripSeparator1,
            this.cancelApplicationToolStripMenuItem,
            this.editLocalDrivingLicenseApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripSeparator2,
            this.scheduleTestToolStripMenuItem,
            this.toolStripSeparator3,
            this.issueDrivingLicenseToolStripMenuItem,
            this.viewLicenseToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(231, 316);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// showInfoToolStripMenuItem
			// 
			this.showInfoToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.License_View_32;
			this.showInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.showInfoToolStripMenuItem.Name = "showInfoToolStripMenuItem";
			this.showInfoToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
			this.showInfoToolStripMenuItem.Text = "Show Info";
			this.showInfoToolStripMenuItem.Click += new System.EventHandler(this.showInfoToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
			// 
			// cancelApplicationToolStripMenuItem
			// 
			this.cancelApplicationToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.Delete_32;
			this.cancelApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
			this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
			this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
			this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
			// 
			// editLocalDrivingLicenseApplicationToolStripMenuItem
			// 
			this.editLocalDrivingLicenseApplicationToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.edit_32;
			this.editLocalDrivingLicenseApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.editLocalDrivingLicenseApplicationToolStripMenuItem.Name = "editLocalDrivingLicenseApplicationToolStripMenuItem";
			this.editLocalDrivingLicenseApplicationToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
			this.editLocalDrivingLicenseApplicationToolStripMenuItem.Text = "Edit Application";
			this.editLocalDrivingLicenseApplicationToolStripMenuItem.Click += new System.EventHandler(this.addLocalDrivingLicenseApplicationToolStripMenuItem_Click);
			// 
			// deleteApplicationToolStripMenuItem
			// 
			this.deleteApplicationToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.Delete_32;
			this.deleteApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
			this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
			this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
			this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(227, 6);
			// 
			// scheduleTestToolStripMenuItem
			// 
			this.scheduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTestToolStripMenuItem,
            this.writtenTestToolStripMenuItem,
            this.streetTestToolStripMenuItem});
			this.scheduleTestToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.Schedule_Test_32;
			this.scheduleTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.scheduleTestToolStripMenuItem.Name = "scheduleTestToolStripMenuItem";
			this.scheduleTestToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
			this.scheduleTestToolStripMenuItem.Text = "Schedule Test";
			this.scheduleTestToolStripMenuItem.DropDownOpening += new System.EventHandler(this.scheduleTestToolStripMenuItem_DropDownOpening);
			// 
			// visionTestToolStripMenuItem
			// 
			this.visionTestToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.Vision_Test_32;
			this.visionTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
			this.visionTestToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
			this.visionTestToolStripMenuItem.Text = "Vision Test";
			this.visionTestToolStripMenuItem.Click += new System.EventHandler(this.visionTestToolStripMenuItem_Click);
			// 
			// writtenTestToolStripMenuItem
			// 
			this.writtenTestToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.Written_Test_32;
			this.writtenTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.writtenTestToolStripMenuItem.Name = "writtenTestToolStripMenuItem";
			this.writtenTestToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
			this.writtenTestToolStripMenuItem.Text = "Written Test";
			this.writtenTestToolStripMenuItem.Click += new System.EventHandler(this.writtenTestToolStripMenuItem_Click);
			// 
			// streetTestToolStripMenuItem
			// 
			this.streetTestToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.Street_Test_32;
			this.streetTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.streetTestToolStripMenuItem.Name = "streetTestToolStripMenuItem";
			this.streetTestToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
			this.streetTestToolStripMenuItem.Text = "Street Test";
			this.streetTestToolStripMenuItem.Click += new System.EventHandler(this.streetTestToolStripMenuItem_Click);
			// 
			// issueDrivingLicenseToolStripMenuItem
			// 
			this.issueDrivingLicenseToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.IssueDrivingLicense_32;
			this.issueDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.issueDrivingLicenseToolStripMenuItem.Name = "issueDrivingLicenseToolStripMenuItem";
			this.issueDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
			this.issueDrivingLicenseToolStripMenuItem.Text = "Issue Driving License";
			this.issueDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseToolStripMenuItem_Click);
			// 
			// viewLicenseToolStripMenuItem
			// 
			this.viewLicenseToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.License_View_32;
			this.viewLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.viewLicenseToolStripMenuItem.Name = "viewLicenseToolStripMenuItem";
			this.viewLicenseToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
			this.viewLicenseToolStripMenuItem.Text = "View License";
			this.viewLicenseToolStripMenuItem.Click += new System.EventHandler(this.viewLicenseToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(227, 6);
			// 
			// frmListLocalDrivingLicenseApplications
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1404, 753);
			this.Controls.Add(this.btnAddPerson);
			this.Controls.Add(this.cbFilter);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbFilterBy);
			this.Controls.Add(this.txtFilter);
			this.Name = "frmListLocalDrivingLicenseApplications";
			this.Text = "frmListLocalDrivingLicenseApplications";
			this.Load += new System.EventHandler(this.frmListLocalDrivingLicenseApplications_Load);
			this.Controls.SetChildIndex(this.txtFilter, 0);
			this.Controls.SetChildIndex(this.cbFilterBy, 0);
			this.Controls.SetChildIndex(this.lblTitle, 0);
			this.Controls.SetChildIndex(this.pbMainImage, 0);
			this.Controls.SetChildIndex(this.btnClose, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.cbFilter, 0);
			this.Controls.SetChildIndex(this.btnAddPerson, 0);
			((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbFilter;
		private System.Windows.Forms.TextBox txtFilter;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbFilterBy;
		private System.Windows.Forms.Button btnAddPerson;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem editLocalDrivingLicenseApplicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showInfoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem scheduleTestToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem visionTestToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem writtenTestToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem streetTestToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem viewLicenseToolStripMenuItem;
	}
}