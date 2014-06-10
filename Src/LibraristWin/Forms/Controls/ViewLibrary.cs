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
	public partial class ViewLibrary : UserControl
	{
		public PeopleService ServicePeople { get; set; }
		public LibraryService ServiceLibrary { get; set; }
		public TransactionService ServiceTransactions { get; set; }
		public People People { get; set; }
		public Library Library { get; set; }
		public Transactions Transactions { get; set; }
		public FormDebug FormDebug { get; set; }
		public ToolStripDropDown CurrentPopup { get; set; }
		protected int _lastRowIndex = 0;

		public ViewLibrary()
		{
			InitializeComponent();
		}

		public void Init()
		{
			DataBindLibrary();
			SelectItem(_lastRowIndex);
		}

		public override void Refresh()
		{
			SetGridLibraryColors();
			SelectItem(_lastRowIndex);
			SetButtonsState();
		}

		private void DebugWriteLine(string text)
		{
			if (null != FormDebug)
				FormDebug.OutputWriteLine("ViewLibrary: " + text);
		}

		private void ClosePopup()
		{
			CurrentPopup.Close();
		}

		#region Event Handlers
		private void ViewLibrary_Load(object sender, EventArgs e)
		{
			Init();
		}

		private void dataGridLibrary_SelectionChanged(object sender, EventArgs e)
		{
			SetButtonsState();
		}

		private void btnLendItem_Click(object sender, EventArgs e)
		{
			DebugWriteLine("Lending item.");

			ItemViewModel selectedItem = dataGridLibrary.GetSelectedItem();

			if (null != selectedItem)
				this.EditTransaction(selectedItem, false);
		}

		private void btnReturnItem_Click(object sender, EventArgs e)
		{
			DebugWriteLine("Returning item.");

			ItemViewModel selectedItem = dataGridLibrary.GetSelectedItem();

			if (null != selectedItem)
				this.EditTransaction(selectedItem, true);
		}

		private void btnAddItem_Click(object sender, EventArgs e)
		{
			DebugWriteLine("Opening the Add Item window...");
			this.EditItem(null);
		}

		private void btnModifyItem_Click(object sender, EventArgs e)
		{
			DebugWriteLine("Opening the Modify Item window...");

			ItemViewModel selectedItem = dataGridLibrary.GetSelectedItem();

			if (null != selectedItem)
				this.EditItem(selectedItem);
		}

		private void btnDeleteItem_Click(object sender, EventArgs e)
		{
			DebugWriteLine("Deleting item.");

			ItemViewModel selectedItem = dataGridLibrary.GetSelectedItem();

			if (null != selectedItem)
			{
				if (MessageBox.Show(string.Format("You are about to delete {0}. All transactions pertaining to this item will also be deleted.  Are you sure?", selectedItem.Title), "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					LendingTransaction trans = ServiceTransactions.GetItemCurrentTransaction(Transactions, selectedItem.Id);

					if (null != trans)
					{
						trans.ReturnDate = DateTime.Now;
						ServicePeople.UpdatePersonStatus(ServicePeople.GetPeoplePerson(People, trans.Borrower), trans);
					}

					Transactions.LendingTransactions.RemoveAll(x => x.Item == selectedItem.Id);
					Transactions.IsModified = true;
					Library.Items.Remove(selectedItem);
					Library.IsModified = true;
					DataBindLibrary();
					DebugWriteLine(string.Format("{0} deleted.", selectedItem.Title));
				}
				else
				{
					DebugWriteLine(string.Format("{0} NOT deleted.", selectedItem.Title));
				}
			}
		} 
		#endregion

		# region Library
		private void DataBindLibrary()
		{
			if (null != Library)
			{
				dataGridLibrary.MultiSelect = false;
				dataGridLibrary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
				dataGridLibrary.DataSource = typeof(List<ItemViewModel>);
				dataGridLibrary.DataSource = Library.Items;
				dataGridLibrary.Columns["Title"].DisplayIndex = 0;
				dataGridLibrary.Columns["Type"].DisplayIndex = 1;
				dataGridLibrary.Columns["Quality"].DisplayIndex = 2;
				dataGridLibrary.Columns["Note"].DisplayIndex = 3;
				dataGridLibrary.Columns["Id"].DisplayIndex = 4;
				dataGridLibrary.Columns["Status"].DisplayIndex = 5;
				dataGridLibrary.Columns["IsModified"].DisplayIndex = 6;
				dataGridLibrary.Columns["Version"].DisplayIndex = 7;
				dataGridLibrary.Columns["Id"].Visible = false;
				dataGridLibrary.Columns["IsModified"].Visible = false;
				dataGridLibrary.Columns["Version"].Visible = false;
				dataGridLibrary.Columns["Status"].Visible = false;
				dataGridLibrary.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				dataGridLibrary.Columns["Type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
				dataGridLibrary.Columns["Quality"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
				dataGridLibrary.Columns["Note"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				//dataGridLibrary.Columns["Note"].Width = 

				SetGridLibraryColors();

				dataGridLibrary.Update();
			}
		}

		private void SetGridLibraryColors()
		{
			foreach (DataGridViewRow row in dataGridLibrary.Rows)
			{
				switch ((string)row.Cells["Status"].Value)
				{
					default:
						break;
					case "out":
						row.DefaultCellStyle.ForeColor = Color.Blue;
						break;
					case "late":
						row.DefaultCellStyle.ForeColor = Color.Red;
						break;
				}
			}
		}

		private void DeselectAllItems()
		{
			foreach (DataGridViewRow row in dataGridLibrary.Rows)
			{
				row.Selected = false;
			}
		}

		private void SelectItem(string itemId)
		{
			if (!string.IsNullOrEmpty(itemId))
			{
				DeselectAllItems(); // To change selection, all rows must be deselected

				foreach (DataGridViewRow row in dataGridLibrary.Rows)
				{
					if ((string)row.Cells["Id"].Value == itemId)
					{
						row.Selected = true;
						break;
					}
				}
			}
		}

		private void SelectItem(int rowIndex)
		{
			if (rowIndex < dataGridLibrary.Rows.Count)
			{
				DeselectAllItems(); // To change selection, all rows must be deselected
				dataGridLibrary.Rows[rowIndex].Selected = true;
			}
		}

		private void SetButtonsState()
		{
			bool selectedItems = 0 < dataGridLibrary.SelectedCells.Count;
			ItemViewModel selectedItem = null;

			btnDeleteItem.Enabled = btnModifyItem.Enabled = btnLendItem.Enabled = btnReturnItem.Enabled = false;

			// Replace this code with computed status.
			if (selectedItems)
			{
				_lastRowIndex = dataGridLibrary.SelectedCells[0].RowIndex;
				selectedItem = dataGridLibrary.GetSelectedItem();

				if (null != selectedItem) // For better performance, use the Status property of the ItemViewModel.
				{
					btnDeleteItem.Enabled = btnModifyItem.Enabled = true;
					//btnReturnItem.Enabled = "in" == selectedItem.Status;
					//btnLendItem.Enabled = !btnReturnItem.Enabled;

					LendingTransaction trans = ServiceTransactions.GetItemCurrentTransaction(Transactions, selectedItem.Id);

					btnLendItem.Enabled = null == trans;
					btnReturnItem.Enabled = null != trans;
				}
			}
		}

		private void UpdateItem(BaseModel item)
		{
			if (Error.None == ServiceLibrary.UpdateItems(Library, (ItemViewModel)item))
			{
				ServiceLibrary.SortLibrary(Library);
				DataBindLibrary();
				SelectItem(((ItemViewModel)item).Id);
			}

			DebugWriteLine(string.Format("UpdateItem({0}) - updated.", ((ItemViewModel)item).Id));
		}

		private void EditItem(ItemViewModel item)
		{
			ToolStripControlHost host = new ToolStripControlHost(new EditItem(item) { UpdateModel = this.UpdateItem, ClosePopup = this.ClosePopup });
			host.Margin = Padding.Empty;
			host.Padding = Padding.Empty;
			CurrentPopup.Items.Clear();
			CurrentPopup.Items.Add(host);
			CurrentPopup.Show(new Point(100, 100));
		}
		# endregion

		# region Transaction
		private void UpdateTransaction(BaseModel transaction)
		{
			if (Error.None == ServiceTransactions.UpdateLendingTransactions(Transactions, (LendingTransaction)transaction))
			{
				ServiceLibrary.UpdateItemStatus(ServiceLibrary.GetLibraryItem(Library, ((LendingTransaction)transaction).Item), (LendingTransaction)transaction);
				ServicePeople.UpdatePersonStatus(ServicePeople.GetPeoplePerson(People, ((LendingTransaction)transaction).Borrower), (LendingTransaction)transaction);
				DataBindLibrary();
			}

			DebugWriteLine(string.Format("UpdateTransaction({0}) - updated.", ((LendingTransaction)transaction).Id));
		}

		private void EditTransaction(ItemViewModel item, bool returning)
		{
			LendingTransaction transaction = null;
			ToolStripControlHost host = null;

			if (null == item)
				return;

			if (returning)
			{
				transaction = ServiceTransactions.GetItemCurrentTransaction(Transactions, item.Id);
				host = new ToolStripControlHost(new ReturnTransaction(transaction, Transactions, People, Library) { UpdateModel = this.UpdateTransaction, ClosePopup = this.ClosePopup });
			}
			else
			{
				transaction = new LendingTransaction() { Item = item.Id };
				host = new ToolStripControlHost(new EditTransaction(transaction, Transactions, People, Library) { UpdateModel = this.UpdateTransaction, ClosePopup = this.ClosePopup });
			}

			host.Margin = Padding.Empty;
			host.Padding = Padding.Empty;
			CurrentPopup.Items.Clear();
			CurrentPopup.Items.Add(host);
			CurrentPopup.Show(new Point(100, 100));
		}
		# endregion
	}
}
