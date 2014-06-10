using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Librarist.Win.Forms
{
	public partial class FormDebug : Form
	{
		public FormDebug()
		{
			InitializeComponent();
		}

		public void OutputClear()
		{
			textOutput.Text = string.Empty;
		}

		public void OutputWrite(string text)
		{
			textOutput.Text += text;
			System.Diagnostics.Trace.Write(text);
		}

		public void OutputWriteLine(string text)
		{
			OutputWrite(text + "\r\n");
		}

		private void DebugWriteLine(string text)
		{
			OutputWriteLine("FormDebug: " + text);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Hide();
			DebugWriteLine("Debug window closed.");
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			OutputClear();
		}

        private void saveFileDebugOutput_FileOk(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(saveFileDebugOutput.FileName))
                File.WriteAllText(saveFileDebugOutput.FileName, textOutput.Text);

			DebugWriteLine(string.Format("Debug file saved: {0}.", saveFileDebugOutput.FileName));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDebugOutput.ShowDialog();
        }

		private void FormDebug_Load(object sender, EventArgs e)
		{
			DebugWriteLine("Debug window loaded.");
		}

		private void FormDebug_FormClosed(object sender, FormClosedEventArgs e)
		{
			DebugWriteLine("Debug window closed.");
		}

		private void FormDebug_Shown(object sender, EventArgs e)
		{
			DebugWriteLine("Debug window shown.");
		}

		private void FormDebug_VisibleChanged(object sender, EventArgs e)
		{
			DebugWriteLine(string.Format("Debug window {0}.", this.Visible ? "visible" : "hidden"));
		}
	}
}
