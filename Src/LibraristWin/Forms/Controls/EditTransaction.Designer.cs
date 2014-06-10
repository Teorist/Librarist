namespace Librarist.Win.Forms.Controls
{
	partial class EditTransaction
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.panelBorrow = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(385, 241);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 26);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(295, 241);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 26);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "OK";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// panelBorrow
			// 
			this.panelBorrow.Location = new System.Drawing.Point(4, 11);
			this.panelBorrow.Margin = new System.Windows.Forms.Padding(4);
			this.panelBorrow.Name = "panelBorrow";
			this.panelBorrow.Size = new System.Drawing.Size(464, 224);
			this.panelBorrow.TabIndex = 27;
			// 
			// EditTransaction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.panelBorrow);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "EditTransaction";
			this.Size = new System.Drawing.Size(472, 276);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Panel panelBorrow;
	}
}
