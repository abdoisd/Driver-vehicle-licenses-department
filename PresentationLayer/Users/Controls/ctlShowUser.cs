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

namespace FullRealProject.Users.Controls
{
	public partial class ctlShowUser : UserControl
	{
		public ctlShowUser()
		{
			InitializeComponent();
		}

		// data
		clsUser user;
		clsPerson person; // not sat yet
		//

		public void fromUser(int userId)
		{
			user = clsUser.getUserById(userId);

			// load person
			uCtlShowPerson1.fromPerson(user.PersonID);

			// load user
			lblUsername.Text = user.UserName;
			lblPersonId.Text = user.UserID.ToString();
			lblIsActive.Text = user.IsActive ? "Yes" : "No";
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void ctlShowUser_Click(object sender, EventArgs e)
		{

		}
	}
}
