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
	public partial class EditTransaction : BaseEditor
	{
        public Transactions Transactions { get; set; }
        public People People { get; set; }
        public Library Library { get; set; }
		protected TransactionInfo _transInfo = null;

        public EditTransaction(LendingTransaction transaction, Transactions transactions, People people, Library library)
            : base()
		{
			InitializeComponent();
			btnSave.Click += new System.EventHandler(btnSave_Click);
			btnCancel.Click += new System.EventHandler(btnCancel_Click);
            Transactions = transactions;
            People = people;
            Library = library;

			if (null == transaction)
				Model = new LendingTransaction();
			else
				Model = transaction;

			ShowInfo((LendingTransaction)Model);
		}

		protected override void btnSave_Click(object sender, EventArgs e)
		{
			LendingTransaction transaction = (LendingTransaction)Model;

			if (null != _transInfo)
			{
				transaction = _transInfo.GetTransaction();
			}

			base.btnSave_Click(sender, e);
		}

		protected void ShowInfo(LendingTransaction transaction)
		{
			_transInfo = new TransactionInfo(transaction, People);
			panelBorrow.Controls.Add(_transInfo);
		}
	}
}
