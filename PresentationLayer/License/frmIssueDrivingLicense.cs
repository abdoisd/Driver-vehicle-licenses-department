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

namespace FullRealProject.License
{
	public partial class frmIssueDrivingLicense : Form
	{
		public frmIssueDrivingLicense(int lDLAId)
		{
			InitializeComponent();

			this.LDLA = clsLocalDrivingLicenseApplication.GetById(lDLAId);
		}

		// data
		clsLocalDrivingLicenseApplication LDLA;
		//

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmIssueDrivingLicense_Load(object sender, EventArgs e)
		{
			ctlLocalDrivingLicenseApplicationInfo1.loadInfo(LDLA);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			//// add to database
			//clsDriver driver = new clsDriver();
			// need person

			//// add to database
			//clsLicense license = new clsLicense();
			// need LDLA

			try
			{
				LDLA.IssueDrivingLicense(txtNotes.Text);
				MessageBox.Show("Success");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
	}
}
