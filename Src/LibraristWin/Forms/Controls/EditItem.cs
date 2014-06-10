using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Librarist.Lib.Models;

namespace Librarist.Win.Forms.Controls
{
	public partial class EditItem : BaseEditor
	{
		public EditItem(ItemViewModel item) : base()
		{
			InitializeComponent();
			btnSave.Click += new System.EventHandler(btnSave_Click);
			btnCancel.Click += new System.EventHandler(btnCancel_Click);

			if (null == item)
				Model = new ItemViewModel();
			else
				Model = item;

			ShowInfo((ItemViewModel)Model);
		}

		protected override void btnSave_Click(object sender, EventArgs e)
		{
			ItemViewModel item = (ItemViewModel)Model;

			item.Title = !string.IsNullOrWhiteSpace(txtTitle.Text) ? txtTitle.Text.Trim() : item.Title;
			item.Type = !string.IsNullOrWhiteSpace(txtType.Text) ? txtType.Text.Trim() : item.Type;
			item.Note = !string.IsNullOrWhiteSpace(txtNote.Text) ? txtNote.Text.Trim() : item.Note;

			base.btnSave_Click(sender, e);
		}

		protected void ShowInfo(ItemViewModel item)
		{
			txtTitle.Text = !string.IsNullOrWhiteSpace(item.Title) ? item.Title : string.Empty;
			txtType.Text = !string.IsNullOrWhiteSpace(item.Type) ? item.Type : string.Empty;
			txtNote.Text = !string.IsNullOrWhiteSpace(item.Note) ? item.Note : string.Empty;
		}
	}
}
