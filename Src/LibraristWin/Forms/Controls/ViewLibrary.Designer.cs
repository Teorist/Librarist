namespace Librarist.Win.Forms.Controls
{
	partial class ViewLibrary
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
			this.btnLendItem = new System.Windows.Forms.Button();
			this.btnReturnItem = new System.Windows.Forms.Button();
			this.btnAddItem = new System.Windows.Forms.Button();
			this.btnModifyItem = new System.Windows.Forms.Button();
			this.btnDeleteItem = new System.Windows.Forms.Button();
			this.dataGridLibrary = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridLibrary)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLendItem
			// 
			this.btnLendItem.Location = new System.Drawing.Point(443, 359);
			this.btnLendItem.Name = "btnLendItem";
			this.btnLendItem.Size = new System.Drawing.Size(75, 23);
			this.btnLendItem.TabIndex = 8;
			this.btnLendItem.Text = "Lend";
			this.btnLendItem.UseVisualStyleBackColor = true;
			this.btnLendItem.Click += new System.EventHandler(this.btnLendItem_Click);
			// 
			// btnReturnItem
			// 
			this.btnReturnItem.Location = new System.Drawing.Point(524, 359);
			this.btnReturnItem.Name = "btnReturnItem";
			this.btnReturnItem.Size = new System.Drawing.Size(75, 23);
			this.btnReturnItem.TabIndex = 9;
			this.btnReturnItem.Text = "Return";
			this.btnReturnItem.UseVisualStyleBackColor = true;
			this.btnReturnItem.Click += new System.EventHandler(this.btnReturnItem_Click);
			// 
			// btnAddItem
			// 
			this.btnAddItem.Location = new System.Drawing.Point(605, 359);
			this.btnAddItem.Name = "btnAddItem";
			this.btnAddItem.Size = new System.Drawing.Size(75, 23);
			this.btnAddItem.TabIndex = 10;
			this.btnAddItem.Text = "Add...";
			this.btnAddItem.UseVisualStyleBackColor = true;
			this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
			// 
			// btnModifyItem
			// 
			this.btnModifyItem.Location = new System.Drawing.Point(686, 359);
			this.btnModifyItem.Name = "btnModifyItem";
			this.btnModifyItem.Size = new System.Drawing.Size(75, 23);
			this.btnModifyItem.TabIndex = 11;
			this.btnModifyItem.Text = "Modify...";
			this.btnModifyItem.UseVisualStyleBackColor = true;
			this.btnModifyItem.Click += new System.EventHandler(this.btnModifyItem_Click);
			// 
			// btnDeleteItem
			// 
			this.btnDeleteItem.Location = new System.Drawing.Point(767, 359);
			this.btnDeleteItem.Name = "btnDeleteItem";
			this.btnDeleteItem.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteItem.TabIndex = 12;
			this.btnDeleteItem.Text = "Delete";
			this.btnDeleteItem.UseVisualStyleBackColor = true;
			this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
			// 
			// dataGridLibrary
			// 
			this.dataGridLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridLibrary.Location = new System.Drawing.Point(15, 12);
			this.dataGridLibrary.Name = "dataGridLibrary";
			this.dataGridLibrary.RowTemplate.Height = 24;
			this.dataGridLibrary.Size = new System.Drawing.Size(827, 341);
			this.dataGridLibrary.TabIndex = 7;
			this.dataGridLibrary.SelectionChanged += new System.EventHandler(this.dataGridLibrary_SelectionChanged);
			// 
			// ViewLibrary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnLendItem);
			this.Controls.Add(this.btnReturnItem);
			this.Controls.Add(this.btnAddItem);
			this.Controls.Add(this.btnModifyItem);
			this.Controls.Add(this.btnDeleteItem);
			this.Controls.Add(this.dataGridLibrary);
			this.Name = "ViewLibrary";
			this.Size = new System.Drawing.Size(860, 402);
			this.Load += new System.EventHandler(this.ViewLibrary_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridLibrary)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnLendItem;
		private System.Windows.Forms.Button btnReturnItem;
		private System.Windows.Forms.Button btnAddItem;
		private System.Windows.Forms.Button btnModifyItem;
		private System.Windows.Forms.Button btnDeleteItem;
		private System.Windows.Forms.DataGridView dataGridLibrary;
	}
}
