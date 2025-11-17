namespace FullRealProject.Bases
{
	partial class frmList
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		public System.ComponentModel.IContainer components = null;

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
		public void InitializeComponent()
		{
			this.btnClose = new System.Windows.Forms.Button();
			this.dgvList = new System.Windows.Forms.DataGridView();
			this.pbMainImage = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::FullRealProject.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(1291, 688);
			this.btnClose.Margin = new System.Windows.Forms.Padding(33, 13, 33, 13);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 50);
			this.btnClose.TabIndex = 19;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = false;
			// 
			// dgvList
			// 
			this.dgvList.AllowUserToAddRows = false;
			this.dgvList.AllowUserToDeleteRows = false;
			this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvList.Location = new System.Drawing.Point(13, 277);
			this.dgvList.Margin = new System.Windows.Forms.Padding(44, 13, 44, 13);
			this.dgvList.Name = "dgvList";
			this.dgvList.ReadOnly = true;
			this.dgvList.RowHeadersWidth = 51;
			this.dgvList.RowTemplate.Height = 24;
			this.dgvList.Size = new System.Drawing.Size(1378, 404);
			this.dgvList.TabIndex = 18;
			// 
			// pbMainImage
			// 
			this.pbMainImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pbMainImage.Location = new System.Drawing.Point(602, 14);
			this.pbMainImage.Margin = new System.Windows.Forms.Padding(44, 13, 44, 13);
			this.pbMainImage.Name = "pbMainImage";
			this.pbMainImage.Size = new System.Drawing.Size(200, 200);
			this.pbMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbMainImage.TabIndex = 17;
			this.pbMainImage.TabStop = false;
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.Red;
			this.lblTitle.Location = new System.Drawing.Point(566, 224);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(44, 0, 44, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(147, 44);
			this.lblTitle.TabIndex = 16;
			this.lblTitle.Text = "lbl Title";
			// 
			// frmList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(1404, 753);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dgvList);
			this.Controls.Add(this.pbMainImage);
			this.Controls.Add(this.lblTitle);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmBase";
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		protected System.Windows.Forms.Button btnClose;
		protected System.Windows.Forms.DataGridView dgvList;
		protected System.Windows.Forms.PictureBox pbMainImage;
		protected System.Windows.Forms.Label lblTitle;
	}
}