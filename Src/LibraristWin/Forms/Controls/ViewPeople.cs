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

namespace Librarist.Win.Forms.Controls
{
	public partial class ViewPeople : UserControl
	{
		public PeopleService ServicePeople { get; set; }
		public TransactionService ServiceTransactions { get; set; }
		public LibraryService ServiceLibrary { get; set; }
		public People People { get; set; }
		public Transactions Transactions { get; set; }
		public Library Library { get; set; }
		public FormDebug FormDebug { get; set; }
		public ToolStripDropDown CurrentPopup { get; set; }

		public ViewPeople()
		{
			InitializeComponent();
		}

		public void Init()
		{
			DataBindPeople();
		}

		private void DebugWriteLine(string text)
		{
			if (null != FormDebug)
				FormDebug.OutputWriteLine("ViewPeople: " + text);
		}

		private void ClosePopup()
		{
			CurrentPopup.Close();
		}

		#region Event Handlers
		private void ViewPeople_Load(object sender, EventArgs e)
		{
			Init();
		}

		private void btnAddPeople_Click(object sender, EventArgs e)
		{
			DebugWriteLine("Opening the Add People window...");
			this.EditPerson(null);
		}

		private void btnModifyPeople_Click(object sender, EventArgs e)
		{
			DebugWriteLine("Opening the Modify People window...");

			if (0 <= listPeople.SelectedIndex)
				this.EditPerson(new PersonViewModel((PersonViewModel)listPeople.SelectedItem));
		}

		private void btnDeletePeople_Click(object sender, EventArgs e)
		{
			DebugWriteLine("Deleting people.");

			int selectedIndex = listPeople.SelectedIndex;

			if (0 <= selectedIndex)
			{
				PersonViewModel selectedPerson = new PersonViewModel((PersonViewModel)listPeople.SelectedItem);

				if (MessageBox.Show(string.Format("You are about to delete {0}. All this user's transactions will also be deleted.  Are you sure?", selectedPerson.Name), "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					Transactions.LendingTransactions.RemoveAll(x => x.Borrower == selectedPerson.Id);
					Transactions.IsModified = true;
					ServiceLibrary.UpdateLibraryStatus(Library, Transactions);
					People.Persons.Remove(selectedPerson);
					People.IsModified = true;
					//_peopleBindingList.Remove(selectedPerson);
					DataBindPeople();
					DebugWriteLine(string.Format("{0} deleted.", selectedPerson.Name));
				}
				else
				{
					DebugWriteLine(string.Format("{0} NOT deleted.", selectedPerson.Name));
				}
			}
		} 
		#endregion

		#region People
		private void DataBindPeople()
		{
			if (null != People)
			{
				//_peopleBindingList = new BindingList<People>(_people.Persons);
				//listPeople.DataSource = _peopleBindingList;
				//listPeople.DisplayMember = "Name";
				//listPeople.ValueMember = "Id";
				listPeople.BeginUpdate();
				listPeople.DataSource = null;  // http://stackoverflow.com/questions/1609544/listbox-doesnt-show-changes-to-datasource
				listPeople.DataSource = People.Persons;
				listPeople.DisplayMember = "Name";
				listPeople.ValueMember = "Id";
				listPeople.EndUpdate();
			}
		}

		private void DataBindPeople(PersonViewModel person)
		{
			DataBindPeople();

			if (null != person)
			{
				listPeople.SelectedValue = person.Id;
			}
		}

		private void UpdatePerson(BaseModel person)
		{
			if (Error.None == ServicePeople.UpdatePeople(People, (PersonViewModel)person))
			{
				ServicePeople.SortPeople(People);
				DataBindPeople((PersonViewModel)person);
			}

			DebugWriteLine(string.Format("UpdatePerson({0}) - updated.", ((PersonViewModel)person).Id));
		}

		private void EditPerson(PersonViewModel person)
		{
			ToolStripControlHost host = new ToolStripControlHost(new EditPerson(person) { UpdateModel = this.UpdatePerson, ClosePopup = this.ClosePopup });
			host.Margin = Padding.Empty;
			host.Padding = Padding.Empty;
			CurrentPopup.Items.Clear();
			CurrentPopup.Items.Add(host);
			CurrentPopup.Show(new Point(100, 100));
		} 
		#endregion
	}
}
