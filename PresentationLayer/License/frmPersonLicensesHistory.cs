using BusinessLayer;
using System;
using System.Windows.Forms;

namespace FullRealProject.License
{
	public partial class frmDriverLicensesHistory : Form
	{
		public frmDriverLicensesHistory(int DriverID)
		{
			InitializeComponent();

			this.DriverID = DriverID;
		}

		// data
		int DriverID;
		//

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmPersonLicensesHistory_Load(object sender, EventArgs e)
		{
			clsDriver	Driver = clsDriver.GetDriverByID(DriverID);

			uCtlShowPerson1.fromPerson(Driver.PersonID);

			// dgvLocal
			dgvLocal.DataSource = Driver.GetLocalLicenses();
			dgvLocal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dgvLocal.BackgroundColor = System.Drawing.Color.White;
			dgvLocal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvLocal.MultiSelect = false;
		}
	}
}
