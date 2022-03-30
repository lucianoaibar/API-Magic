using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;
using APIMagic.Views;


namespace APIMagic.Views {
	public partial class FormMain : Form {
		
		//_____________________________________________________________________
		public ChromiumWebBrowser			chromiumWebBrowser;
		private readonly Action<string>		delegateOnAddressChange;
		
		//_____________________________________________________________________
		public FormMain() {
			InitializeComponent();
			this.Icon = Properties.Resources.wine_48x48_32x32_16x16;
			this.delegateOnAddressChange = new Action<string>(this.OnAddressChange);
			this.chromiumWebBrowser = Chromium.WebBrowser.CreateChromiumWebBrowser(this.toolStripContainerMain.ContentPanel.Controls, () => {
				FormProjects f = new FormProjects();
				f.Show(this);
			});
			chromiumWebBrowser.AddressChanged += ChromiumWebBrowser_AddressChanged;
		}

		//_____________________________________________________________________
		private void ChromiumWebBrowser_AddressChanged(object sender, CefSharp.AddressChangedEventArgs e) {
			_ = Shared.MainForm.Invoke(this.delegateOnAddressChange, e.Address);
		}

		//_____________________________________________________________________
		private void OnAddressChange(string address) {
			this.toolStripTextBoxURL.Text = address;
		}

		//_____________________________________________________________________
		public void LoadProject() {
			if(Shared.CurrentProject!=null) {
				CefSharp.Cef.ClearCrossOriginWhitelist();
				CefSharp.Cef.AddCrossOriginWhitelistEntry("http://localhost:8080", "https", string.Empty, true);
				this.chromiumWebBrowser.LoadUrl(Shared.CurrentProject.Settings.URL);
			}
		}

		private void Menu_OpenProject_Click(object sender, EventArgs e) {
		}

		private void Menu_Quit_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void Menu_About_Click(object sender, EventArgs e) {
		}

		private void butonOpenDevTools_Click(object sender, EventArgs e) {
			this.chromiumWebBrowser.ShowDevToolsDocked(this.toolStripContainerMain.ContentPanel);
		}

		private void toolStripTextBoxURL_KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode==Keys.Enter) {
				this.chromiumWebBrowser.LoadUrl(this.toolStripTextBoxURL.Text);
			}
		}

		private void buttonHome_Click(object sender, EventArgs e) {
			this.chromiumWebBrowser.LoadUrl(Shared.CurrentProject.Settings.URL);
		}

		private void Menu_ProjectsReload_Click(object sender, EventArgs e) {

		}
	}
}
