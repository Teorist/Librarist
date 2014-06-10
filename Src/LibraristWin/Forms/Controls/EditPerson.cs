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
	public partial class EditPerson : BaseEditor
	{
		public EditPerson(PersonViewModel person) : base()
		{
			InitializeComponent();
			btnSave.Click += new System.EventHandler(btnSave_Click);
			btnCancel.Click += new System.EventHandler(btnCancel_Click);

			if (null == person)
				Model = new PersonViewModel();
			else
				Model = person;

			ShowInfo((PersonViewModel)Model);
		}

		protected override void btnSave_Click(object sender, EventArgs e)
		{
			PersonViewModel person = (PersonViewModel)Model;

			person.Name = !string.IsNullOrWhiteSpace(txtName.Text) ? txtName.Text.Trim() : person.Name;
			person.Phone = !string.IsNullOrWhiteSpace(txtPhone.Text) ? txtPhone.Text.Trim() : person.Phone;
			person.Email = !string.IsNullOrWhiteSpace(txtEmail.Text) ? txtEmail.Text.Trim() : person.Email;
			person.Note = !string.IsNullOrWhiteSpace(txtNote.Text) ? txtNote.Text.Trim() : person.Note;

			base.btnSave_Click(sender, e);
		}

		protected void ShowInfo(PersonViewModel person)
		{
			txtName.Text = !string.IsNullOrWhiteSpace(person.Name) ? person.Name : string.Empty;
			txtPhone.Text = !string.IsNullOrWhiteSpace(person.Phone) ? person.Phone : string.Empty;
			txtEmail.Text = !string.IsNullOrWhiteSpace(person.Email) ? person.Email : string.Empty;
			txtNote.Text = !string.IsNullOrWhiteSpace(person.Note) ? person.Note : string.Empty;
		}
	}
}
