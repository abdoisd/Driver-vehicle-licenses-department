using FullRealProject.Applications;
using FullRealProject.Applications.InternationalLicense;
using FullRealProject.Detain;
using FullRealProject.Driver;
using FullRealProject.License;
using FullRealProject.People.Forms;
using FullRealProject.Users;
using FullRealProject.Users.Forms;
using System;
using System.Windows.Forms;

namespace FullRealProject
{
	public partial class frmMain : Form
	{
		public frmMain(frmLogin loginForm)
		{
			InitializeComponent();
			this.loginForm = loginForm;
		}

		frmLogin loginForm;
		bool dontCloseLoginForm = false;

		private void mangePeopleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmListPeople frm = new frmListPeople();
			frm.ShowDialog();
		}

		private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmListUsers frm = new frmListUsers();
			frm.ShowDialog();
		}

		private void profileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmShowUser frm = new frmShowUser(clsGlobal.loggedInUser.UserID);
			frm.ShowDialog();
		}

		private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmChangePassword frm = new frmChangePassword(clsGlobal.loggedInUser.UserID);
			frm.ShowDialog();
		}

		private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loginForm.Show();
			dontCloseLoginForm = true;
			this.Close();
		}

		private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmListApplicationTypes frm = new frmListApplicationTypes();
			frm.ShowDialog();
		}

		private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmListTestTypes frm = new frmListTestTypes();
			frm.ShowDialog();
		}

		private void localApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmListLocalDrivingLicenseApplications frm = new frmListLocalDrivingLicenseApplications();
			frm.ShowDialog();
		}

		private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAddUpdateApplication frm = new frmAddUpdateApplication();
			frm.ShowDialog();
		}

		private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (dontCloseLoginForm)
				return;
			loginForm.Close();
		}

		private void reNewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmReNewDrivingLicense frm = new frmReNewDrivingLicense();
			frm.ShowDialog();
		}

		private void replacementForLostToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmLicenseReplacement frm = new frmLicenseReplacement();
			frm.ShowDialog();
		}

		private void manageDriversToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmListDrivers frm = new frmListDrivers();
			frm.ShowDialog();
		}

		private void detainALicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmDetainLicense frm = new frmDetainLicense();
			frm.ShowDialog();
		}

		private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmReleaseLicense frm = new frmReleaseLicense();
			frm.ShowDialog();
		}

		private void internationalApplicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmIssueInternationalLicense frm = new frmIssueInternationalLicense();
			frm.ShowDialog();
		}
	}
}
