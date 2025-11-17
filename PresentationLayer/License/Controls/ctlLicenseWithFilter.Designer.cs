namespace FullRealProject.License.Controls
{
	partial class ctlLicenseWithFilter
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.gbFilters = new System.Windows.Forms.GroupBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.txtLicenseID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.ctrlDriverLicenseInfo1 = new FullRealProject.License.Controls.ctlShowLicense();
			this.gbFilters.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// gbFilters
			// 
			this.gbFilters.Controls.Add(this.btnFind);
			this.gbFilters.Controls.Add(this.txtLicenseID);
			this.gbFilters.Controls.Add(this.label1);
			this.gbFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.gbFilters.Location = new System.Drawing.Point(12, 4);
			this.gbFilters.Margin = new System.Windows.Forms.Padding(4);
			this.gbFilters.Name = "gbFilters";
			this.gbFilters.Padding = new System.Windows.Forms.Padding(4);
			this.gbFilters.Size = new System.Drawing.Size(535, 78);
			this.gbFilters.TabIndex = 17;
			this.gbFilters.TabStop = false;
			this.gbFilters.Text = "Filter";
			// 
			// btnFind
			// 
			this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFind.Image = global::FullRealProject.Properties.Resources.License_View_32;
			this.btnFind.Location = new System.Drawing.Point(456, 21);
			this.btnFind.Margin = new System.Windows.Forms.Padding(4);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(45, 45);
			this.btnFind.TabIndex = 18;
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// txtLicenseID
			// 
			this.txtLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLicenseID.Location = new System.Drawing.Point(145, 29);
			this.txtLicenseID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtLicenseID.Name = "txtLicenseID";
			this.txtLicenseID.Size = new System.Drawing.Size(285, 30);
			this.txtLicenseID.TabIndex = 17;
			this.txtLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLicenseID_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(21, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 25);
			this.label1.TabIndex = 19;
			this.label1.Text = "LicenseID:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// ctrlDriverLicenseInfo1
			// 
			this.ctrlDriverLicenseInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctrlDriverLicenseInfo1.License = null;
			this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(5, 75);
			this.ctrlDriverLicenseInfo1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
			this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(866, 342);
			this.ctrlDriverLicenseInfo1.TabIndex = 0;
			// 
			// ctlLicenseWithFilter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.gbFilters);
			this.Controls.Add(this.ctrlDriverLicenseInfo1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ctlLicenseWithFilter";
			this.Size = new System.Drawing.Size(875, 420);
			this.gbFilters.ResumeLayout(false);
			this.gbFilters.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private License.Controls.ctlShowLicense ctrlDriverLicenseInfo1;
		private System.Windows.Forms.GroupBox gbFilters;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.TextBox txtLicenseID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}
