using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace FullRealProject.Applications.InternationalLicense
{
	public partial class frmIssueInternationalLicense : Form
	{
		public frmIssueInternationalLicense()
		{
			InitializeComponent();

			btnSave.Enabled = false;
		}

		// data
		clsLicense License;
		clsInternationalLicense InternationalLicense;
		//

		private void ctlLicenseWithFilter1_OnFind()
		{
			License = ctlLicenseWithFilter1.License;

			DateTime Now = DateTime.Now;

			InternationalLicense = new clsInternationalLicense(
				-1, -1, License.Driver.DriverID, License.LicenseID, Now, Now.AddYears(1),
				true, clsGlobal.loggedInUser.UserID);

			btnSave.Enabled = true;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			DateTime Now = DateTime.Now;
			clsApplication application = new clsApplication(-1, License.Driver.PersonID, Now, (int)clsApplication.enApplicationTypes.NewInternationalLicense,
				clsApplication.enApplicationStatuses.New, Now, 0, clsGlobal.loggedInUser.UserID);
			application.add();

			InternationalLicense.ApplicationID = application.ApplicationID;
			InternationalLicense.Add();
		}
	}
}
