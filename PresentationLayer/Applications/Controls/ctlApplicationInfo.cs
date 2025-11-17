using BusinessLayer;
using FullRealProject.People.Forms;
using System.Windows.Forms;

namespace FullRealProject.Applications.Controls
{
	public partial class ctlApplicationInfo : UserControl
	{
		public ctlApplicationInfo()
		{
			InitializeComponent();
		}

		// data
		clsApplication application;
		//

		public void	loadInfo(clsApplication application)
		{
			this.application = application;

			lblApplicationID.Text = application.ApplicationID.ToString();

			clsApplication.enApplicationStatuses status = (clsApplication.enApplicationStatuses)application.ApplicationStatus;
			lblStatus.Text = status.ToString();

			lblFees.Text = application.ApplicationType.ApplicationFees.ToString();

			lblType.Text = application.ApplicationType.ApplicationTypeTitle;

			lblApplicant.Text = application.ApplicantPerson.PersonID.ToString();

			lblDate.Text = application.ApplicationDate.ToString();

			lblStatusDate.Text = application.LastStatusDate.ToString();

			lblCreatedByUser.Text = application.CreatedByUser.UserName;
		}

		private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmShowPerson frm = new frmShowPerson(application.ApplicantPerson.PersonID);
			frm.ShowDialog();
		}
	}
}
