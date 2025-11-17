namespace FullRealProject.Applications
{
	partial class frmAddUpdateApplication
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.tcAddUpdateUser = new System.Windows.Forms.TabControl();
			this.tpPersonInfo = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.cbFilter = new System.Windows.Forms.ComboBox();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnNext = new System.Windows.Forms.Button();
			this.uCtlShowPerson1 = new FullRealProject.People.Controls.uCtlShowPerson();
			this.tpApplicationInfo = new System.Windows.Forms.TabPage();
			this.lblCreatedByUser = new System.Windows.Forms.Label();
			this.lblApplicationFees = new System.Windows.Forms.Label();
			this.lblApplicationDate = new System.Windows.Forms.Label();
			this.cbLicenseClasses = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblLDLAId = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPaidFees = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.tcAddUpdateUser.SuspendLayout();
			this.tpPersonInfo.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tpApplicationInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle.Location = new System.Drawing.Point(216, 12);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(569, 44);
			this.lblTitle.TabIndex = 19;
			this.lblTitle.Text = "Add / Update Local Application";
			// 
			// tcAddUpdateUser
			// 
			this.tcAddUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.tcAddUpdateUser.Controls.Add(this.tpPersonInfo);
			this.tcAddUpdateUser.Controls.Add(this.tpApplicationInfo);
			this.tcAddUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tcAddUpdateUser.Location = new System.Drawing.Point(11, 59);
			this.tcAddUpdateUser.Name = "tcAddUpdateUser";
			this.tcAddUpdateUser.SelectedIndex = 0;
			this.tcAddUpdateUser.Size = new System.Drawing.Size(979, 492);
			this.tcAddUpdateUser.TabIndex = 20;
			// 
			// tpPersonInfo
			// 
			this.tpPersonInfo.Controls.Add(this.groupBox1);
			this.tpPersonInfo.Controls.Add(this.btnNext);
			this.tpPersonInfo.Controls.Add(this.uCtlShowPerson1);
			this.tpPersonInfo.Location = new System.Drawing.Point(4, 34);
			this.tpPersonInfo.Name = "tpPersonInfo";
			this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tpPersonInfo.Size = new System.Drawing.Size(971, 454);
			this.tpPersonInfo.TabIndex = 0;
			this.tpPersonInfo.Text = "Personal Info";
			this.tpPersonInfo.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.cbFilter);
			this.groupBox1.Controls.Add(this.txtFilter);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(8, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(955, 76);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filter";
			// 
			// btnSearch
			// 
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Image = global::FullRealProject.Properties.Resources.SearchPerson;
			this.btnSearch.Location = new System.Drawing.Point(523, 20);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(50, 50);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// cbFilter
			// 
			this.cbFilter.BackColor = System.Drawing.Color.White;
			this.cbFilter.FormattingEnabled = true;
			this.cbFilter.Location = new System.Drawing.Point(123, 27);
			this.cbFilter.Name = "cbFilter";
			this.cbFilter.Size = new System.Drawing.Size(142, 33);
			this.cbFilter.TabIndex = 0;
			// 
			// txtFilter
			// 
			this.txtFilter.Location = new System.Drawing.Point(271, 28);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(231, 30);
			this.txtFilter.TabIndex = 1;
			this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 28);
			this.label2.TabIndex = 16;
			this.label2.Text = "Filter By:";
			// 
			// btnNext
			// 
			this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNext.Image = global::FullRealProject.Properties.Resources.Next_32;
			this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNext.Location = new System.Drawing.Point(863, 395);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(100, 50);
			this.btnNext.TabIndex = 19;
			this.btnNext.Text = "Next";
			this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// uCtlShowPerson1
			// 
			this.uCtlShowPerson1.Location = new System.Drawing.Point(8, 87);
			this.uCtlShowPerson1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.uCtlShowPerson1.Name = "uCtlShowPerson1";
			this.uCtlShowPerson1.Size = new System.Drawing.Size(956, 300);
			this.uCtlShowPerson1.TabIndex = 15;
			// 
			// tpApplicationInfo
			// 
			this.tpApplicationInfo.Controls.Add(this.lblCreatedByUser);
			this.tpApplicationInfo.Controls.Add(this.lblApplicationFees);
			this.tpApplicationInfo.Controls.Add(this.lblApplicationDate);
			this.tpApplicationInfo.Controls.Add(this.cbLicenseClasses);
			this.tpApplicationInfo.Controls.Add(this.label1);
			this.tpApplicationInfo.Controls.Add(this.lblLDLAId);
			this.tpApplicationInfo.Controls.Add(this.label5);
			this.tpApplicationInfo.Controls.Add(this.label4);
			this.tpApplicationInfo.Controls.Add(this.label3);
			this.tpApplicationInfo.Controls.Add(this.txtPaidFees);
			this.tpApplicationInfo.Controls.Add(this.pictureBox3);
			this.tpApplicationInfo.Controls.Add(this.pictureBox4);
			this.tpApplicationInfo.Controls.Add(this.pictureBox2);
			this.tpApplicationInfo.Controls.Add(this.pictureBox1);
			this.tpApplicationInfo.Location = new System.Drawing.Point(4, 34);
			this.tpApplicationInfo.Name = "tpApplicationInfo";
			this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tpApplicationInfo.Size = new System.Drawing.Size(971, 454);
			this.tpApplicationInfo.TabIndex = 1;
			this.tpApplicationInfo.Text = "Application Info";
			this.tpApplicationInfo.UseVisualStyleBackColor = true;
			// 
			// lblCreatedByUser
			// 
			this.lblCreatedByUser.AutoSize = true;
			this.lblCreatedByUser.Location = new System.Drawing.Point(334, 287);
			this.lblCreatedByUser.Name = "lblCreatedByUser";
			this.lblCreatedByUser.Size = new System.Drawing.Size(57, 25);
			this.lblCreatedByUser.TabIndex = 19;
			this.lblCreatedByUser.Text = "[???]";
			// 
			// lblApplicationFees
			// 
			this.lblApplicationFees.AutoSize = true;
			this.lblApplicationFees.Location = new System.Drawing.Point(334, 231);
			this.lblApplicationFees.Name = "lblApplicationFees";
			this.lblApplicationFees.Size = new System.Drawing.Size(57, 25);
			this.lblApplicationFees.TabIndex = 18;
			this.lblApplicationFees.Text = "[???]";
			// 
			// lblApplicationDate
			// 
			this.lblApplicationDate.AutoSize = true;
			this.lblApplicationDate.Location = new System.Drawing.Point(334, 109);
			this.lblApplicationDate.Name = "lblApplicationDate";
			this.lblApplicationDate.Size = new System.Drawing.Size(57, 25);
			this.lblApplicationDate.TabIndex = 17;
			this.lblApplicationDate.Text = "[???]";
			// 
			// cbLicenseClasses
			// 
			this.cbLicenseClasses.FormattingEnabled = true;
			this.cbLicenseClasses.Location = new System.Drawing.Point(327, 167);
			this.cbLicenseClasses.Name = "cbLicenseClasses";
			this.cbLicenseClasses.Size = new System.Drawing.Size(350, 33);
			this.cbLicenseClasses.TabIndex = 16;
			this.cbLicenseClasses.SelectedIndexChanged += new System.EventHandler(this.cbLicenseClasses_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(49, 284);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 28);
			this.label1.TabIndex = 14;
			this.label1.Text = "Created By:";
			// 
			// lblLDLAId
			// 
			this.lblLDLAId.AutoSize = true;
			this.lblLDLAId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLDLAId.Location = new System.Drawing.Point(218, 46);
			this.lblLDLAId.Name = "lblLDLAId";
			this.lblLDLAId.Size = new System.Drawing.Size(51, 28);
			this.lblLDLAId.TabIndex = 13;
			this.lblLDLAId.Text = "[???]";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(49, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(150, 28);
			this.label5.TabIndex = 12;
			this.label5.Text = "Application Id:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(49, 228);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(173, 28);
			this.label4.TabIndex = 7;
			this.label4.Text = "Application Fees:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(49, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 28);
			this.label3.TabIndex = 6;
			this.label3.Text = "License Class:";
			// 
			// txtPaidFees
			// 
			this.txtPaidFees.AutoSize = true;
			this.txtPaidFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPaidFees.Location = new System.Drawing.Point(49, 106);
			this.txtPaidFees.Name = "txtPaidFees";
			this.txtPaidFees.Size = new System.Drawing.Size(177, 28);
			this.txtPaidFees.TabIndex = 5;
			this.txtPaidFees.Text = "Application Date:";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::FullRealProject.Properties.Resources.User_32__2;
			this.pictureBox3.Location = new System.Drawing.Point(261, 284);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(34, 34);
			this.pictureBox3.TabIndex = 15;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::FullRealProject.Properties.Resources.money_32;
			this.pictureBox4.Location = new System.Drawing.Point(261, 228);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(34, 34);
			this.pictureBox4.TabIndex = 11;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::FullRealProject.Properties.Resources.License_Type_32;
			this.pictureBox2.Location = new System.Drawing.Point(261, 167);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(34, 34);
			this.pictureBox2.TabIndex = 9;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::FullRealProject.Properties.Resources.Calendar_32;
			this.pictureBox1.Location = new System.Drawing.Point(261, 103);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(34, 34);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = global::FullRealProject.Properties.Resources.Save_32;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(890, 553);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 50);
			this.btnSave.TabIndex = 21;
			this.btnSave.Text = "Save";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::FullRealProject.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(784, 553);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 50);
			this.btnClose.TabIndex = 22;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmAddUpdateApplication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(1001, 615);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.tcAddUpdateUser);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmAddUpdateApplication";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAddApplication";
			this.Activated += new System.EventHandler(this.frmAddUpdateApplication_Activated);
			this.Load += new System.EventHandler(this.frmAddApplication_Load);
			this.tcAddUpdateUser.ResumeLayout(false);
			this.tpPersonInfo.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tpApplicationInfo.ResumeLayout(false);
			this.tpApplicationInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TabControl tcAddUpdateUser;
		private System.Windows.Forms.TabPage tpPersonInfo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox cbFilter;
		private System.Windows.Forms.TextBox txtFilter;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnNext;
		private People.Controls.uCtlShowPerson uCtlShowPerson1;
		private System.Windows.Forms.TabPage tpApplicationInfo;
		private System.Windows.Forms.Label lblLDLAId;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label txtPaidFees;
		private System.Windows.Forms.Label lblCreatedByUser;
		private System.Windows.Forms.Label lblApplicationFees;
		private System.Windows.Forms.Label lblApplicationDate;
		private System.Windows.Forms.ComboBox cbLicenseClasses;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label1;
	}
}