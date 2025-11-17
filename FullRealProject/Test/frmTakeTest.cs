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

namespace FullRealProject.Test
{
	public partial class frmTakeTest : Form
	{
		public delegate void OnSaveHandler();
		public event OnSaveHandler OnSave;

		public frmTakeTest(int TestAppointmentID)
		{
			InitializeComponent();

			this.TestAppointment = clsTestAppointment.Get(TestAppointmentID);
		}

		// data
		clsTestAppointment TestAppointment;
		clsTest Test;
		//

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmTakeTest_Load(object sender, EventArgs e)
		{
			ctlTestAppointment1.load(TestAppointment);
		}

		clsTest toTest()
		{
			this.Test = new clsTest(-1, TestAppointment.TestAppointmentID, rbPass.Checked, txtNotes.Text, clsGlobal.loggedInUser.UserID);
			return Test;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!this.ValidateChildren()) // invoke all the validatings
			{
				return;
			}

			toTest();

			try
			{
				Test.Add();

				if (Test.TestResult)
					OnSave?.Invoke();

				MessageBox.Show("Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Failure: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void rbs_Validating(object sender, CancelEventArgs e)
		{
			if (!rbPass.Checked && !rbFail.Checked)
			{
				e.Cancel = true;
				MessageBox.Show("Test Result required");
			}
		}
	}
}
