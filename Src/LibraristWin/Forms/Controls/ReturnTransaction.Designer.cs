namespace Librarist.Win.Forms.Controls
{
	partial class ReturnTransaction
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
			this.panelReturn = new System.Windows.Forms.Panel();
			this.lblReturnText = new System.Windows.Forms.Label();
			this.lblReturnDate = new System.Windows.Forms.Label();
			this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.panelBorrow = new System.Windows.Forms.Panel();
			this.panelReturn.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelReturn
			// 
			this.panelReturn.Controls.Add(this.lblReturnText);
			this.panelReturn.Controls.Add(this.lblReturnDate);
			this.panelReturn.Controls.Add(this.dtpReturnDate);
			this.panelReturn.Location = new System.Drawing.Point(9, 10);
			this.panelReturn.Margin = new System.Windows.Forms.Padding(4);
			this.panelReturn.Name = "panelReturn";
			this.panelReturn.Size = new System.Drawing.Size(464, 85);
			this.panelReturn.TabIndex = 23;
			// 
			// lblReturnText
			// 
			this.lblReturnText.AutoSize = true;
			this.lblReturnText.Location = new System.Drawing.Point(8, 9);
			this.lblReturnText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblReturnText.Name = "lblReturnText";
			this.lblReturnText.Size = new System.Drawing.Size(85, 17);
			this.lblReturnText.TabIndex = 26;
			this.lblReturnText.Text = "Return item.";
			// 
			// lblReturnDate
			// 
			this.lblReturnDate.AutoSize = true;
			this.lblReturnDate.Location = new System.Drawing.Point(8, 50);
			this.lblReturnDate.Name = "lblReturnDate";
			this.lblReturnDate.Size = new System.Drawing.Size(51, 17);
			this.lblReturnDate.TabIndex = 25;
			this.lblReturnDate.Text = "Return";
			// 
			// dtpReturnDate
			// 
			this.dtpReturnDate.Location = new System.Drawing.Point(65, 50);
			this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(4);
			this.dtpReturnDate.Name = "dtpReturnDate";
			this.dtpReturnDate.Size = new System.Drawing.Size(265, 22);
			this.dtpReturnDate.TabIndex = 24;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(398, 318);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 26);
			this.btnCancel.TabIndex = 25;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(308, 318);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 26);
			this.btnSave.TabIndex = 24;
			this.btnSave.Text = "OK";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// panelBorrow
			// 
			this.panelBorrow.Location = new System.Drawing.Point(9, 103);
			this.panelBorrow.Margin = new System.Windows.Forms.Padding(4);
			this.panelBorrow.Name = "panelBorrow";
			this.panelBorrow.Size = new System.Drawing.Size(464, 204);
			this.panelBorrow.TabIndex = 26;
			// 
			// ReturnTransaction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelBorrow);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.panelReturn);
			this.Name = "ReturnTransaction";
			this.Size = new System.Drawing.Size(483, 356);
			this.panelReturn.ResumeLayout(false);
			this.panelReturn.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelReturn;
		private System.Windows.Forms.Label lblReturnText;
		private System.Windows.Forms.Label lblReturnDate;
		private System.Windows.Forms.DateTimePicker dtpReturnDate;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Panel panelBorrow;
	}
}
