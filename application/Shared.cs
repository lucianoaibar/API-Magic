using APIMagic.DAL;
using APIMagic.Models;
using System;
using System.Collections.Generic;
using System.IO;


namespace APIMagic {
	internal static class Shared {

		//_____________________________________________________________________
		public static string			ApplicationPath;
		public static string			ProjectsPath;
		public static Project			CurrentProject;
		public static Views.FormMain	MainForm;

		//_____________________________________________________________________
		static Shared() {
			ApplicationPath		= AppDomain.CurrentDomain.BaseDirectory;
			ProjectsPath		= Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "API Magic");
			CurrentProject		= null;
			MainForm			= null;
		}

		//_____________________________________________________________________
		public static void LoadProject(string projectName) {
			Project project = ProjectRepository.GetProjectByName(projectName);
			if(project != null) {
				CurrentProject = project;
				MainForm.LoadProject();
			}
		}

		//_____________________________________________________________________
		public static void ReloadCurrentProject() => LoadProject(CurrentProject?.Name);
	}
}
