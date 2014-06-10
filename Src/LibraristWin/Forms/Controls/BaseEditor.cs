using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Librarist.Lib.Models;

namespace Librarist.Win.Forms.Controls
{
	public class BaseEditor : UserControl
	{
		public BaseModel Model { get; set; }
		public UpdateModel UpdateModel { get; set; }
		public ClosePopup ClosePopup { get; set; }

		public BaseEditor()
		{
		}

		protected virtual void btnCancel_Click(object sender, EventArgs e)
		{
			if (null != ClosePopup)
				ClosePopup();
		}

		protected virtual void btnSave_Click(object sender, EventArgs e)
		{
			if (null != Model)
				Model.IsModified = true;

			if (null != UpdateModel)
				UpdateModel(Model);

			if (null != ClosePopup)
				ClosePopup();
		}
	}
}
