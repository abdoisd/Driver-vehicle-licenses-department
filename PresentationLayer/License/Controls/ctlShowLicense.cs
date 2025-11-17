using BusinessLayer;
using System.Windows.Forms;

namespace FullRealProject.License.Controls
{
	public partial class ctlShowLicense : UserControl
	{
		public ctlShowLicense()
		{
			InitializeComponent();
		}

		// data
		public clsLicense License {  get; set; }
		//

		public	void	Load(int LicenseID)
		{
			License = clsLicense.GetLicenseByID(LicenseID);

			if (License == null)
			{
				MessageBox.Show("ctl: License Not Fount");
				return;
			}

			lblClass.Text = License.LicenseClass.ToString();
			lblFullName.Text = License.Application.ApplicantPerson.FullName;
			lblLicenseID.Text = License.LicenseID.ToString();
			lblNationalNo.Text = License.Application.ApplicantPerson.NationalNo.ToString();
			lblGendor.Text = License.Application.ApplicantPerson.Gender == 0? "Male": "Female";
			lblIssueDate.Text = License.IssueDate.ToShortDateString();
			lblIssueReason.Text = License.IssueReason.ToString();
			lblNotes.Text = License.Notes == ""? "No Notes": License.Notes;
			lblIsActive.Text = License.IsActive ? "Yes" : "No";
			lblDateOfBirth.Text = License.Application.ApplicantPerson.DateOfBirth.ToShortDateString();
			lblDriverID.Text = License.DriverID.ToString();
			lblExpirationDate.Text = License.ExpirationDate.ToShortDateString();
			lblIsDetained.Text = "Not implemented";

			// pb
		}

		public void load(clsLicense License)
		{
			if (License == null)
			{
				MessageBox.Show("ctl: License Not Fount");
				return;
			}

			lblClass.Text = License.LicenseClass.ClassName;
			lblFullName.Text = License.Application.ApplicantPerson.FullName;
			lblLicenseID.Text = License.LicenseID.ToString();
			lblNationalNo.Text = License.Application.ApplicantPerson.NationalNo.ToString();
			lblGendor.Text = License.Application.ApplicantPerson.Gender == 0? "Male": "Female";
			lblIssueDate.Text = License.IssueDate.ToShortDateString();
			lblIssueReason.Text = License.IssueReason.ToString();
			lblNotes.Text = License.Notes == "" ? "No Notes" : License.Notes;
			lblIsActive.Text = License.IsActive ? "Yes" : "No";
			lblDateOfBirth.Text = License.Application.ApplicantPerson.DateOfBirth.ToShortDateString();
			lblDriverID.Text = License.DriverID.ToString();
			lblExpirationDate.Text = License.ExpirationDate.ToShortDateString();
			lblIsDetained.Text = "Not implemented";

			// pb
		}
	}
}
