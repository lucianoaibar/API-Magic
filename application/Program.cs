using System;
using System.Windows.Forms;


namespace APIMagic {
	internal static class Program {

		//_____________________________________________________________________
		public readonly static string	APP_VERSION = "0.902";

		//_____________________________________________________________________
		[STAThread]
		static void Main() {
			Chromium.WebBrowser.Initialize();
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(Shared.MainForm = new Views.FormMain());

			Chromium.WebBrowser.Shutdown();
		}
	}
}
