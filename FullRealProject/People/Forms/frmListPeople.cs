using BusinessLayer;
using System;
using System.Windows.Forms;

namespace FullRealProject.People.Forms
{
	public partial class frmListPeople : Form
	{
		public frmListPeople()
		{
			InitializeComponent();
		}

		private void frmListPeople_Load(object sender, EventArgs e)
		{
			// dgv
			dgvListPeople.DataSource = clsPerson.getAllPeople();
			dgvListPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvListPeople.BackgroundColor = System.Drawing.Color.White;
		}

		private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int personId = (int)dgvListPeople.CurrentRow.Cells[0].Value;
			if (clsPerson.delete(personId))
				MessageBox.Show($"Person {personId} deleted successfully");
			else
				MessageBox.Show($"Failure deleting person {personId}");
			dgvListPeople.DataSource = clsPerson.getAllPeople();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnAddPerson_Click(object sender, EventArgs e)
		{
			frmAddUpdatePerson frm = new frmAddUpdatePerson();
			frm.ShowDialog();
			dgvListPeople.DataSource = clsPerson.getAllPeople();
		}

		private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int personId = (int)dgvListPeople.CurrentRow.Cells[0].Value;
			frmAddUpdatePerson frm = new frmAddUpdatePerson(personId);
			frm.ShowDialog();
			dgvListPeople.DataSource = clsPerson.getAllPeople();
		}

		private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int personId = (int)dgvListPeople.CurrentRow.Cells[0].Value;
			frmShowPerson frm = new frmShowPerson(personId);
			frm.ShowDialog();
		}

		private void dgvListPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAddUpdatePerson frm = new frmAddUpdatePerson();
			frm.ShowDialog();
			dgvListPeople.DataSource = clsPerson.getAllPeople();
		}
	}
}
