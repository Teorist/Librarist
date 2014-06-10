namespace Librarist.Win.Forms
{
	partial class FormDebug
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
			this.btnClose = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.textOutput = new System.Windows.Forms.TextBox();
			this.saveFileDebugOutput = new System.Windows.Forms.SaveFileDialog();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(685, 278);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(117, 23);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(545, 278);
			this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(123, 23);
			this.btnClear.TabIndex = 3;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// textOutput
			// 
			this.textOutput.Location = new System.Drawing.Point(13, 12);
			this.textOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textOutput.Multiline = true;
			this.textOutput.Name = "textOutput";
			this.textOutput.ReadOnly = true;
			this.textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textOutput.Size = new System.Drawing.Size(789, 260);
			this.textOutput.TabIndex = 1;
			// 
			// saveFileDebugOutput
			// 
			this.saveFileDebugOutput.DefaultExt = "txt";
			this.saveFileDebugOutput.FileName = "TeoLibDebug.txt";
			this.saveFileDebugOutput.InitialDirectory = ".\\";
			this.saveFileDebugOutput.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDebugOutput_FileOk);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(403, 276);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(123, 28);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save...";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// FormDebug
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(813, 313);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.textOutput);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnClose);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FormDebug";
			this.Text = "Debug Console";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDebug_FormClosed);
			this.Load += new System.EventHandler(this.FormDebug_Load);
			this.Shown += new System.EventHandler(this.FormDebug_Shown);
			this.VisibleChanged += new System.EventHandler(this.FormDebug_VisibleChanged);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.SaveFileDialog saveFileDebugOutput;
        private System.Windows.Forms.Button btnSave;
	}
}