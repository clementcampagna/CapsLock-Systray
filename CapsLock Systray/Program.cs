using System;
using System.Windows.Forms;

namespace CapsLock_Systray
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new Frm_CapsLockSystray() );
		}
	}
}
