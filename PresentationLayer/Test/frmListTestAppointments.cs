using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace FullRealProject.Test
{
	// list appointments per (person, testType)
	public partial class frmListTestAppointments : Form
	{
		public frmListTestAppointments(int lDLAId, clsTestType.enTestTypes testType)
		{
			InitializeComponent();

			lDLA = clsLocalDrivingLicenseApplication.GetById(lDLAId);
			TestType = clsTestType.getByID((int)testType);
		}

		// data
		clsLocalDrivingLicenseApplication lDLA;
		// we must add
		clsTestType TestType;
		//

		void	load()
		{
			// modes (lbl, pb)
			switch (TestType.TestTypeID)
			{
				case clsTestType.enTestTypes.Vision:
					lblTitle.Text = "Vision Test";
					pbTitleImage.Image = Properties.Resources.Vision_512;
					break;
				case clsTestType.enTestTypes.Written:
					lblTitle.Text = "Written Test";
					pbTitleImage.Image = Properties.Resources.Written_Test_512;
					break;
				case clsTestType.enTestTypes.Street:
					lblTitle.Text = "Street Test";
					pbTitleImage.Image = Properties.Resources.TestType_512;
					break;
			}

			// clt
			ctlLocalDrivingLicenseApplicationInfo1.loadInfo(lDLA);

			// dgv
			dgvList.DataSource = lDLA.GetTestAppointmentsOfTestType(TestType.TestTypeID);
			dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dgvList.BackgroundColor = System.Drawing.Color.White;
			dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvList.MultiSelect = false;
			dgvList.ReadOnly = true;
			dgvList.AllowUserToAddRows = false;
		}

		private void frmListTestAppointments_Load(object sender, EventArgs e)
		{
			load();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnAddAppointment_Click(object sender, EventArgs e)
		{
			frmScheduleTest frm = new frmScheduleTest(lDLA, TestType);
			frm.ShowDialog();

			dgvList.DataSource = lDLA.GetTestAppointmentsOfTestType(TestType.TestTypeID);
		}

		private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int testAppointmentId = (int)dgvList.CurrentRow.Cells[0].Value;
			frmTakeTest frm = new frmTakeTest(testAppointmentId);
			frm.OnSave += ft;
			frm.ShowDialog();

			dgvList.DataSource = lDLA.GetTestAppointmentsOfTestType(TestType.TestTypeID);
		}

		void	ft()
		{
			btnAddAppointment.Enabled = false;
		}

		private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			int testAppointmentId = (int)dgvList.CurrentRow.Cells[0].Value;
			clsTestAppointment testAppointment = clsTestAppointment.Get(testAppointmentId);
			if (testAppointment.IsLocked)
				takeTestToolStripMenuItem.Enabled = false;
		}
	}
}
