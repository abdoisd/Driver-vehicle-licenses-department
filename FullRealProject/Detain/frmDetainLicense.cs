using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullRealProject.Detain
{
	public partial class frmDetainLicense : Form
	{
		public frmDetainLicense()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		// data
		clsLicense License;
		//

		private void ctlLicenseWithFilter1_OnFind()
		{
			License = ctlLicenseWithFilter1.License;

			if (!License.IsActive)
				MessageBox.Show("this license is inactive", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);

			// load
			lblLicenseID.Text = License.LicenseID.ToString();
			lblDetainDate.Text = DateTime.Now.ToShortDateString();
			lblCreatedByUser.Text = clsGlobal.loggedInUser.UserName;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!ValidateChildren())
			{
				MessageBox.Show("Some fields are required");
				return;
			}

			if (License == null || License.LicenseID <= 0)
			{
				MessageBox.Show("Please select a valid license to detain.");
				return;
			}

			try
			{
				clsDetainedLicense detainedLicense = new clsDetainedLicense(-1, License.LicenseID, DateTime.Now, decimal.Parse(txtFineFees.Text),
					clsGlobal.loggedInUser.UserID, false, DateTime.MinValue, -1, -1);
				detainedLicense.Add();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
				return;
			}

			MessageBox.Show("License detained successfully.");
		}

		private void txtFineFees_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(txtFineFees.Text))
				e.Cancel = true;
		}
	}
}
