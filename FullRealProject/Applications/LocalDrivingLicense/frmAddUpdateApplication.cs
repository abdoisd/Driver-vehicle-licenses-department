using BusinessLayer;
using System;
using System.Windows.Forms;

namespace FullRealProject.Applications
{
	public partial class frmAddUpdateApplication : Form
	{
		public frmAddUpdateApplication()
		{
			InitializeComponent();
		}

		public frmAddUpdateApplication(int localDrivingLicenseApplicationId)
		{
			InitializeComponent();

			eMode = enModes.Update;

			lDLA.LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationId;
		}

		// data
		enum enModes
		{
			Add,
			Update
		}

		enModes eMode = enModes.Add;

		clsLocalDrivingLicenseApplication lDLA = new clsLocalDrivingLicenseApplication(); // maybe after constr

		DateTime	Now = DateTime.Now;
		//

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		void setLDLAInitValues() // those values are according to form
		{
			// base
			lDLA.ApplicationID = -1;
			lDLA.ApplicantPersonID = -1;
			lDLA.ApplicationDate = Now; // final
			lDLA.ApplicationTypeID = (int)clsApplication.enApplicationTypes.NewDrivingLicense;
			lDLA.ApplicationStatus = clsApplication.enApplicationStatuses.New;
			lDLA.LastStatusDate = Now;
			lDLA.PaidFees = 0;
			lDLA.CreatedByUserID = clsGlobal.loggedInUser.UserID; // final

			// derived
			lDLA.LocalDrivingLicenseApplicationID = -1;
			lDLA.LicenseClassID = (int)clsLocalDrivingLicenseApplication.enApplicationTypes.NewDrivingLicense;
		}

		private void frmAddApplication_Load(object sender, EventArgs e)
		{
			if (eMode == enModes.Add)
			{
				setLDLAInitValues();

				// cb
				cbFilter.Items.Add("Person ID");
				cbFilter.SelectedIndex = 0;

				// tp
				tpApplicationInfo.Enabled = false;
				btnSave.Enabled = false;

				// cb
				cbLicenseClasses.DataSource = clsLicenseClass.getAllLicenseClasses();
				cbLicenseClasses.DisplayMember = "ClassName";
				cbLicenseClasses.ValueMember = "LicenseClassID";

				// lbl
				lblApplicationDate.Text = Now.ToString();

				// lbl
				lblApplicationFees.Text = clsLicenseClass.getLicenseClassById(1).ClassFees.ToString();

				// lbl
				lblCreatedByUser.Text = clsGlobal.loggedInUser.UserName;

				// lbl
				lblTitle.Text = "Add Local Driving License Application";
			}
			else if (eMode == enModes.Update)
			{
				// lbl
				lblTitle.Text = "Update Local Driving License Application";

				// cb
				cbLicenseClasses.DataSource = clsLicenseClass.getAllLicenseClasses();
				cbLicenseClasses.DisplayMember = "ClassName";
				cbLicenseClasses.ValueMember = "LicenseClassID";

				// gb
				groupBox1.Enabled = false;

				lDLA = clsLocalDrivingLicenseApplication.GetById(lDLA.LocalDrivingLicenseApplicationID);

				fromLDLA();
			}
		}

		void	fromLDLA()
		{
			uCtlShowPerson1.fromPerson(lDLA.ApplicantPersonID);

			lblLDLAId.Text = lDLA.LocalDrivingLicenseApplicationID.ToString();

			lblApplicationDate.Text = lDLA.ApplicationDate.ToString();

			cbLicenseClasses.Text = lDLA.LicenseClass.ClassName;

			lblApplicationFees.Text = lDLA.ApplicationType.ApplicationFees.ToString();

			lblCreatedByUser.Text = lDLA.CreatedByUser.UserName;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (txtFilter.Text.Trim() == "")
			{
				txtFilter.Focus();
				return;
			}
			if (!int.TryParse(txtFilter.Text, out int personId))
			{
				MessageBox.Show("Invalid number");
				return;
			}
			if (uCtlShowPerson1.fromPerson(personId))
			{
				tpApplicationInfo.Enabled = true;
				btnSave.Enabled = true;
				lDLA.ApplicantPersonID = personId;
				btnNext.Focus();
			}
			else
			{
				tpApplicationInfo.Enabled = false;
				btnSave.Enabled = false;
				lDLA.ApplicantPersonID = -1;
			}
		}

		private void cbLicenseClasses_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbLicenseClasses.ValueMember == "")
				return;
			lblApplicationFees.Text = clsLicenseClass.getLicenseClassById((int)cbLicenseClasses.SelectedValue).ClassFees.ToString();
			lDLA.LicenseClassID = (int)cbLicenseClasses.SelectedValue;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (eMode == enModes.Add)
			{
				//if (lDLA.add())
				//{
				//	MessageBox.Show($"{lDLA.LocalDrivingLicenseApplicationID} saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				//	eMode = enModes.Update;
				//	frmAddApplication_Load(null, null);
				//}
				//else
				//	MessageBox.Show("failed to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				try
				{
					lDLA.Add();
					MessageBox.Show($"Saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					eMode = enModes.Update;
					//frmAddApplication_Load(null, null);
					this.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Failure saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else if (eMode == enModes.Update)
			{
				if (lDLA.Update())
					MessageBox.Show($"{lDLA.LocalDrivingLicenseApplicationID} updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
					MessageBox.Show("failed to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			tcAddUpdateUser.SelectedIndex = 1;
		}

		private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				//e.Handled = true;
				btnSearch.PerformClick();
			}
		}

		private void frmAddUpdateApplication_Activated(object sender, EventArgs e)
		{
			txtFilter.Focus();
		}
	}
}
