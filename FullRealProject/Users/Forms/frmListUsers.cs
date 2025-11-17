using BusinessLayer;
using FullRealProject.Users.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FullRealProject.Users
{
	public partial class frmListUsers : Form
	{
		// data
		DataTable users;
		DataView defaultView;
		//

		public frmListUsers()
		{
			InitializeComponent();

			users = clsUser.getAllUsers().DefaultView.ToTable(false, "UserID", "PersonID", "UserName", "IsActive");
			if (users == null)
			{
				MessageBox.Show("User data could not be loaded.");
				return;
			}
			defaultView = users.DefaultView;
		}

		private void frmListUsers_Load(object sender, EventArgs e) // on form load
		{
			// Validate users data source
			if (users == null)
			{
				MessageBox.Show("User data could not be loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// DataGridView setup
			dgvListPeople.DataSource = users;
			if (dgvListPeople.Columns.Count >= 4)
			{
				dgvListPeople.Columns[0].HeaderCell.Value = "User ID";
				dgvListPeople.Columns[1].HeaderCell.Value = "Person ID";
				dgvListPeople.Columns[2].HeaderCell.Value = "User Name";
				dgvListPeople.Columns[3].HeaderCell.Value = "Is Active";
			}
			dgvListPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvListPeople.BackgroundColor = System.Drawing.Color.White;

			// ComboBox setup
			cbFilter.Items.Clear();
			var filterOptions = new List<string> { "None", "User ID", "Person ID", "User Name", "Is Active" };
			cbFilter.DataSource = filterOptions;
			cbFilter.SelectedIndex = 0;

			// TextBox setup
			txtFilter.Visible = false;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbFilter.Text == "None")
			{
				defaultView.RowFilter = "";
				txtFilter.Visible = false;
				return;
			}

			if (cbFilter.Text != "None")
				txtFilter.Visible = true;

			if (cbFilter.Text.Trim() == "Is Active")
			{
				defaultView.RowFilter = $"isactive = 1";
				txtFilter.Visible = false;
				return;
			}
			txtFilter.Focus();
		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			if (txtFilter.Text == "")
			{
				defaultView.RowFilter = "";
				return;
			}

			if (cbFilter.Text == "User ID" || cbFilter.Text == "Person ID")
			{
				if (!int.TryParse(txtFilter.Text, out int value))
				{
					defaultView.RowFilter = "1 = 2"; // nothing
					return;
				}
			}

			switch (cbFilter.Text)
			{
				case "None":
					break;
				case "User ID":
					defaultView.RowFilter = $"userid = {txtFilter.Text}";
					break;
				case "Person ID":
					defaultView.RowFilter = $"personid = {txtFilter.Text}";
					break;
				case "User Name":
					defaultView.RowFilter = $"username like '{txtFilter.Text}%'";
					break;
			}
		}

		private void btnAddPerson_Click(object sender, EventArgs e)
		{
			frmAddUpdateUser frm = new frmAddUpdateUser();
			frm.ShowDialog();

			users = clsUser.getAllUsers().DefaultView.ToTable(false, "UserID", "PersonID", "UserName", "IsActive");
			defaultView = users.DefaultView;
			dgvListPeople.DataSource = users;
		}

		private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int userId = (int)dgvListPeople.CurrentRow.Cells[0].Value;
			frmAddUpdateUser frm = new frmAddUpdateUser(userId);
			frm.ShowDialog();

			users = clsUser.getAllUsers().DefaultView.ToTable(false, "UserID", "PersonID", "UserName", "IsActive");
			defaultView = users.DefaultView;
			dgvListPeople.DataSource = users;
		}

		private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int userId = (int)dgvListPeople.CurrentRow.Cells[0].Value;
			if (clsUser.deleteUser(userId))
				MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
			{
				MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			users = clsUser.getAllUsers().DefaultView.ToTable(false, "UserID", "PersonID", "UserName", "IsActive");
			defaultView = users.DefaultView;
			dgvListPeople.DataSource = users;
		}

		private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int userId = (int)dgvListPeople.CurrentRow.Cells[0].Value;
			frmShowUser frm = new frmShowUser(userId);
			frm.ShowDialog();
		}

		private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAddUpdateUser frm = new frmAddUpdateUser();
			frm.ShowDialog();

			users = clsUser.getAllUsers().DefaultView.ToTable(false, "UserID", "PersonID", "UserName", "IsActive");
			defaultView = users.DefaultView;
			dgvListPeople.DataSource = users;
		}

		private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int userId = (int)dgvListPeople.CurrentRow.Cells[0].Value;
			frmChangePassword frm = new frmChangePassword(userId);
			frm.ShowDialog();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
