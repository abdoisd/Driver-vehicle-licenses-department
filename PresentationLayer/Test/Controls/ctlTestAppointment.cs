using BusinessLayer;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FullRealProject.Test.Controls
{
	public partial class ctlTestAppointment : UserControl
	{
		public ctlTestAppointment()
		{
			InitializeComponent();
		}

		// data
		clsTestAppointment TestAppointment;
		//

		public void	load(clsLocalDrivingLicenseApplication lDLA, clsTestType TestType)
		{
			TestAppointment = new clsTestAppointment(-1, TestType.TestTypeID, lDLA.LocalDrivingLicenseApplicationID, 
				DateTime.Now, 0, clsGlobal.loggedInUser.UserID, false, -1);

			lblLDLAId.Text = TestAppointment.LocalDrivingLicenseApplicationID.ToString();

			lblPersonName.Text = TestAppointment.LocalDrivingLicenseApplication.ApplicantPerson.FullName;

			lblLicenseClass.Text = TestAppointment.LocalDrivingLicenseApplication.LicenseClass.ClassName;

			dtpTestDate.MinDate = TestAppointment.TestDate;

			lblTestFees.Text = TestAppointment.TestType.TestTypeFees.ToString();

			lblCreatedByUser.Text = clsGlobal.loggedInUser.UserName;

			if (lDLA.HasLockedTestAppointmentsOfTestType(TestType.TestTypeID))
			{
				decimal retakeApplicationFees = clsApplicationType.getApplicationTypeById(7).ApplicationFees;
				lblRAppFees.Text = retakeApplicationFees.ToString();
				lblTotalFees.Text = (retakeApplicationFees + TestAppointment.TestType.TestTypeFees).ToString();
			}
		}

		public void	load(clsTestAppointment TestAppointment)
		{
			this.TestAppointment = TestAppointment;

			lblLDLAId.Text = TestAppointment.LocalDrivingLicenseApplicationID.ToString();

			lblPersonName.Text = TestAppointment.LocalDrivingLicenseApplication.ApplicantPerson.FullName;

			lblLicenseClass.Text = TestAppointment.LocalDrivingLicenseApplication.LicenseClass.ClassName;

			dtpTestDate.MinDate = TestAppointment.TestDate;
			dtpTestDate.Enabled = false;

			lblTestFees.Text = TestAppointment.TestType.TestTypeFees.ToString();

			lblCreatedByUser.Text = clsGlobal.loggedInUser.UserName;

			if (TestAppointment.LocalDrivingLicenseApplication.HasLockedTestAppointmentsOfTestType(TestAppointment.TestType.TestTypeID))
			{
				decimal retakeApplicationFees = clsApplicationType.getApplicationTypeById(7).ApplicationFees;
				lblRAppFees.Text = retakeApplicationFees.ToString();
				lblTotalFees.Text = (retakeApplicationFees + TestAppointment.TestType.TestTypeFees).ToString();
			}
		}

		public clsTestAppointment toTestAppointment()
		{
			TestAppointment.TestDate = dtpTestDate.Value;
			return TestAppointment;
		}
	}
}
