namespace FullRealProject.Users
{
	partial class frmListUsers
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dgvListPeople = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.cbFilter = new System.Windows.Forms.ComboBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnAddPerson = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvListPeople
			// 
			this.dgvListPeople.AllowUserToAddRows = false;
			this.dgvListPeople.AllowUserToDeleteRows = false;
			this.dgvListPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvListPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListPeople.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvListPeople.Location = new System.Drawing.Point(17, 285);
			this.dgvListPeople.Margin = new System.Windows.Forms.Padding(44, 13, 44, 13);
			this.dgvListPeople.Name = "dgvListPeople";
			this.dgvListPeople.ReadOnly = true;
			this.dgvListPeople.RowHeadersWidth = 51;
			this.dgvListPeople.RowTemplate.Height = 24;
			this.dgvListPeople.Size = new System.Drawing.Size(1378, 404);
			this.dgvListPeople.TabIndex = 9;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.showDetailsToolStripMenuItem,
            this.updateUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(210, 194);
			// 
			// addUserToolStripMenuItem
			// 
			this.addUserToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.Add_New_User_32;
			this.addUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
			this.addUserToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
			this.addUserToolStripMenuItem.Text = "Add User";
			this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
			// 
			// showDetailsToolStripMenuItem
			// 
			this.showDetailsToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.PersonDetails_32;
			this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
			this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
			this.showDetailsToolStripMenuItem.Text = "Show Details";
			this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
			// 
			// updateUserToolStripMenuItem
			// 
			this.updateUserToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.edit_32;
			this.updateUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
			this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
			this.updateUserToolStripMenuItem.Text = "Update User";
			this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
			// 
			// deleteUserToolStripMenuItem
			// 
			this.deleteUserToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.Delete_32;
			this.deleteUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
			this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
			this.deleteUserToolStripMenuItem.Text = "Delete User";
			this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
			// 
			// changePasswordToolStripMenuItem
			// 
			this.changePasswordToolStripMenuItem.Image = global::FullRealProject.Properties.Resources.Password_32;
			this.changePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
			this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
			this.changePasswordToolStripMenuItem.Text = "Change Password";
			this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(570, 232);
			this.label1.Margin = new System.Windows.Forms.Padding(44, 0, 44, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(273, 44);
			this.label1.TabIndex = 7;
			this.label1.Text = "Manage Users";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 244);
			this.label2.Margin = new System.Windows.Forms.Padding(33, 0, 33, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 28);
			this.label2.TabIndex = 13;
			this.label2.Text = "Filter By:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtFilter
			// 
			this.txtFilter.Location = new System.Drawing.Point(346, 244);
			this.txtFilter.Margin = new System.Windows.Forms.Padding(33, 13, 33, 13);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(163, 34);
			this.txtFilter.TabIndex = 14;
			this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
			// 
			// cbFilter
			// 
			this.cbFilter.FormattingEnabled = true;
			this.cbFilter.Location = new System.Drawing.Point(136, 244);
			this.cbFilter.Margin = new System.Windows.Forms.Padding(33, 13, 33, 13);
			this.cbFilter.Name = "cbFilter";
			this.cbFilter.Size = new System.Drawing.Size(195, 36);
			this.cbFilter.TabIndex = 15;
			this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::FullRealProject.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(1295, 696);
			this.btnClose.Margin = new System.Windows.Forms.Padding(33, 13, 33, 13);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 50);
			this.btnClose.TabIndex = 11;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnAddPerson
			// 
			this.btnAddPerson.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnAddPerson.AutoSize = true;
			this.btnAddPerson.BackColor = System.Drawing.Color.White;
			this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddPerson.Image = global::FullRealProject.Properties.Resources.Add_New_User_32;
			this.btnAddPerson.Location = new System.Drawing.Point(1320, 221);
			this.btnAddPerson.Margin = new System.Windows.Forms.Padding(55, 26, 55, 26);
			this.btnAddPerson.Name = "btnAddPerson";
			this.btnAddPerson.Size = new System.Drawing.Size(75, 55);
			this.btnAddPerson.TabIndex = 12;
			this.btnAddPerson.UseVisualStyleBackColor = false;
			this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox1.Image = global::FullRealProject.Properties.Resources.Users_2_400;
			this.pictureBox1.Location = new System.Drawing.Point(606, 22);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(44, 13, 44, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// frmListUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(1404, 753);
			this.Controls.Add(this.cbFilter);
			this.Controls.Add(this.txtFilter);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnAddPerson);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dgvListPeople);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(44, 13, 44, 13);
			this.Name = "frmListUsers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmListUsers";
			this.Load += new System.EventHandler(this.frmListUsers_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridView dgvListPeople;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddPerson;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFilter;
		private System.Windows.Forms.ComboBox cbFilter;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
	}
}