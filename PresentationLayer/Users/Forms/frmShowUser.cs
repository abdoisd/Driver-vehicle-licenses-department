using BusinessLayer;
using System;
using System.Windows.Forms;

namespace FullRealProject.Users.Forms
{
	public partial class frmShowUser : Form
	{
		public frmShowUser(int userId)
		{
			InitializeComponent();

			ctlShowUser1.fromUser(userId);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmShowUser_Load(object sender, EventArgs e)
		{

		}
	}
}
