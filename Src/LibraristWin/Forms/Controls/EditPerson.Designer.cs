namespace Librarist.Win.Forms.Controls
{
	partial class EditPerson
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
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblNote = new System.Windows.Forms.Label();
			this.txtNote = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(306, 207);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 26);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "OK";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(387, 207);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 26);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(55, 23);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(407, 22);
			this.txtName.TabIndex = 2;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(55, 51);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(407, 22);
			this.txtPhone.TabIndex = 3;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(55, 79);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(407, 22);
			this.txtEmail.TabIndex = 4;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(3, 26);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(45, 17);
			this.lblName.TabIndex = 5;
			this.lblName.Text = "Name";
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Location = new System.Drawing.Point(3, 56);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(49, 17);
			this.lblPhone.TabIndex = 6;
			this.lblPhone.Text = "Phone";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(3, 84);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(42, 17);
			this.lblEmail.TabIndex = 7;
			this.lblEmail.Text = "Email";
			// 
			// lblNote
			// 
			this.lblNote.AutoSize = true;
			this.lblNote.Location = new System.Drawing.Point(3, 117);
			this.lblNote.Name = "lblNote";
			this.lblNote.Size = new System.Drawing.Size(38, 17);
			this.lblNote.TabIndex = 8;
			this.lblNote.Text = "Note";
			// 
			// txtNote
			// 
			this.txtNote.Location = new System.Drawing.Point(55, 114);
			this.txtNote.Multiline = true;
			this.txtNote.Name = "txtNote";
			this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNote.Size = new System.Drawing.Size(407, 87);
			this.txtNote.TabIndex = 9;
			// 
			// EditPerson
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.txtNote);
			this.Controls.Add(this.lblNote);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblPhone);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Name = "EditPerson";
			this.Size = new System.Drawing.Size(487, 248);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblNote;
		private System.Windows.Forms.TextBox txtNote;
	}
}
