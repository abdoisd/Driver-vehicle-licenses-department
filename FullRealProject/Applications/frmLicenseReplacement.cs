using BusinessLayer;
using FullRealProject.License;
using System;
using System.Windows.Forms;

namespace FullRealProject.Applications
{
	public partial class frmLicenseReplacement : Form
	{
		public frmLicenseReplacement()
		{
			InitializeComponent();

			lblShowNewLicense.Enabled = false;
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
			//NewLicense.IssueReason = ;
			NewLicense.CreatedByUserID = clsGlobal.loggedInUser.UserID;

			lblRenewedLicenseID.Text = "[???]";
			lblApplicationDate.Text = Now.ToShortDateString();
			lblApplicationFees.Text = clsApplicationType.getApplicationTypeById((int)clsApplication.enApplicationTypes.RenewDrivingLicense).ApplicationFees.ToString();
			lblRenewedLicenseID.Text = "[???]";
			lblOldLicenseID.Text = OldLicense.LicenseID.ToString();
			lblCreatedByUser.Text = clsGlobal.loggedInUser.UserName;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!ValidateChildren())
			{
				MessageBox.Show("Issue reason required");
				return;
			}

			if (NewLicense == null)
			{
				MessageBox.Show("Chose a license for replacement");
				return;
			}

			// add application
			DateTime Now = DateTime.Now;
			clsApplication ReplacementApplication = new clsApplication(-1, OldLicense.Driver.PersonID, Now, rbForLost.Checked?
				(int)clsApplication.enApplicationTypes.ReplaceLostDrivingLicense: (int)clsApplication.enApplicationTypes.ReplaceDamagedDrivingLicense,
				clsApplication.enApplicationStatuses.New, Now, 0, clsGlobal.loggedInUser.UserID);
			if (!ReplacementApplication.add())
			{
				MessageBox.Show("Failed to create application for renewing driving license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				// add new license
				NewLicense.ApplicationID = ReplacementApplication.ApplicationID;
				NewLicense.IssueReason = rbForLost.Checked ? clsLicense.enIssureReasons.ReplacementForLost : clsLicense.enIssureReasons.ReplacementForDamaged;
				NewLicense.Add();

				// desactivate old license
				OldLicense.IsActive = false;
				OldLicense.Update();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			ReplacementApplication.ApplicationStatus = clsApplication.enApplicationStatuses.Completed;
			if (!ReplacementApplication.Update())
			{
				MessageBox.Show("Failed to update application status to completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			MessageBox.Show("License replacement application created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

			lblApplicationID.Text = ReplacementApplication.ApplicationID.ToString();
			lblRenewedLicenseID.Text = NewLicense.LicenseID.ToString();

			lblShowNewLicense.Enabled = true;
		}

		private void rbForLost_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (!rbForLost.Checked && !rbForDamaged.Checked)
			{
				e.Cancel = true;
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmShowLicense frm = new frmShowLicense(NewLicense.LicenseID);
			frm.ShowDialog();
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (NewLicense == null)
			{
				MessageBox.Show("Choose a license first");
				return;
			}

			frmDriverLicensesHistory frm = new frmDriverLicensesHistory(NewLicense.DriverID);
			frm.ShowDialog();
		}
	}
}
