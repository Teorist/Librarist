using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Librarist.Lib.Models;
using Librarist.Lib.Models.Collections;

namespace Librarist.Win.Forms.Controls
{
	public partial class TransactionInfo : UserControl
	{
		private LendingTransaction _transaction = null;
		public People People { get; set; }

		public LendingTransaction GetTransaction()
		{
			if (null != _transaction && string.IsNullOrEmpty(_transaction.Borrower))
			{
				if (-1 < cbxPersons.SelectedIndex)
					_transaction.Borrower = ((PersonViewModel)cbxPersons.Items[cbxPersons.SelectedIndex]).Id;
			}

			return _transaction;
		}

		public TransactionInfo(LendingTransaction transaction, People people) : base()
		{
			InitializeComponent();
			People = people;
			_transaction = transaction;

			if (null == _transaction)
				_transaction = new LendingTransaction();

			ShowInfo(_transaction);
		}

		protected void ShowInfo(LendingTransaction transaction)
		{
			txtNote.Text = !string.IsNullOrWhiteSpace(transaction.Note) ? transaction.Note : string.Empty;
			transaction.LendingDate = transaction.LendingDate.HasValue ? transaction.LendingDate.Value : DateTime.Now;
			dtpDate.Value = transaction.LendingDate.Value;

			if (null != People)
			{
				cbxPersons.DataSource = People.Persons;
				cbxPersons.DisplayMember = "Name";
				cbxPersons.ValueMember = "Id";

				if (!string.IsNullOrWhiteSpace(transaction.Borrower))
					cbxPersons.SelectedValue = transaction.Borrower;
				else
					cbxPersons.SelectedIndex = 0;
			}
		}

		private void cbxPersons_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (-1 < cbxPersons.SelectedIndex)
				_transaction.Borrower = ((PersonViewModel)cbxPersons.Items[cbxPersons.SelectedIndex]).Id;
		}

		private void dtpDate_ValueChanged(object sender, EventArgs e)
		{
			_transaction.LendingDate = dtpDate.Value;
		}

		private void txtNote_Leave(object sender, EventArgs e)
		{
			_transaction.Note = txtNote.Text;
		}

	}
}
