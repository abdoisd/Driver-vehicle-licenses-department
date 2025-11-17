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
	public partial class frmShowLicense : Form
	{
		public frmShowLicense(int LicenseID)
		{
			InitializeComponent();

			ctlShowLicense1.Load(LicenseID);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
