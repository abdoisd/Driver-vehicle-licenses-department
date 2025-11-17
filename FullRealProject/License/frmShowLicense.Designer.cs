namespace FullRealProject.License
{
	partial class frmShowLicense
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
			this.ctlShowLicense1 = new FullRealProject.License.Controls.ctlShowLicense();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ctlShowLicense1
			// 
			this.ctlShowLicense1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctlShowLicense1.License = null;
			this.ctlShowLicense1.Location = new System.Drawing.Point(13, 13);
			this.ctlShowLicense1.Margin = new System.Windows.Forms.Padding(4);
			this.ctlShowLicense1.Name = "ctlShowLicense1";
			this.ctlShowLicense1.Size = new System.Drawing.Size(867, 339);
			this.ctlShowLicense1.TabIndex = 0;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::FullRealProject.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(772, 359);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 50);
			this.btnClose.TabIndex = 24;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmShowLicense
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(884, 419);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.ctlShowLicense1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmShowLicense";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmShowLicense";
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.ctlShowLicense ctlShowLicense1;
		private System.Windows.Forms.Button btnClose;
	}
}