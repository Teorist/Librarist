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

namespace Librarist.Win.Utils
{
	public static class ExtensionsInterface
	{
		public static ItemViewModel GetSelectedItem(this DataGridView gridView)
		{
			Error error = Error.None;

			if (null == gridView)
			{
				error = Error.EmptyArgument;
				throw new ArgumentNullException("gridView");
			}

			ItemViewModel selectedItem = null;

			if (0 < gridView.SelectedCells.Count)
			{
				DataGridViewCellCollection cellCollection = gridView.Rows[gridView.SelectedCells[0].RowIndex].Cells;

				selectedItem = new ItemViewModel { Id = (string) cellCollection["Id"].Value,
										  Title = (string) cellCollection["Title"].Value,
										  Type = (string) cellCollection["Type"].Value,
										  Note = (string) cellCollection["Note"].Value,
										  Status = (string)cellCollection["Status"].Value,
										  Quality = (int?) cellCollection["Quality"].Value,
										  IsModified = (bool) cellCollection["IsModified"].Value,
										  Version = (double) cellCollection["Version"].Value
										} ;
			}

			return selectedItem;
		}
	}
}
