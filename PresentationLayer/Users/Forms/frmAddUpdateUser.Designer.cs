namespace FullRealProject.Users.Forms
{
	partial class frmAddUpdateUser
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.tcAddUpdateUser = new System.Windows.Forms.TabControl();
			this.tpPersonInfo = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAddPerson = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.cbFilter = new System.Windows.Forms.ComboBox();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnNext = new System.Windows.Forms.Button();
			this.uCtlShowPerson1 = new FullRealProject.People.Controls.uCtlShowPerson();
			this.tpLoginInfo = new System.Windows.Forms.TabPage();
			this.lblUserId = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbIsActive = new System.Windows.Forms.CheckBox();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.tcAddUpdateUser.SuspendLayout();
			this.tpPersonInfo.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tpLoginInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTitle.Location = new System.Drawing.Point(330, 13);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(342, 44);
			this.lblTitle.TabIndex = 14;
			this.lblTitle.Text = "Add / Update User";
			// 
			// tcAddUpdateUser
			// 
			this.tcAddUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.tcAddUpdateUser.Controls.Add(this.tpPersonInfo);
			this.tcAddUpdateUser.Controls.Add(this.tpLoginInfo);
			this.tcAddUpdateUser.Location = new System.Drawing.Point(12, 60);
			this.tcAddUpdateUser.Name = "tcAddUpdateUser";
			this.tcAddUpdateUser.SelectedIndex = 0;
			this.tcAddUpdateUser.Size = new System.Drawing.Size(979, 492);
			this.tcAddUpdateUser.TabIndex = 16;
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
			this.groupBox1.Controls.Add(this.btnAddPerson);
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
			// btnAddPerson
			// 
			this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddPerson.Image = global::FullRealProject.Properties.Resources.Add_Person_40;
			this.btnAddPerson.Location = new System.Drawing.Point(596, 20);
			this.btnAddPerson.Name = "btnAddPerson";
			this.btnAddPerson.Size = new System.Drawing.Size(50, 50);
			this.btnAddPerson.TabIndex = 21;
			this.btnAddPerson.UseVisualStyleBackColor = true;
			this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
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
			this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
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
			// tpLoginInfo
			// 
			this.tpLoginInfo.Controls.Add(this.lblUserId);
			this.tpLoginInfo.Controls.Add(this.label5);
			this.tpLoginInfo.Controls.Add(this.pictureBox4);
			this.tpLoginInfo.Controls.Add(this.pictureBox2);
			this.tpLoginInfo.Controls.Add(this.pictureBox1);
			this.tpLoginInfo.Controls.Add(this.label4);
			this.tpLoginInfo.Controls.Add(this.label3);
			this.tpLoginInfo.Controls.Add(this.label1);
			this.tpLoginInfo.Controls.Add(this.cbIsActive);
			this.tpLoginInfo.Controls.Add(this.txtConfirmPassword);
			this.tpLoginInfo.Controls.Add(this.txtPassword);
			this.tpLoginInfo.Controls.Add(this.txtUsername);
			this.tpLoginInfo.Location = new System.Drawing.Point(4, 37);
			this.tpLoginInfo.Name = "tpLoginInfo";
			this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tpLoginInfo.Size = new System.Drawing.Size(971, 451);
			this.tpLoginInfo.TabIndex = 1;
			this.tpLoginInfo.Text = "Login Info";
			this.tpLoginInfo.UseVisualStyleBackColor = true;
			// 
			// lblUserId
			// 
			this.lblUserId.AutoSize = true;
			this.lblUserId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserId.Location = new System.Drawing.Point(148, 46);
			this.lblUserId.Name = "lblUserId";
			this.lblUserId.Size = new System.Drawing.Size(51, 28);
			this.lblUserId.TabIndex = 13;
			this.lblUserId.Text = "[???]";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(49, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 28);
			this.label5.TabIndex = 12;
			this.label5.Text = "User Id:";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::FullRealProject.Properties.Resources.Number_32;
			this.pictureBox4.Location = new System.Drawing.Point(261, 228);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(34, 34);
			this.pictureBox4.TabIndex = 11;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::FullRealProject.Properties.Resources.Number_32;
			this.pictureBox2.Location = new System.Drawing.Point(261, 167);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(34, 34);
			this.pictureBox2.TabIndex = 9;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::FullRealProject.Properties.Resources.Person_32;
			this.pictureBox1.Location = new System.Drawing.Point(261, 103);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(34, 34);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(49, 228);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(197, 28);
			this.label4.TabIndex = 7;
			this.label4.Text = "Confirm Pass Word:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(49, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 28);
			this.label3.TabIndex = 6;
			this.label3.Text = "Pass Word:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(49, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 28);
			this.label1.TabIndex = 5;
			this.label1.Text = "User Name:";
			// 
			// cbIsActive
			// 
			this.cbIsActive.AutoSize = true;
			this.cbIsActive.Location = new System.Drawing.Point(301, 283);
			this.cbIsActive.Name = "cbIsActive";
			this.cbIsActive.Size = new System.Drawing.Size(108, 29);
			this.cbIsActive.TabIndex = 4;
			this.cbIsActive.Text = "Is Active";
			this.cbIsActive.UseVisualStyleBackColor = true;
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Location = new System.Drawing.Point(301, 227);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.Size = new System.Drawing.Size(150, 30);
			this.txtConfirmPassword.TabIndex = 3;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(301, 165);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(150, 30);
			this.txtPassword.TabIndex = 2;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(301, 103);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(150, 30);
			this.txtUsername.TabIndex = 1;
			this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = global::FullRealProject.Properties.Resources.Save_32;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(891, 554);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 50);
			this.btnSave.TabIndex = 17;
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
			this.btnClose.Location = new System.Drawing.Point(785, 554);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 50);
			this.btnClose.TabIndex = 18;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// frmAddUpdateUser
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(1001, 615);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.tcAddUpdateUser);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmAddUpdateUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAddUpdateUser";
			this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
			this.tcAddUpdateUser.ResumeLayout(false);
			this.tpPersonInfo.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tpLoginInfo.ResumeLayout(false);
			this.tpLoginInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private People.Controls.uCtlShowPerson uCtlShowPerson1;
		private System.Windows.Forms.TabControl tcAddUpdateUser;
		private System.Windows.Forms.TabPage tpPersonInfo;
		private System.Windows.Forms.TabPage tpLoginInfo;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox cbFilter;
		private System.Windows.Forms.TextBox txtFilter;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAddPerson;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox cbIsActive;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label lblUserId;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}