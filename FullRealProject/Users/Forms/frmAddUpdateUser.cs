using BusinessLayer;
using FullRealProject.People.Forms;
using System;
using System.Windows.Forms;

namespace FullRealProject.Users.Forms
{
	public partial class frmAddUpdateUser : Form
	{
		// data
		clsUser user = new clsUser();

		enum enMode
		{
			Add,
			Update
		}

		enMode eMode;

		void fromUser()
		{
			uCtlShowPerson1.fromPerson(user.PersonID);
			txtUsername.Text = user.UserName;
			txtPassword.Text = user.Password;
			txtConfirmPassword.Text = user.Password;
			lblUserId.Text = user.UserID.ToString();
			cbIsActive.Checked = user.IsActive;
		}

		void toUser()
		{
			user.UserName = txtUsername.Text;
			user.Password = txtPassword.Text;
			user.IsActive = cbIsActive.Checked;
		}
		//

		public frmAddUpdateUser() // add mode
		{
			InitializeComponent();

			eMode = enMode.Add;
			tpLoginInfo.Enabled = false;
			btnSave.Enabled = false;
			lblTitle.Text = "Adding New User";

			// loading
			// cb
			cbFilter.Items.Add("Person ID");
			//cbFilter.Items.Add("National No"); to impliment
			cbFilter.SelectedIndex = 0;
			// data
			personId = -1;
		}

		public frmAddUpdateUser(int id) // update mode
		{
			InitializeComponent();

			eMode = enMode.Update;
			lblTitle.Text = "Updating User";
			
			// load data
			user = clsUser.getUserById(id);
			fromUser();
			groupBox1.Enabled = false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (eMode == enMode.Add)
			{
				toUser();
				if (personId == -1)
				{
					MessageBox.Show("invalid person");
					return;
				}
				user.PersonID = personId;
				if (user.Password == txtConfirmPassword.Text)
				{
					if (user.add())
						MessageBox.Show($"User {user.UserID} added successfully");
					else
						MessageBox.Show($"Failure adding user");
				}
				else
				{
					MessageBox.Show("Passwords don't match");
					return;
				}
				eMode = enMode.Update;
				lblTitle.Text = "Updating User";
				lblUserId.Text = user.UserID.ToString();
			}
			else if (eMode == enMode.Update)
			{
				toUser();
				if (user.Password == txtConfirmPassword.Text)
				{
					if (user.update())
						MessageBox.Show($"User {user.UserID} updated successfully");
					else
						MessageBox.Show($"Failure updating user");
				}
				else
					MessageBox.Show("Passwords don't match");
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (txtFilter.Text.Trim() == "")
			{
				txtFilter.Focus();
				return;
			}
			if (!int.TryParse(txtFilter.Text, out personId))
			{
				MessageBox.Show("Invalid number");
				personId = -1;
				return;
			}
			uCtlShowPerson1.fromPerson(personId);
			// there is not user with person
			if (clsUser.getUserByPersonId(personId) == null)
			{
				tpLoginInfo.Enabled = true;
				btnSave.Enabled = true;
			}
			else
			{
				tpLoginInfo.Enabled = false;
				btnSave.Enabled = false;
			}
		}

		private void btnAddPerson_Click(object sender, EventArgs e)
		{
			frmAddUpdatePerson frm = new frmAddUpdatePerson();
			frm.DataBack += ftPassedAsArg;
			frm.ShowDialog();
			if (personId != -1)
				uCtlShowPerson1.fromPerson(personId);
		}

		int personId;

		private void ftPassedAsArg(object sender, int personId)
		{
			this.personId = personId;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (personId == -1)
			{
				MessageBox.Show($"Search for or add a new person first");
				return;
			}
			clsUser user = clsUser.getUserByPersonId(personId);
			if (user != null)
			{
				MessageBox.Show($"There is already a user for person {personId}");
				return;
			}
			tpLoginInfo.Enabled = true;
			btnSave.Enabled = true;
			tcAddUpdateUser.SelectedTab = tpLoginInfo;
		}

		private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void frmAddUpdateUser_Load(object sender, EventArgs e)
		{

		}

		private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				btnSearch.PerformClick();
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}

		private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (txtUsername.Text.Trim() == "")
			{
				e.Cancel = true;
				errorProvider1.SetError(txtUsername, "Required");
			}
		}
	}
}