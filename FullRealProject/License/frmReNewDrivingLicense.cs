using System;
using BusinessLayer;
using System.Windows.Forms;

namespace FullRealProject.License
{
	public partial class frmReNewDrivingLicense : Form
	{
		public frmReNewDrivingLicense()
		{
			InitializeComponent();
		}

		// data
		clsLicense OldLicense;
		clsLicense NewLicense = null;
		//

		private void ctlLicenseWithFilter1_OnFind()
		{
			OldLicense = ctlLicenseWithFilter1.License; // on find take the license

			if (!OldLicense.IsActive)
			{
				MessageBox.Show("The selected license is not active. You cannot renew an inactive license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			NewLicense = new clsLicense(OldLicense.LicenseID, OldLicense.ApplicationID, OldLicense.DriverID, OldLicense.LicenseClassID,
				OldLicense.IssueDate, OldLicense.ExpirationDate, OldLicense.Notes, OldLicense.PaidFees, OldLicense.IsActive, OldLicense.IssueReason,
				OldLicense.CreatedByUserID);

			DateTime Now = DateTime.Now;

			NewLicense.LicenseID = -1;
			NewLicense.ApplicationID = -1;
			NewLicense.IssueDate = Now;
			NewLicense.ExpirationDate = Now.AddDays(NewLicense.LicenseClass.DefaultValidityLength);
			NewLicense.PaidFees = 0;
			NewLicense.IssueReason = clsLicense.enIssureReasons.Renew;
			NewLicense.CreatedByUserID = clsGlobal.loggedInUser.UserID;

			lblRenewedLicenseID.Text = "[???]";
			lblApplicationDate.Text = Now.ToShortDateString();
			lblIssueDate.Text = NewLicense.IssueDate.ToShortDateString();
			lblApplicationFees.Text = clsApplicationType.getApplicationTypeById((int)clsApplication.enApplicationTypes.RenewDrivingLicense).ApplicationFees.ToString();
			lblLicenseFees.Text = NewLicense.LicenseClass.ClassFees.ToString();
			txtNotes.Text = NewLicense.Notes;
			lblRenewedLicenseID.Text = "[???]";
			lblOldLicenseID.Text = OldLicense.LicenseID.ToString();
			lblExpirationDate.Text = NewLicense.ExpirationDate.ToShortDateString();
			lblCreatedByUser.Text = clsGlobal.loggedInUser.UserName;
			lblTotalFees.Text = (NewLicense.Application.ApplicationType.ApplicationFees + NewLicense.LicenseClass.ClassFees).ToString();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (NewLicense == null)
			{
				MessageBox.Show("Please select a license to renew.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// add re new application to database
			// add new license to database
			// desactivate old license

			// add re new application to database
			DateTime Now = DateTime.Now;
			clsApplication ReNewApplication = new clsApplication(-1, OldLicense.Driver.PersonID, Now, 
				(int)clsApplication.enApplicationTypes.RenewDrivingLicense, clsApplication.enApplicationStatuses.New,
				Now, 0, clsGlobal.loggedInUser.UserID);
			if (!ReNewApplication.add())
			{
				MessageBox.Show("Failed to create application for renewing driving license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// desactivate old license
			OldLicense.IsActive = false;
			try
			{
				NewLicense.ApplicationID = ReNewApplication.ApplicationID;
				NewLicense.Add();

				OldLicense.IsActive = false;
				OldLicense.Update();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			ReNewApplication.ApplicationStatus = clsApplication.enApplicationStatuses.Completed;
			if (!ReNewApplication.Update())
			{
				MessageBox.Show("Failed to update application status after renewing driving license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			MessageBox.Show("Driving license renewal process completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
