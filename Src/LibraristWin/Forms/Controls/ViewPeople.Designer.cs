namespace Librarist.Win.Forms.Controls
{
	partial class ViewPeople
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
			this.btnModifyPeople = new System.Windows.Forms.Button();
			this.btnDeletePeople = new System.Windows.Forms.Button();
			this.btnAddPeople = new System.Windows.Forms.Button();
			this.listPeople = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnModifyPeople
			// 
			this.btnModifyPeople.Location = new System.Drawing.Point(684, 359);
			this.btnModifyPeople.Name = "btnModifyPeople";
			this.btnModifyPeople.Size = new System.Drawing.Size(75, 23);
			this.btnModifyPeople.TabIndex = 7;
			this.btnModifyPeople.Text = "Modify...";
			this.btnModifyPeople.UseVisualStyleBackColor = true;
			this.btnModifyPeople.Click += new System.EventHandler(this.btnModifyPeople_Click);
			// 
			// btnDeletePeople
			// 
			this.btnDeletePeople.Location = new System.Drawing.Point(765, 359);
			this.btnDeletePeople.Name = "btnDeletePeople";
			this.btnDeletePeople.Size = new System.Drawing.Size(75, 23);
			this.btnDeletePeople.TabIndex = 8;
			this.btnDeletePeople.Text = "Delete";
			this.btnDeletePeople.UseVisualStyleBackColor = true;
			this.btnDeletePeople.Click += new System.EventHandler(this.btnDeletePeople_Click);
			// 
			// btnAddPeople
			// 
			this.btnAddPeople.Location = new System.Drawing.Point(603, 358);
			this.btnAddPeople.Name = "btnAddPeople";
			this.btnAddPeople.Size = new System.Drawing.Size(75, 23);
			this.btnAddPeople.TabIndex = 6;
			this.btnAddPeople.Text = "Add...";
			this.btnAddPeople.UseVisualStyleBackColor = true;
			this.btnAddPeople.Click += new System.EventHandler(this.btnAddPeople_Click);
			// 
			// listPeople
			// 
			this.listPeople.FormattingEnabled = true;
			this.listPeople.ItemHeight = 16;
			this.listPeople.Location = new System.Drawing.Point(12, 12);
			this.listPeople.Name = "listPeople";
			this.listPeople.Size = new System.Drawing.Size(828, 340);
			this.listPeople.TabIndex = 5;
			// 
			// ViewPeople
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnModifyPeople);
			this.Controls.Add(this.btnDeletePeople);
			this.Controls.Add(this.btnAddPeople);
			this.Controls.Add(this.listPeople);
			this.Name = "ViewPeople";
			this.Size = new System.Drawing.Size(860, 402);
			this.Load += new System.EventHandler(this.ViewPeople_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnModifyPeople;
		private System.Windows.Forms.Button btnDeletePeople;
		private System.Windows.Forms.Button btnAddPeople;
		private System.Windows.Forms.ListBox listPeople;
	}
}
