﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APIMagic.Models;
using APIMagic.DAL;


namespace APIMagic.Views {
	public partial class FormProjectSelect : Form {

		//_____________________________________________________________________
		private Project		selectedProject;

		//_____________________________________________________________________
		public FormProjectSelect() {
			Shared.MainForm.Enabled = false;
			this.selectedProject = null;

			InitializeComponent();
		}

		//_____________________________________________________________________
		private async void FormProjectSelect_Shown(object sender, EventArgs e) {
			await this.LoadAll();
		}

		//_____________________________________________________________________
		private async Task LoadAll() {
			ListViewItem	lvi;

			IEnumerable<Project> projects;
			projects = await ProjectRepository.GetAll();

			this.listViewProjects.BeginUpdate();
			this.listViewProjects.Items.Clear();
			foreach(Project project in projects) {
				lvi = new ListViewItem(project.Name) {
					Tag = project
				};
				lvi.SubItems.Add(project.Settings.URL);
				lvi.SubItems.Add(project.Settings.ApiURL);
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
				this.selectedProject = (Project) this.listViewProjects.SelectedItems[0].Tag;
				this.Close();
			}
		}

		//_____________________________________________________________________
		private void buttonCancel_Click(object sender, EventArgs e) {
			this.Close();
		}

		//_____________________________________________________________________
		private void FormProjectSelect_FormClosed(object sender, FormClosedEventArgs e) {
			Shared.CurrentProject = this.selectedProject;
			Shared.MainForm.LoadProject();
			Shared.MainForm.Enabled = true;
		}

	}
}