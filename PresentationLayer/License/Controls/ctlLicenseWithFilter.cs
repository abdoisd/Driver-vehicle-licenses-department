using BusinessLayer;
using System;
using System.Windows.Forms;

namespace FullRealProject.License.Controls
{
	public partial class ctlLicenseWithFilter : UserControl
	{
		// events
		public delegate void OnFindEventHandler();
		public event OnFindEventHandler OnFind;
		//

		public ctlLicenseWithFilter()
		{
			InitializeComponent();
		}

		// data
		public clsLicense License;
		//

		//public new void	Load(int LicenseID)
		//{
		//	ctrlDriverLicenseInfo1.Load(LicenseID);
		//}

		private void btnFind_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(txtLicenseID.Text, out int LicenseID))
			{
				MessageBox.Show("Invalid number");
				return;
			}

			License = clsLicense.GetLicenseByID(LicenseID);

			if (License == null)
			{
				MessageBox.Show("There is no License with this number");
				return;
			}

			// calling the function
			ctrlDriverLicenseInfo1.load(License);

			OnFind?.Invoke(); // this changes many things
		}

		private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
				btnFind.PerformClick();

			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
	}
}
