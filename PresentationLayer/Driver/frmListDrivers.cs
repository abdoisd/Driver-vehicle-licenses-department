using BusinessLayer;
using FullRealProject.Bases;
using FullRealProject.License;
using FullRealProject.People.Forms;
using System;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace FullRealProject.Driver
{
	public partial class frmListDrivers : frmList
	{
		public frmListDrivers()
		{
			InitializeComponent();
		}


		private void frmListDrivers_Load(object sender, EventArgs e)
		{
			// dgv
			dgvList.DataSource = clsDriver.GetAllDrivers();
			dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dgvList.BackgroundColor = System.Drawing.Color.White;
			dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvList.MultiSelect = false;
			dgvList.ReadOnly = true;
			dgvList.ContextMenuStrip = contextMenuStrip1;
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbMainImage
			// 
			this.pbMainImage.Image = global::FullRealProject.Properties.Resources.Driver_Main;
			// 
			// lblTitle
			// 
			this.lblTitle.Location = new System.Drawing.Point(591, 224);
			this.lblTitle.Size = new System.Drawing.Size(223, 44);
			this.lblTitle.Text = "List Drivers";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonToolStripMenuItem,
            this.showLicenseHistoryToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(234, 80);
			// 
			// showPersonToolStripMenuItem
			// 
			this.showPersonToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.PersonDetails_32;
			this.showPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.showPersonToolStripMenuItem.Name = "showPersonToolStripMenuItem";
			this.showPersonToolStripMenuItem.Size = new System.Drawing.Size(233, 38);
			this.showPersonToolStripMenuItem.Text = "Show Person";
			this.showPersonToolStripMenuItem.Click += new System.EventHandler(this.showPersonToolStripMenuItem_Click);
			// 
			// showLicenseHistoryToolStripMenuItem
			// 
			this.showLicenseHistoryToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.License_View_32;
			this.showLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.showLicenseHistoryToolStripMenuItem.Name = "showLicenseHistoryToolStripMenuItem";
			this.showLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(233, 38);
			this.showLicenseHistoryToolStripMenuItem.Text = "Show License History";
			this.showLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showLicenseHistoryToolStripMenuItem_Click);
			// 
			// frmListDrivers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1404, 753);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmListDrivers";
			this.Load += new System.EventHandler(this.frmListDrivers_Load);
			this.Controls.SetChildIndex(this.lblTitle, 0);
			this.Controls.SetChildIndex(this.pbMainImage, 0);
			this.Controls.SetChildIndex(this.btnClose, 0);
			((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private ContextMenuStrip contextMenuStrip1;
		private System.ComponentModel.IContainer components;
		private ToolStripMenuItem showPersonToolStripMenuItem;
		private ToolStripMenuItem showLicenseHistoryToolStripMenuItem;

		private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int PersonID = (int)dgvList.CurrentRow.Cells[1].Value;
			frmShowPerson frm = new frmShowPerson(PersonID);
			frm.ShowDialog();
		}

		private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int DriverID = (int)dgvList.CurrentRow.Cells[0].Value;
			frmDriverLicensesHistory frm = new frmDriverLicensesHistory(DriverID);
			frm.ShowDialog();
		}
	}
}
