namespace FullRealProject.Users.Controls
{
	partial class ctlShowUser
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblIsActive = new System.Windows.Forms.Label();
			this.lblPersonId = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.uCtlShowPerson1 = new FullRealProject.People.Controls.uCtlShowPerson();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblUsername);
			this.groupBox1.Controls.Add(this.lblIsActive);
			this.groupBox1.Controls.Add(this.lblPersonId);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(3, 309);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(956, 82);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Login Info";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.Location = new System.Drawing.Point(248, 30);
			this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(68, 25);
			this.lblUsername.TabIndex = 167;
			this.lblUsername.Text = "[????]";
			// 
			// lblIsActive
			// 
			this.lblIsActive.AutoSize = true;
			this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIsActive.Location = new System.Drawing.Point(734, 30);
			this.lblIsActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblIsActive.Name = "lblIsActive";
			this.lblIsActive.Size = new System.Drawing.Size(68, 25);
			this.lblIsActive.TabIndex = 166;
			this.lblIsActive.Text = "[????]";
			// 
			// lblPersonId
			// 
			this.lblPersonId.AutoSize = true;
			this.lblPersonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPersonId.Location = new System.Drawing.Point(491, 30);
			this.lblPersonId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPersonId.Name = "lblPersonId";
			this.lblPersonId.Size = new System.Drawing.Size(68, 25);
			this.lblPersonId.TabIndex = 165;
			this.lblPersonId.Text = "[????]";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(609, 30);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 25);
			this.label3.TabIndex = 145;
			this.label3.Text = "Is Active:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(123, 30);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 25);
			this.label2.TabIndex = 144;
			this.label2.Text = "Username:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(366, 30);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 25);
			this.label1.TabIndex = 143;
			this.label1.Text = "User ID:";
			// 
			// uCtlShowPerson1
			// 
			this.uCtlShowPerson1.Location = new System.Drawing.Point(3, 3);
			this.uCtlShowPerson1.Name = "uCtlShowPerson1";
			this.uCtlShowPerson1.Size = new System.Drawing.Size(956, 300);
			this.uCtlShowPerson1.TabIndex = 0;
			// 
			// ctlShowUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.uCtlShowPerson1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.Name = "ctlShowUser";
			this.Size = new System.Drawing.Size(967, 403);
			this.Click += new System.EventHandler(this.ctlShowUser_Click);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private People.Controls.uCtlShowPerson uCtlShowPerson1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label lblIsActive;
		private System.Windows.Forms.Label lblPersonId;
	}
}
