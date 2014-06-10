namespace Librarist.Win.Forms
{
    partial class FormMain
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
			this.menuMain = new System.Windows.Forms.MenuStrip();
			this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemDebug = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemExitSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemConfiguration = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemHistory = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.tabMain = new System.Windows.Forms.TabControl();
			this.pageLibrary = new System.Windows.Forms.TabPage();
			this.pagePeople = new System.Windows.Forms.TabPage();
			this.menuMain.SuspendLayout();
			this.tabMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuMain
			// 
			this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemConfiguration,
            this.menuItemHelp});
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.Name = "menuMain";
			this.menuMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuMain.Size = new System.Drawing.Size(900, 28);
			this.menuMain.TabIndex = 1;
			this.menuMain.Text = "Main menu";
			// 
			// menuItemFile
			// 
			this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDebug,
            this.menuItemExitSeparator,
            this.menuItemExit});
			this.menuItemFile.Name = "menuItemFile";
			this.menuItemFile.Size = new System.Drawing.Size(44, 24);
			this.menuItemFile.Text = "File";
			// 
			// menuItemDebug
			// 
			this.menuItemDebug.Name = "menuItemDebug";
			this.menuItemDebug.Size = new System.Drawing.Size(132, 24);
			this.menuItemDebug.Text = "Debug...";
			this.menuItemDebug.Click += new System.EventHandler(this.menuItemDebug_Click);
			// 
			// menuItemExitSeparator
			// 
			this.menuItemExitSeparator.Name = "menuItemExitSeparator";
			this.menuItemExitSeparator.Size = new System.Drawing.Size(129, 6);
			// 
			// menuItemExit
			// 
			this.menuItemExit.Name = "menuItemExit";
			this.menuItemExit.Size = new System.Drawing.Size(132, 24);
			this.menuItemExit.Text = "Exit";
			this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
			// 
			// menuItemConfiguration
			// 
			this.menuItemConfiguration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHistory,
            this.menuItemSettings});
			this.menuItemConfiguration.Name = "menuItemConfiguration";
			this.menuItemConfiguration.Size = new System.Drawing.Size(112, 24);
			this.menuItemConfiguration.Text = "Configuration";
			// 
			// menuItemHistory
			// 
			this.menuItemHistory.Name = "menuItemHistory";
			this.menuItemHistory.Size = new System.Drawing.Size(140, 24);
			this.menuItemHistory.Text = "History...";
			this.menuItemHistory.Click += new System.EventHandler(this.menuItemHistory_Click);
			// 
			// menuItemSettings
			// 
			this.menuItemSettings.Name = "menuItemSettings";
			this.menuItemSettings.Size = new System.Drawing.Size(140, 24);
			this.menuItemSettings.Text = "Settings...";
			this.menuItemSettings.Click += new System.EventHandler(this.menuItemSettings_Click);
			// 
			// menuItemHelp
			// 
			this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAbout});
			this.menuItemHelp.Name = "menuItemHelp";
			this.menuItemHelp.Size = new System.Drawing.Size(53, 24);
			this.menuItemHelp.Text = "Help";
			// 
			// menuItemAbout
			// 
			this.menuItemAbout.Name = "menuItemAbout";
			this.menuItemAbout.Size = new System.Drawing.Size(128, 24);
			this.menuItemAbout.Text = "About...";
			this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
			// 
			// tabMain
			// 
			this.tabMain.Controls.Add(this.pageLibrary);
			this.tabMain.Controls.Add(this.pagePeople);
			this.tabMain.Location = new System.Drawing.Point(13, 32);
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(870, 420);
			this.tabMain.TabIndex = 2;
			this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
			// 
			// pageLibrary
			// 
			this.pageLibrary.Location = new System.Drawing.Point(4, 25);
			this.pageLibrary.Name = "pageLibrary";
			this.pageLibrary.Padding = new System.Windows.Forms.Padding(3);
			this.pageLibrary.Size = new System.Drawing.Size(862, 391);
			this.pageLibrary.TabIndex = 0;
			this.pageLibrary.Text = "Library";
			this.pageLibrary.ToolTipText = "Manage the library contents";
			this.pageLibrary.UseVisualStyleBackColor = true;
			// 
			// pagePeople
			// 
			this.pagePeople.Location = new System.Drawing.Point(4, 25);
			this.pagePeople.Name = "pagePeople";
			this.pagePeople.Padding = new System.Windows.Forms.Padding(3);
			this.pagePeople.Size = new System.Drawing.Size(840, 382);
			this.pagePeople.TabIndex = 1;
			this.pagePeople.Text = "People";
			this.pagePeople.ToolTipText = "Manage people";
			this.pagePeople.UseVisualStyleBackColor = true;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 466);
			this.Controls.Add(this.tabMain);
			this.Controls.Add(this.menuMain);
			this.MainMenuStrip = this.menuMain;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormMain";
			this.Text = "Personal Library Management";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.Shown += new System.EventHandler(this.FormMain_Shown);
			this.menuMain.ResumeLayout(false);
			this.menuMain.PerformLayout();
			this.tabMain.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
		private System.Windows.Forms.ToolStripSeparator menuItemExitSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuItemConfiguration;
        private System.Windows.Forms.ToolStripMenuItem menuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
		private System.Windows.Forms.ToolStripMenuItem menuItemDebug;
		private System.Windows.Forms.TabControl tabMain;
		private System.Windows.Forms.TabPage pageLibrary;
		private System.Windows.Forms.TabPage pagePeople;
		private System.Windows.Forms.ToolStripMenuItem menuItemHistory;
    }
}

