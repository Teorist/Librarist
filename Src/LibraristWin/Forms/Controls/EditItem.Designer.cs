namespace Librarist.Win.Forms.Controls
{
	partial class EditItem
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
			this.txtNote = new System.Windows.Forms.TextBox();
			this.lblNote = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblType = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtType = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtNote
			// 
			this.txtNote.Location = new System.Drawing.Point(52, 151);
			this.txtNote.Multiline = true;
			this.txtNote.Name = "txtNote";
			this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNote.Size = new System.Drawing.Size(407, 87);
			this.txtNote.TabIndex = 13;
			// 
			// lblNote
			// 
			this.lblNote.AutoSize = true;
			this.lblNote.Location = new System.Drawing.Point(8, 154);
			this.lblNote.Name = "lblNote";
			this.lblNote.Size = new System.Drawing.Size(38, 17);
			this.lblNote.TabIndex = 12;
			this.lblNote.Text = "Note";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(384, 244);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 26);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(294, 244);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 26);
			this.btnSave.TabIndex = 10;
			this.btnSave.Text = "OK";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(8, 20);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(35, 17);
			this.lblTitle.TabIndex = 14;
			this.lblTitle.Text = "Title";
			// 
			// lblType
			// 
			this.lblType.AutoSize = true;
			this.lblType.Location = new System.Drawing.Point(8, 54);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(40, 17);
			this.lblType.TabIndex = 15;
			this.lblType.Text = "Type";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(52, 20);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(407, 22);
			this.txtTitle.TabIndex = 16;
			// 
			// txtType
			// 
			this.txtType.Location = new System.Drawing.Point(52, 49);
			this.txtType.Name = "txtType";
			this.txtType.Size = new System.Drawing.Size(407, 22);
			this.txtType.TabIndex = 17;
			// 
			// EditItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.txtType);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.lblType);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.txtNote);
			this.Controls.Add(this.lblNote);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Name = "EditItem";
			this.Size = new System.Drawing.Size(473, 287);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNote;
		private System.Windows.Forms.Label lblNote;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtType;
	}
}
