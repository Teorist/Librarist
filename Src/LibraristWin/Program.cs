using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Librarist.Lib.Utils;
using Librarist.Win.Forms;
using Librarist.Win.Utils;

namespace Librarist.Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
		
		// Mutex to ensure that only one instance of the application is running (to prevent file database conflicts).
		static Mutex mutex = new Mutex(true, "{073A4250-24A6-4163-8345-0D7059D6A182}");

        [STAThread]
		static void Main(string[] args)
        {
			bool debug = false;
			#if DEBUG
				debug = true;
			#endif

			if (null != args && args.Length > 0)
			{
				foreach (string arg in args)
				{
					if ("debug" == arg.Trim().ToLowerInvariant())
						debug = true;
				}
			}

			if (mutex.WaitOne(TimeSpan.Zero, true))
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);

				try
				{
					Application.Run(new FormMain(debug));
				}
				catch (Exception ex)
				{
					System.Diagnostics.Trace.WriteLine(string.Format("Librarist.Lib error - Message: {0}; \t stack: {1} ", ex.Message, ex.StackTrace));
				}

				mutex.ReleaseMutex();
			}
			else
			{
				// send our Win32 message to make the currently running instance
				// jump on top of all the other windows
				NativeMethods.PostMessage((IntPtr)NativeMethods.HWND_BROADCAST, NativeMethods.WM_TEOLIB_SHOWME, IntPtr.Zero, IntPtr.Zero);
			}
        }
    }
}
