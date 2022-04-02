using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APIMagic.DTO;
using APIMagic.DAL;


namespace APIMagic.Views {
	public partial class FormProjectSelect : Form {

		//_____________________________________________________________________
		private string		selectedProjectName;

		//_____________________________________________________________________
		public FormProjectSelect() {
			Shared.MainForm.Enabled = false;
			this.selectedProjectName = null;
			InitializeComponent();
		}

		//_____________________________________________________________________
		private async void FormProjectSelect_Shown(object sender, EventArgs e) {
			await this.LoadAll();
		}

		//_____________________________________________________________________
		private async Task LoadAll() {

			ListViewItem			lvi;
			IEnumerable<ProjectDTO>	projects;

			projects = await ProjectRepository.GetAllAsDTO();

			this.listViewProjects.BeginUpdate();
			this.listViewProjects.Items.Clear();
			foreach(ProjectDTO project in projects) {
				lvi = new ListViewItem(project.Name) {
					Tag = project.Name
				};
				lvi.SubItems.Add(project.URL);
				lvi.SubItems.Add(project.ApiURL);
				this.listViewProjects.Items.Add(lvi);
			}
			this.listViewProjects.EndUpdate();
		}

		//_____________________________________________________________________
		private void buttonOk_Click(object sender, EventArgs e) {
			this.OpenSelectedProject();
		}

		//_____________________________________________________________________
		private void listViewProjects_MouseDoubleClick(object sender, MouseEventArgs e) {
			this.OpenSelectedProject();
		}

		//_____________________________________________________________________
		private void OpenSelectedProject() {
			if(this.listViewProjects.SelectedItems.Count==1) {
				this.selectedProjectName = (string) this.listViewProjects.SelectedItems[0].Tag;
				this.Close();
			}
		}

		//_____________________________________________________________________
		private void buttonCancel_Click(object sender, EventArgs e) {
			this.Close();
		}

		//_____________________________________________________________________
		private void FormProjectSelect_FormClosed(object sender, FormClosedEventArgs e) {
			Shared.MainForm.Enabled = true;
			if(this.selectedProjectName != null) {
				Shared.LoadProject(this.selectedProjectName);
			}
		}

	}
}
