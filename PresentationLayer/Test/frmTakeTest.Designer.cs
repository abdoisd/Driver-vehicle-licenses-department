namespace FullRealProject.Test
{
	partial class frmTakeTest
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.rbFail = new System.Windows.Forms.RadioButton();
			this.rbPass = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.ctlTestAppointment1 = new FullRealProject.Test.Controls.ctlTestAppointment();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.groupBox1.Controls.Add(this.txtNotes);
			this.groupBox1.Controls.Add(this.rbFail);
			this.groupBox1.Controls.Add(this.rbPass);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 342);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(766, 162);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Test Results";
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(171, 84);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(571, 64);
			this.txtNotes.TabIndex = 6;
			// 
			// rbFail
			// 
			this.rbFail.AutoSize = true;
			this.rbFail.Location = new System.Drawing.Point(254, 38);
			this.rbFail.Name = "rbFail";
			this.rbFail.Size = new System.Drawing.Size(64, 29);
			this.rbFail.TabIndex = 5;
			this.rbFail.TabStop = true;
			this.rbFail.Text = "Fail";
			this.rbFail.UseVisualStyleBackColor = true;
			// 
			// rbPass
			// 
			this.rbPass.AutoSize = true;
			this.rbPass.Location = new System.Drawing.Point(171, 38);
			this.rbPass.Name = "rbPass";
			this.rbPass.Size = new System.Drawing.Size(77, 29);
			this.rbPass.TabIndex = 4;
			this.rbPass.TabStop = true;
			this.rbPass.Text = "Pass";
			this.rbPass.UseVisualStyleBackColor = true;
			this.rbPass.Validating += new System.ComponentModel.CancelEventHandler(this.rbs_Validating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(37, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Test Notes:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(37, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Test Result:";
			// 
			// btnSave
			// 
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = global::FullRealProject.Properties.Resources.Save_32;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(680, 515);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 50);
			this.btnSave.TabIndex = 25;
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
			this.btnClose.Location = new System.Drawing.Point(574, 515);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 50);
			this.btnClose.TabIndex = 26;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// ctlTestAppointment1
			// 
			this.ctlTestAppointment1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.ctlTestAppointment1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.ctlTestAppointment1.Location = new System.Drawing.Point(13, 5);
			this.ctlTestAppointment1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ctlTestAppointment1.Name = "ctlTestAppointment1";
			this.ctlTestAppointment1.Size = new System.Drawing.Size(766, 329);
			this.ctlTestAppointment1.TabIndex = 0;
			// 
			// frmTakeTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(792, 577);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.ctlTestAppointment1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmTakeTest";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTakeTest";
			this.Load += new System.EventHandler(this.frmTakeTest_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.ctlTestAppointment ctlTestAppointment1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.RadioButton rbFail;
		private System.Windows.Forms.RadioButton rbPass;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
	}
}