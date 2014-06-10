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
	public partial class ReturnTransaction : BaseEditor
	{
        public Transactions Transactions { get; set; }
        public People People { get; set; }
        public Library Library { get; set; }

        public ReturnTransaction(LendingTransaction transaction, Transactions transactions, People people, Library library)
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

			transaction.ReturnDate = dtpReturnDate.Value;

			base.btnSave_Click(sender, e);
		}

		protected void ShowInfo(LendingTransaction transaction)
		{
			TransactionInfo transInfo = new TransactionInfo(transaction, People);
			panelBorrow.Controls.Add(transInfo);
			panelBorrow.Enabled = false;
			dtpReturnDate.Value = transaction.ReturnDate.HasValue ? transaction.ReturnDate.Value : DateTime.Now ;
		}
	}
}
