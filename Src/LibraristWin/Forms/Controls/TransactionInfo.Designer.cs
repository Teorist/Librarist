namespace Librarist.Win.Forms.Controls
{
	partial class TransactionInfo
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
			this.cbxPersons = new System.Windows.Forms.ComboBox();
			this.lblPerson = new System.Windows.Forms.Label();
			this.lblNote = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// txtNote
			// 
			this.txtNote.Location = new System.Drawing.Point(65, 74);
			this.txtNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNote.Multiline = true;
			this.txtNote.Name = "txtNote";
			this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNote.Size = new System.Drawing.Size(393, 114);
			this.txtNote.TabIndex = 23;
			this.txtNote.Leave += new System.EventHandler(this.txtNote_Leave);
			// 
			// cbxPersons
			// 
			this.cbxPersons.FormattingEnabled = true;
			this.cbxPersons.Location = new System.Drawing.Point(66, 8);
			this.cbxPersons.Margin = new System.Windows.Forms.Padding(4);
			this.cbxPersons.Name = "cbxPersons";
			this.cbxPersons.Size = new System.Drawing.Size(392, 24);
			this.cbxPersons.TabIndex = 22;
			this.cbxPersons.SelectionChangeCommitted += new System.EventHandler(this.cbxPersons_SelectionChangeCommitted);
			// 
			// lblPerson
			// 
			this.lblPerson.AutoSize = true;
			this.lblPerson.Location = new System.Drawing.Point(8, 11);
			this.lblPerson.Name = "lblPerson";
			this.lblPerson.Size = new System.Drawing.Size(53, 17);
			this.lblPerson.TabIndex = 25;
			this.lblPerson.Text = "Person";
			// 
			// lblNote
			// 
			this.lblNote.AutoSize = true;
			this.lblNote.Location = new System.Drawing.Point(7, 74);
			this.lblNote.Name = "lblNote";
			this.lblNote.Size = new System.Drawing.Size(38, 17);
			this.lblNote.TabIndex = 24;
			this.lblNote.Text = "Note";
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(8, 41);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(38, 17);
			this.lblDate.TabIndex = 27;
			this.lblDate.Text = "Date";
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(66, 41);
			this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(265, 22);
			this.dtpDate.TabIndex = 26;
			this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
			// 
			// TransactionInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtNote);
			this.Controls.Add(this.cbxPersons);
			this.Controls.Add(this.lblPerson);
			this.Controls.Add(this.lblNote);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.dtpDate);
			this.Name = "TransactionInfo";
			this.Size = new System.Drawing.Size(465, 203);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNote;
		private System.Windows.Forms.ComboBox cbxPersons;
		private System.Windows.Forms.Label lblPerson;
		private System.Windows.Forms.Label lblNote;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.DateTimePicker dtpDate;
	}
}
