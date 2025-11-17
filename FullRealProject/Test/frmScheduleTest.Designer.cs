namespace FullRealProject.Test
{
	partial class frmScheduleTest
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
			this.ctlTestAppointment1 = new FullRealProject.Test.Controls.ctlTestAppointment();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ctlTestAppointment1
			// 
			this.ctlTestAppointment1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.ctlTestAppointment1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.ctlTestAppointment1.Location = new System.Drawing.Point(13, 1);
			this.ctlTestAppointment1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ctlTestAppointment1.Name = "ctlTestAppointment1";
			this.ctlTestAppointment1.Size = new System.Drawing.Size(766, 329);
			this.ctlTestAppointment1.TabIndex = 0;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = global::FullRealProject.Properties.Resources.Save_32;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(669, 338);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 50);
			this.btnSave.TabIndex = 23;
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
			this.btnClose.Location = new System.Drawing.Point(563, 338);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 50);
			this.btnClose.TabIndex = 24;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmScheduleTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(790, 400);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.ctlTestAppointment1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmScheduleTest";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmScheduleTest";
			this.Load += new System.EventHandler(this.frmScheduleTest_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.ctlTestAppointment ctlTestAppointment1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
	}
}