using BusinessLayer;
using System.Windows.Forms;

namespace FullRealProject.Users.Forms
{
	public partial class frmChangePassword : Form
	{
		// data
		clsUser user;
		//

		public frmChangePassword(int userId)
		{
			InitializeComponent();

			//_user = clsUser.getUserById(userId);
			//_user.person = clsPerson.getPersonById(_user.PersonID);

			user = clsUser.getUserById(userId);
			user.Person = clsPerson.getPersonById(user.PersonID);
			ctlShowUser1.fromUser(userId);
		}

		private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (txtOldPassword.Text != user.Password)
				errorProvider1.SetError(txtOldPassword, "Wrong password");
			else
				errorProvider1.SetError(txtOldPassword, "");
		}

		private void txtNewPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (txtNewPassword.Text != txtConfirmPassword.Text)
				errorProvider1.SetError((TextBox)sender, "Passwords don't match");
			else
				errorProvider1.SetError((TextBox)sender, "");
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if (txtOldPassword.Text == user.Password &&
				txtNewPassword.Text == txtConfirmPassword.Text)
			{
				if (user.changePassword(txtNewPassword.Text))
					MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
				MessageBox.Show("Please check your inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void txtOldPassword_TextChanged(object sender, System.EventArgs e)
		{

		}
	}
}
