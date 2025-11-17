using System;
using System.Windows.Forms;

namespace FullRealProject.People.Forms
{
	public partial class frmShowPerson : Form
	{
		public frmShowPerson(int id)
		{
			InitializeComponent();
			uCtlShowPerson1.fromPerson(id);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
