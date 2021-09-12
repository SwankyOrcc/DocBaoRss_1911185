
namespace DocBaoRss
{
	partial class AddFeedForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbbPublishers = new System.Windows.Forms.ComboBox();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.txtRssLink = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Toà soạn";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên chuyên mục";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "RssLink";
			// 
			// cbbPublishers
			// 
			this.cbbPublishers.FormattingEnabled = true;
			this.cbbPublishers.Location = new System.Drawing.Point(112, 17);
			this.cbbPublishers.Name = "cbbPublishers";
			this.cbbPublishers.Size = new System.Drawing.Size(159, 23);
			this.cbbPublishers.TabIndex = 3;
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(112, 46);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(159, 23);
			this.txtCategoryName.TabIndex = 4;
			// 
			// txtRssLink
			// 
			this.txtRssLink.Location = new System.Drawing.Point(112, 78);
			this.txtRssLink.Name = "txtRssLink";
			this.txtRssLink.Size = new System.Drawing.Size(313, 23);
			this.txtRssLink.TabIndex = 5;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(251, 121);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(350, 121);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Đóng";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// AddFeedForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 156);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtRssLink);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.cbbPublishers);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AddFeedForm";
			this.Text = "AddFeedForm";
			this.Load += new System.EventHandler(this.AddFeedForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbbPublishers;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.TextBox txtRssLink;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button button2;
	}
}