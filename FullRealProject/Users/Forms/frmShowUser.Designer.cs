namespace FullRealProject.Users.Forms
{
	partial class frmShowUser
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
			this.label2 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.ctlShowUser1 = new FullRealProject.Users.Controls.ctlShowUser();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(406, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 44);
			this.label2.TabIndex = 10;
			this.label2.Text = "User Info";
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnClose.Image = global::FullRealProject.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(872, 474);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 50);
			this.btnClose.TabIndex = 12;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// ctlShowUser1
			// 
			this.ctlShowUser1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.ctlShowUser1.Location = new System.Drawing.Point(6, 71);
			this.ctlShowUser1.Name = "ctlShowUser1";
			this.ctlShowUser1.Size = new System.Drawing.Size(966, 403);
			this.ctlShowUser1.TabIndex = 13;
			// 
			// frmShowUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(984, 536);
			this.Controls.Add(this.ctlShowUser1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmShowUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmShowUser";
			this.Load += new System.EventHandler(this.frmShowUser_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnClose;
		private Controls.ctlShowUser ctlShowUser1;
	}
}