using BusinessLayer;
using System.Windows.Forms;

namespace FullRealProject.Applications.LocalDrivingLicense.Controls
{
	public partial class ctlLocalDrivingLicenseApplicationInfo : UserControl
	{
		public ctlLocalDrivingLicenseApplicationInfo()
		{
			InitializeComponent();
		}

		// data
		clsLocalDrivingLicenseApplication LDLA;
		//

		private void llShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Not implemented yet");
		}

		public void	loadInfo(clsLocalDrivingLicenseApplication lDLA)
		{
			this.LDLA = lDLA;

			ctrlApplicationInfo1.loadInfo(LDLA);

			lblLocalDrivingLicenseApplicationID.Text = LDLA.LocalDrivingLicenseApplicationID.ToString();

			lblAppliedFor.Text = LDLA.LicenseClass.ClassName;

			lblPassedTests.Text = LDLA.TotalNumberOfSuccessfullyPassedTests().ToString() + "/3";
		}
	}
}
