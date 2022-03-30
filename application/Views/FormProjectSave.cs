using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APIMagic.Models;


namespace APIMagic.Views {
	public partial class FormProjectSave : Form {

		//_____________________________________________________________________
		private Project		project;

		//_____________________________________________________________________
		internal FormProjectSave() {
			this.project = new Project();
			InitializeComponent();
		}

		//_____________________________________________________________________
		internal FormProjectSave(Project p) {
			this.project = p;
			InitializeComponent();
		}

		//_____________________________________________________________________
		private void buttonOk_Click(object sender, EventArgs e) {
			this.Close();
		}

		//_____________________________________________________________________
		private void buttonCancel_Click(object sender, EventArgs e) {
			this.Close();
		}

	}
}
