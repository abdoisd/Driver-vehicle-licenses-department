using BusinessLayer;
using FullRealProject.Applications.LocalDrivingLicense;
using FullRealProject.Bases;
using FullRealProject.License;
using FullRealProject.Test;
using System;
using System.Data;
using System.Runtime.DesignerServices;
using System.Windows.Forms;

namespace FullRealProject.Applications
{
	public partial class frmListLocalDrivingLicenseApplications : frmList
	{
		public frmListLocalDrivingLicenseApplications()
		{
			InitializeComponent();
		}

		// data
		// dataTable created just after construction
		DataTable dataTable = clsLocalDrivingLicenseApplication.GetLocalDrivingLicensesView();
		DataView defaultView;
		//

		private void frmListLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
		{
			defaultView = dataTable.DefaultView;

			// dgv
			dgvList.DataSource = dataTable;
			dgvList.Columns[0].HeaderText = "L.D.L.A. ID";
			dgvList.Columns[1].HeaderText = "License Class";
			dgvList.Columns[2].HeaderText = "National No";
			dgvList.Columns[3].HeaderText = "Full Name";
			dgvList.Columns[4].HeaderText = "Date";
			dgvList.Columns[5].HeaderText = "Passed Tests";
			dgvList.Columns[6].HeaderText = "Status";
			dgvList.ContextMenuStrip = contextMenuStrip1;
			dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dgvList.BackgroundColor = System.Drawing.Color.White;
			dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvList.MultiSelect = false;

			// cb
			cbFilter.Items.Add("None");
			cbFilter.Items.Add("L.D.L.A. ID");
			cbFilter.Items.Add("National No");
			cbFilter.Items.Add("Full Name");
			cbFilter.Items.Add("Status");
			cbFilter.SelectedIndex = 0;

			// txt
			txtFilter.Visible = false;

			// cb2
			cbFilterBy.Items.Add("None");
			cbFilterBy.Items.Add("New");
			cbFilterBy.Items.Add("Cancelled");
			cbFilterBy.Items.Add("Completed");
			cbFilterBy.SelectedIndex = 0;
			cbFilterBy.Visible = false;

			// context menue
			issueDrivingLicenseToolStripMenuItem.Enabled = false;
		}

		private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbFilter.Text == "None")
			{
				defaultView.RowFilter = "";
				txtFilter.Visible = false;
				cbFilterBy.Visible = false;
				return;
			}

			if (cbFilter.Text != "None")
				txtFilter.Visible = true;

			if (cbFilter.Text.Trim() == "Status")
			{
				txtFilter.Visible = false;
				cbFilterBy.Visible = true;
				cbFilterBy.Focus();
				return;
			}
			else
			{
				txtFilter.Visible = true;
				cbFilterBy.Visible = false;
				txtFilter.Focus();
			}
		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			if (txtFilter.Text == "")
			{
				defaultView.RowFilter = "";
				return;
			}

			string tmp = "";

			switch (cbFilter.Text)
			{
				case "None":
					return;
				case "L.D.L.A. ID":
					defaultView.RowFilter = $"LocalDrivingLicenseApplicationID = {txtFilter.Text}";
					return;
				case "National No":
					tmp = "nationalno";
					break;
				case "Full Name":
					tmp = "fullname";
					break;
				case "Status":
					tmp = "ApplicationStatus";
					break;
			}

			if (tmp != "")
				defaultView.RowFilter = $"{tmp} like '{txtFilter.Text}%'";
		}

		private void txtFilter_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (cbFilter.Text == "L.D.L.A. ID")
			{
				if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
					e.Handled = true;
			}
		}

		private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
		{

			string tmp = string.Empty;

			switch (cbFilterBy.Text)
			{
				case "None":
					defaultView.RowFilter = "";
					return;
				case "New":
					tmp = "new";
					break;
				case "Cancelled":
					tmp = "cancelled";
					break;
				case "Completed":
					tmp = "completed";
					break;
			}

			defaultView.RowFilter = $"ApplicationStatus = '{tmp}'";
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnAddPerson_Click(object sender, EventArgs e)
		{
			frmAddUpdateApplication frm = new frmAddUpdateApplication();
			frm.ShowDialog();

			updateDataGridView();
		}

		void	updateDataGridView()
		{
			dataTable = clsLocalDrivingLicenseApplication.GetLocalDrivingLicensesView();
			defaultView = dataTable.DefaultView;
			dgvList.DataSource = dataTable;
		}

		private void addLocalDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int localDrivingLicenseApplicationId = (int)dgvList.CurrentRow.Cells[0].Value;
			frmAddUpdateApplication frm = new frmAddUpdateApplication(localDrivingLicenseApplicationId);
			frm.ShowDialog();

			updateDataGridView();
		}

		private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (clsLocalDrivingLicenseApplication.Delete((int)dgvList.CurrentRow.Cells[0].Value))
				MessageBox.Show("Application deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show("Failed to delete application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			updateDataGridView();
		}

		private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int id = (int)dgvList.CurrentRow.Cells[0].Value;
			frmShowLocalDrivingLicenseApplication frm = new frmShowLocalDrivingLicenseApplication(id);
			frm.ShowDialog();
		}

		private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int id = (int)dgvList.CurrentRow.Cells[0].Value;
			clsLocalDrivingLicenseApplication lDLA = clsLocalDrivingLicenseApplication.GetById(id);

			try
			{
				lDLA.Cancel();
				MessageBox.Show("Application cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			updateDataGridView();
		}

		private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int id = (int)dgvList.CurrentRow.Cells[0].Value;
			frmListTestAppointments frm = new frmListTestAppointments(id, clsTestType.enTestTypes.Vision);
			frm.Show();

			updateDataGridView();
		}

		private void writtenTestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int id = (int)dgvList.CurrentRow.Cells[0].Value;
			frmListTestAppointments frm = new frmListTestAppointments(id, clsTestType.enTestTypes.Written);
			frm.Show();

			updateDataGridView();
		}

		private void streetTestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int id = (int)dgvList.CurrentRow.Cells[0].Value;
			frmListTestAppointments frm = new frmListTestAppointments(id, clsTestType.enTestTypes.Street);
			frm.Show();

			updateDataGridView();
		}

		private void scheduleTestToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
		{
			int id = (int)dgvList.CurrentRow.Cells[0].Value;
			clsLocalDrivingLicenseApplication LDLA = clsLocalDrivingLicenseApplication.GetById(id);

			int numberOfPassedTests = LDLA.TotalNumberOfSuccessfullyPassedTests();

			visionTestToolStripMenuItem.Enabled = (numberOfPassedTests == 0);
			writtenTestToolStripMenuItem.Enabled = (numberOfPassedTests == 1);
			streetTestToolStripMenuItem.Enabled = (numberOfPassedTests == 2);
		}

		private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{

			if (dgvList.Rows.Count == 0 || dgvList.CurrentRow == null)
			{
				e.Cancel = true;
				return;
			}

			int id = (int)dgvList.CurrentRow.Cells[0].Value;
			clsLocalDrivingLicenseApplication LDLA = clsLocalDrivingLicenseApplication.GetById(id);

			cancelApplicationToolStripMenuItem.Enabled = (LDLA.ApplicationStatus != clsApplication.enApplicationStatuses.Completed && 
				LDLA.ApplicationStatus != clsApplication.enApplicationStatuses.Cancelled);

			editLocalDrivingLicenseApplicationToolStripMenuItem.Enabled = (LDLA.ApplicationStatus != clsApplication.enApplicationStatuses.Completed &&
				LDLA.ApplicationStatus != clsApplication.enApplicationStatuses.Cancelled);

			scheduleTestToolStripMenuItem.Enabled = (LDLA.ApplicationStatus != clsApplication.enApplicationStatuses.Completed &&
				LDLA.ApplicationStatus != clsApplication.enApplicationStatuses.Cancelled);

			if (LDLA.ApplicationStatus == clsApplication.enApplicationStatuses.Completed)
				deleteApplicationToolStripMenuItem.Enabled = false;

			if (LDLA.TotalNumberOfSuccessfullyPassedTests() == 3)
				issueDrivingLicenseToolStripMenuItem.Enabled = true;
			if (LDLA.hasLicense())
				issueDrivingLicenseToolStripMenuItem.Enabled = false;

			viewLicenseToolStripMenuItem.Enabled = LDLA.hasLicense();
		}

		private void issueDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int id = (int)dgvList.CurrentRow.Cells[0].Value;
			frmIssueDrivingLicense frm = new frmIssueDrivingLicense(id);
			frm.ShowDialog();
		}

		private void viewLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int LDLAId = (int)dgvList.CurrentRow.Cells[0].Value;
			clsLocalDrivingLicenseApplication LDLA = clsLocalDrivingLicenseApplication.GetById(LDLAId);
			frmShowLicense frm = new frmShowLicense(LDLA.getActiveLicense().LicenseID);
			frm.ShowDialog();
		}
	}
}
