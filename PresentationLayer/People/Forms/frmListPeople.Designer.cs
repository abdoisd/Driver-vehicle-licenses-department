namespace FullRealProject.People.Forms
{
	partial class frmListPeople
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
			this.cmsListPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updatePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvListPeople = new System.Windows.Forms.DataGridView();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnAddPerson = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.cmsListPeople.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmsListPeople
			// 
			this.cmsListPeople.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsListPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPersonToolStripMenuItem,
            this.showDetailsToolStripMenuItem,
            this.updatePersonToolStripMenuItem,
            this.deletePersonToolStripMenuItem});
			this.cmsListPeople.Name = "cmsListPeople";
			this.cmsListPeople.Size = new System.Drawing.Size(175, 100);
			// 
			// addPersonToolStripMenuItem
			// 
			this.addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
			this.addPersonToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
			this.addPersonToolStripMenuItem.Text = "Add Person";
			this.addPersonToolStripMenuItem.Click += new System.EventHandler(this.addPersonToolStripMenuItem_Click);
			// 
			// showDetailsToolStripMenuItem
			// 
			this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
			this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
			this.showDetailsToolStripMenuItem.Text = "Show Details";
			this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
			// 
			// updatePersonToolStripMenuItem
			// 
			this.updatePersonToolStripMenuItem.Name = "updatePersonToolStripMenuItem";
			this.updatePersonToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
			this.updatePersonToolStripMenuItem.Text = "Update Person";
			this.updatePersonToolStripMenuItem.Click += new System.EventHandler(this.updatePersonToolStripMenuItem_Click);
			// 
			// deletePersonToolStripMenuItem
			// 
			this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
			this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
			this.deletePersonToolStripMenuItem.Text = "Delete Person";
			this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(562, 221);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(292, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "Manage People";
			// 
			// dgvListPeople
			// 
			this.dgvListPeople.AllowUserToAddRows = false;
			this.dgvListPeople.AllowUserToDeleteRows = false;
			this.dgvListPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvListPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListPeople.ContextMenuStrip = this.cmsListPeople;
			this.dgvListPeople.Location = new System.Drawing.Point(13, 281);
			this.dgvListPeople.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.dgvListPeople.Name = "dgvListPeople";
			this.dgvListPeople.ReadOnly = true;
			this.dgvListPeople.RowHeadersWidth = 51;
			this.dgvListPeople.RowTemplate.Height = 24;
			this.dgvListPeople.Size = new System.Drawing.Size(1378, 404);
			this.dgvListPeople.TabIndex = 2;
			this.dgvListPeople.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListPeople_CellContentClick);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::FullRealProject.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(1290, 691);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 50);
			this.btnClose.TabIndex = 6;
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
			this.btnAddPerson.Image = global::FullRealProject.Properties.Resources.Add_Person_40;
			this.btnAddPerson.Location = new System.Drawing.Point(1315, 217);
			this.btnAddPerson.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnAddPerson.Name = "btnAddPerson";
			this.btnAddPerson.Size = new System.Drawing.Size(75, 55);
			this.btnAddPerson.TabIndex = 5;
			this.btnAddPerson.UseVisualStyleBackColor = false;
			this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox1.Image = global::FullRealProject.Properties.Resources.People_400;
			this.pictureBox1.Location = new System.Drawing.Point(602, 12);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// frmListPeople
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(1404, 753);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnAddPerson);
			this.Controls.Add(this.dgvListPeople);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "frmListPeople";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmListPeople";
			this.Load += new System.EventHandler(this.frmListPeople_Load);
			this.cmsListPeople.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ContextMenuStrip cmsListPeople;
		private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updatePersonToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView dgvListPeople;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnAddPerson;
		private System.Windows.Forms.ToolStripMenuItem addPersonToolStripMenuItem;
	}
}