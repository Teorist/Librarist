using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using Librarist.Lib.Services;
using Librarist.Lib.Models;
using Librarist.Lib.Models.Collections;
using Librarist.Lib.Utils;
using Librarist.Win.Utils;
using Librarist.Win.Forms.Controls;

namespace Librarist.Win.Forms
{
    public partial class FormMain : Form
    {
		private bool _debug = false;
		private FormDebug _formDebug = null;
		private PeopleService _servicePeople = null;
		private LibraryService _serviceLibrary = null;
		private TransactionService _serviceTransactions = null;
		private People _people = null;
		private Library _library = null;
		private Transactions _transactions = null;
		private ToolStripDropDown _currentPopup = null;
		//private BindingList<Person> _peopleBindingList = null;  // http://msdn.microsoft.com/en-us/library/ms132679.aspx

		public bool Debug
		{
			get { return _debug; }
			set { _debug = value; }
		}

        public FormMain()
        {
            InitializeComponent();

			BaseService.DebugWriteLine = this.DebugWriteLine;
			_servicePeople = new PeopleService();
			_serviceLibrary = new LibraryService();
			_serviceTransactions = new TransactionService();

			_currentPopup = new ToolStripDropDown();
			_currentPopup.AutoClose = false;         //Set to FALSE
			_currentPopup.Margin = Padding.Empty;
			_currentPopup.Padding = Padding.Empty;
        }

		public FormMain(bool debug) :this()
		{
			Debug = debug;

			if (Debug)
			{
				_formDebug = new FormDebug();
			}
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == NativeMethods.WM_TEOLIB_SHOWME)
			{
				ShowMe();
			}

			base.WndProc(ref m);
		}

		private void ShowMe()
		{
			if (WindowState == FormWindowState.Minimized)
			{
				WindowState = FormWindowState.Normal;
			}

			// get our current "TopMost" value (ours will always be false though)
			bool top = TopMost;
			// make our form jump to the top of everything
			TopMost = true;
			// set it back to whatever it was
			TopMost = top;
		}

		private void DebugWriteLine(string text)
		{
			if (null != _formDebug)
				_formDebug.OutputWriteLine("FormMain: " + text);
		}

		private void ClosePopup()
		{
			_currentPopup.Close();
		}

		private void LoadData()
		{
			DebugWriteLine("LoadData()");
			_people = _servicePeople.GetPeople();
			_library = _serviceLibrary.GetLibrary();
			_transactions = _serviceTransactions.GetTransactions();
			_serviceLibrary.UpdateLibraryStatus(_library, _transactions);
			_servicePeople.UpdatePeopleStatus(_people, _transactions);
		}

		private void SaveData()
		{
			DebugWriteLine("SaveData()");
			_servicePeople.SavePeople(_people);
			_serviceLibrary.SaveLibrary(_library);
			_serviceTransactions.SaveTransactions(_transactions);
		}

        #region Event Handlers
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            DebugWriteLine("Opening the About window...");
            new FormAbout() { DebugForm = _formDebug, Debug = _debug }.ShowDialog();
        }

        private void menuItemSettings_Click(object sender, EventArgs e)
        {
            DebugWriteLine("Opening the Settings window...");
        }

		private void menuItemHistory_Click(object sender, EventArgs e)
		{
			DebugWriteLine("Opening the History window...");
		}

        private void menuItemDebug_Click(object sender, EventArgs e)
        {
            DebugWriteLine("Opening the Debug window...");

            if (null == _formDebug || _formDebug.IsDisposed)
                _formDebug = new FormDebug();

            _formDebug.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
			menuItemHistory.Visible = false;
            menuItemDebug.Visible = Debug;
            menuItemExitSeparator.Visible = Debug;
            DebugWriteLine("Librarist.Lib for Windows started.");
            LoadData();
			tabMain.TabPages["pagePeople"].Controls.Clear();
			tabMain.TabPages["pagePeople"].Controls.Add(new ViewPeople()
			{
				Name = "viewPeople",
				ServicePeople = _servicePeople,
				ServiceTransactions = _serviceTransactions,
				ServiceLibrary = _serviceLibrary,
				People = _people,
				Library = _library,
				Transactions = _transactions,
				FormDebug = _formDebug,
				CurrentPopup = _currentPopup
			});
			tabMain.TabPages["pageLibrary"].Controls.Clear();
			tabMain.TabPages["pageLibrary"].Controls.Add(new ViewLibrary()
			{
				Name = "viewLibrary",
				ServiceLibrary = _serviceLibrary,
				ServicePeople = _servicePeople,
				ServiceTransactions = _serviceTransactions,
				Library = _library,
				People = _people,
				Transactions = _transactions,
				FormDebug = _formDebug,
				CurrentPopup = _currentPopup
			});
        }

		private void FormMain_Shown(object sender, EventArgs e)
		{
			((ViewLibrary)pageLibrary.Controls["viewLibrary"]).Refresh();
		}

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DebugWriteLine("Librarist.Lib for Windows closing.");
            SaveData();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            DebugWriteLine("Librarist.Lib for Windows closed.");
            _serviceLibrary.Dispose();
            _servicePeople.Dispose();
            _serviceTransactions.Dispose();
            Dispose(true);
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
			TabPage tab = (sender as TabControl).TabPages[(sender as TabControl).SelectedIndex];
            DebugWriteLine(string.Format("Showing the {0} tab.", tab.Text));

			switch (tab.Name)
			{
				case "pagePeople":
					((ViewPeople) tab.Controls["viewPeople"]).Init();
					break;
				case "pageLibrary":
					((ViewLibrary) tab.Controls["viewLibrary"]).Init();
					break;
			}

        }
        #endregion
	}
}
