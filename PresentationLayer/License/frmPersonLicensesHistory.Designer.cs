namespace FullRealProject.License
{
	partial class frmDriverLicensesHistory
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tcLocal = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnClose = new System.Windows.Forms.Button();
			this.uCtlShowPerson1 = new FullRealProject.People.Controls.uCtlShowPerson();
			this.dgvLocal = new System.Windows.Forms.DataGridView();
			this.dgvInternational = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tcLocal.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::FullRealProject.Properties.Resources.PersonLicenseHistory_512;
			this.pictureBox1.Location = new System.Drawing.Point(10, 103);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(371, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(443, 42);
			this.label1.TabIndex = 2;
			this.label1.Text = "Driving Licenses History";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.tcLocal);
			this.groupBox1.Location = new System.Drawing.Point(12, 357);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1160, 264);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Driving Licenses";
			// 
			// tcLocal
			// 
			this.tcLocal.Controls.Add(this.tabPage1);
			this.tcLocal.Controls.Add(this.tabPage2);
			this.tcLocal.Location = new System.Drawing.Point(6, 29);
			this.tcLocal.Name = "tcLocal";
			this.tcLocal.SelectedIndex = 0;
			this.tcLocal.Size = new System.Drawing.Size(1148, 229);
			this.tcLocal.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dgvLocal);
			this.tabPage1.Location = new System.Drawing.Point(4, 34);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1140, 191);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Local";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dgvInternational);
			this.tabPage2.Location = new System.Drawing.Point(4, 34);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1140, 191);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "International";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::FullRealProject.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(1071, 627);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 51);
			this.btnClose.TabIndex = 182;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// uCtlShowPerson1
			// 
			this.uCtlShowPerson1.Location = new System.Drawing.Point(216, 51);
			this.uCtlShowPerson1.Name = "uCtlShowPerson1";
			this.uCtlShowPerson1.Size = new System.Drawing.Size(956, 300);
			this.uCtlShowPerson1.TabIndex = 1;
			// 
			// dgvLocal
			// 
			this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLocal.Location = new System.Drawing.Point(6, 6);
			this.dgvLocal.Name = "dgvLocal";
			this.dgvLocal.RowHeadersWidth = 51;
			this.dgvLocal.RowTemplate.Height = 24;
			this.dgvLocal.Size = new System.Drawing.Size(1128, 182);
			this.dgvLocal.TabIndex = 0;
			// 
			// dgvInternational
			// 
			this.dgvInternational.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInternational.Location = new System.Drawing.Point(6, 6);
			this.dgvInternational.Name = "dgvInternational";
			this.dgvInternational.RowHeadersWidth = 51;
			this.dgvInternational.RowTemplate.Height = 24;
			this.dgvInternational.Size = new System.Drawing.Size(1128, 182);
			this.dgvInternational.TabIndex = 1;
			// 
			// frmPersonLicensesHistory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(1183, 690);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.uCtlShowPerson1);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmPersonLicensesHistory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmPersonLicensesHistory";
			this.Load += new System.EventHandler(this.frmPersonLicensesHistory_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.tcLocal.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private People.Controls.uCtlShowPerson uCtlShowPerson1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabControl tcLocal;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dgvLocal;
		private System.Windows.Forms.DataGridView dgvInternational;
	}
}