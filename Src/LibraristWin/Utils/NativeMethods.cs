﻿using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Librarist.Win.Utils
{
	// this class just wraps some Win32 stuffthat we're going to use
	// http://sanity-free.org/143/csharp_dotnet_single_instance_application.html
	internal class NativeMethods
	{
		public const int HWND_BROADCAST = 0xffff;
		public static readonly int WM_TEOLIB_SHOWME = RegisterWindowMessage("WM_TEOLIB_SHOWME");
		[DllImport("user32")]
		public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);
		[DllImport("user32")]
		public static extern int RegisterWindowMessage(string message);
	}
}
