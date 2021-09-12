
namespace DocBaoRss.Component
{
	partial class NewsControl
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblPublisherDate = new System.Windows.Forms.Label();
			this.lblDetail = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoEllipsis = true;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblTitle.ForeColor = System.Drawing.Color.Blue;
			this.lblTitle.Location = new System.Drawing.Point(20, 18);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(40, 15);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "label1";
			// 
			// lblDescription
			// 
			this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDescription.AutoEllipsis = true;
			this.lblDescription.Location = new System.Drawing.Point(20, 52);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(496, 81);
			this.lblDescription.TabIndex = 1;
			this.lblDescription.Text = "label2";
			// 
			// lblPublisherDate
			// 
			this.lblPublisherDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblPublisherDate.AutoSize = true;
			this.lblPublisherDate.Location = new System.Drawing.Point(20, 118);
			this.lblPublisherDate.Name = "lblPublisherDate";
			this.lblPublisherDate.Size = new System.Drawing.Size(38, 15);
			this.lblPublisherDate.TabIndex = 2;
			this.lblPublisherDate.Text = "label3";
			// 
			// lblDetail
			// 
			this.lblDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDetail.AutoSize = true;
			this.lblDetail.Location = new System.Drawing.Point(456, 118);
			this.lblDetail.Name = "lblDetail";
			this.lblDetail.Size = new System.Drawing.Size(70, 15);
			this.lblDetail.TabIndex = 3;
			this.lblDetail.TabStop = true;
			this.lblDetail.Text = "Xem chi tiết";
			// 
			// NewsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.lblDetail);
			this.Controls.Add(this.lblPublisherDate);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.lblTitle);
			this.Name = "NewsControl";
			this.Size = new System.Drawing.Size(552, 150);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblPublisherDate;
		private System.Windows.Forms.LinkLabel lblDetail;
	}
}
