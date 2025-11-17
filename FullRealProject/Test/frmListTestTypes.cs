using BusinessLayer;
using FullRealProject.Bases;
using System;

namespace FullRealProject
{
	public partial class frmListTestTypes : frmList
	{
		public frmListTestTypes()
		{
			InitializeComponent();
		}

		private void frmListTestTypes_Load(object sender, EventArgs e)
		{
			// dgv
			dgvList.DataSource = clsTestType.getAllTestTypes();
			dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dgvList.Columns[0].HeaderText = "ID";
			dgvList.Columns[1].HeaderText = "Title";
			dgvList.Columns[2].HeaderText = "Description";
			dgvList.Columns[3].HeaderText = "Fees";
			dgvList.BackgroundColor = System.Drawing.Color.White;
		}

		private void editTestToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
