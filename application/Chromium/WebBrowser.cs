using System;
using System.Collections.Generic;
using System.IO;
using CefSharp;
using CefSharp.WinForms;


namespace APIMagic.Chromium {
	public class WebBrowser {

		//_____________________________________________________________________
		public static string	CachePath;
		public static string	UserDataPath;
		
		//_____________________________________________________________________
		public static void Initialize() {

			CefSettings settings;

			CachePath		= Path.Combine(Shared.ApplicationPath, "temp\\cache");
			UserDataPath	= Path.Combine(Shared.ApplicationPath, "temp\\userdata");

			settings = new CefSettings() {
				CachePath = CachePath,
				IgnoreCertificateErrors = true,
				UserDataPath = UserDataPath,
				RemoteDebuggingPort = 9999,
				CommandLineArgsDisabled = false
			};

			settings.CefCommandLineArgs.Add("disable-web-security", "true");
			settings.CefCommandLineArgs.Add("disable-features", "OutOfBlinkCors");

			Cef.EnableHighDPISupport();
			Cef.Initialize(
				settings,
				performDependencyCheck: true,
				browserProcessHandler: null
			);
		}

		//_____________________________________________________________________
		public static ChromiumWebBrowser CreateChromiumWebBrowser(System.Windows.Forms.Control.ControlCollection container, Action onFinished) {
			ChromiumWebBrowser chromiumWebBrowser = new ChromiumWebBrowser(new CefSharp.Web.HtmlString(Properties.Resources.NoURLHTML)) {
				Dock = System.Windows.Forms.DockStyle.Fill,
				RequestHandler = new WebBrowserRequestHandler(),
				Tag = onFinished
			};
			chromiumWebBrowser.LoadingStateChanged += ChromiumWebBrowser_LoadingStateChanged;
			container.Add(chromiumWebBrowser);
			return chromiumWebBrowser;
		}

		//_____________________________________________________________________
		private static void ChromiumWebBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e) {
			if(!e.IsLoading) {
				((ChromiumWebBrowser) sender).LoadingStateChanged -= ChromiumWebBrowser_LoadingStateChanged;
				Shared.MainForm.Invoke((Action)((ChromiumWebBrowser) sender).Tag);
			}
		}

		//_____________________________________________________________________
		public static void SetCORS() {

			int		currentPosition = 0;
			int		count = 0;
			string	cleanURL = Shared.CurrentProject.Settings.URL;

			while((currentPosition = Shared.CurrentProject.Settings.URL.IndexOf('/', currentPosition)) != -1) {
				count++;
				if(count == 3) {
					cleanURL = Shared.CurrentProject.Settings.URL.Substring(0, currentPosition);
					break;
				}
				currentPosition++;
			}
			_ = CefSharp.Cef.ClearCrossOriginWhitelist();
			_ = CefSharp.Cef.AddCrossOriginWhitelistEntry(cleanURL, "http", string.Empty, true);
			_ = CefSharp.Cef.AddCrossOriginWhitelistEntry(cleanURL, "https", string.Empty, true);
		}

		//_____________________________________________________________________
		public static void Shutdown() {
			Cef.Shutdown();
		}

	}
}
