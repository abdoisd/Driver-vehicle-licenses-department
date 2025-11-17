using BusinessLayer;
using System;
using System.Windows.Forms;
using FullRealProject.Test.Controls;

namespace FullRealProject.Test
{
	public partial class frmScheduleTest : Form
	{
		public frmScheduleTest(clsLocalDrivingLicenseApplication lDLA, clsTestType TestType)
		{
			InitializeComponent();

			this.lDLA = lDLA;
			this.TestType = TestType;
		}

		// data
		clsLocalDrivingLicenseApplication lDLA;
		clsTestType TestType;
		//

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmScheduleTest_Load(object sender, EventArgs e)
		{
			//if (lDLA.has)
			ctlTestAppointment1.load(lDLA, TestType);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			clsTestAppointment testAppointment = ctlTestAppointment1.toTestAppointment();

			try
			{
				testAppointment.Add();
				MessageBox.Show("Success : Test appointment scheduled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Failure : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
