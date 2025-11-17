using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullRealProject
{
	public partial class frmTest : Form
	{
		public frmTest()
		{
			InitializeComponent();
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Return)
			{
				// Your code here
				MessageBox.Show("Enter was pressed!");
				// Prevent the "ding" sound
				e.Handled = true;
			}
		}
	}
}
