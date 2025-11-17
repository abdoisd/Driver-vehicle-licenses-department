using FullRealProject.Bases;
using System;
using BusinessLayer;

namespace FullRealProject
{
	public partial class frmListApplicationTypes : frmList
	{
		public frmListApplicationTypes()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmListApplicationTypes_Load(object sender, EventArgs e)
		{
			// dgv
			dgvList.DataSource = clsApplicationType.getAllApplicationTypes();
			dgvList.AutoSizeColumnsMode	= System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dgvList.Columns[0].HeaderText = "ID";
			dgvList.Columns[1].HeaderText = "Title";
			dgvList.Columns[2].HeaderText = "Fees";
			dgvList.BackgroundColor = System.Drawing.Color.White;
		}
	}
}
