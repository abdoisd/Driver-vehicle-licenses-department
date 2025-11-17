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

namespace FullRealProject.Applications.LocalDrivingLicense
{
	public partial class frmShowLocalDrivingLicenseApplication : Form
	{
		public frmShowLocalDrivingLicenseApplication(int id)
		{
			InitializeComponent();

			lDLA = clsLocalDrivingLicenseApplication.GetById(id);
		}

		// data
		clsLocalDrivingLicenseApplication lDLA;
		//

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmShowLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
		{
			ctlLocalDrivingLicenseApplicationInfo1.loadInfo(lDLA);
		}
	}
}
