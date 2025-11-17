using BusinessLayer;
using System;
using System.Windows.Forms;

namespace FullRealProject.Detain
{
	public partial class frmReleaseLicense : Form
	{
		public frmReleaseLicense()
		{
			InitializeComponent();

			btnSave.Enabled = false;
		}

		// data
		clsLicense License;
		clsDetainedLicense detainedLicense;
		//

		private void ctlLicenseWithFilter1_OnFind()
		{
			License = ctlLicenseWithFilter1.License;

			detainedLicense = License.GetDetainInfo();

			if (detainedLicense == null)
			{
				MessageBox.Show("this License is not detained");
				return;
			}

			if (detainedLicense.IsReleased)
			{
				MessageBox.Show("This detained license is already released.");
				return;
			}

			btnSave.Enabled = true;

			detainedLicense.IsReleased = true;
			detainedLicense.ReleaseDate = DateTime.Now;
			detainedLicense.ReleasedByUserID = clsGlobal.loggedInUser.UserID;

			lblDetainID.Text = detainedLicense.DetainID.ToString();
			lblLicenseID.Text = License.LicenseID.ToString();
			lblReleaseDate.Text = detainedLicense.ReleaseDate.ToShortDateString();
			lblReleasedByUser.Text = detainedLicense.ReleasedByUserID.ToString();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				clsApplication ReleaseApplication = new clsApplication(-1, License.Driver.PersonID, detainedLicense.ReleaseDate,
					(int)clsApplication.enApplicationTypes.ReleaseDetainedDrivingLicense, clsApplication.enApplicationStatuses.New,
					detainedLicense.ReleaseDate, 0, clsGlobal.loggedInUser.UserID);
				if (!ReleaseApplication.add())
					throw new Exception("Failure adding release application");

				detainedLicense.ReleaseApplicationID = ReleaseApplication.ApplicationID; // userid
				detainedLicense.Update();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}

			lblReleaseApplicationID.Text = detainedLicense.ReleaseApplicationID.ToString();

			MessageBox.Show("License released successfully.");
		}
	}
}
