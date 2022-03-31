using System;
using System.Collections.Generic;
using APIMagic.Models;
using System.IO;


namespace APIMagic {
	internal static class Shared {

		public static string			ApplicationPath;
		public static string			ProjectsPath;
		public static Project			CurrentProject;
		public static Views.FormMain	MainForm;

		static Shared() {
			ApplicationPath		= AppDomain.CurrentDomain.BaseDirectory;
			ProjectsPath		= Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "API Magic");
			CurrentProject		= null;
			MainForm			= null;
		}

	}
}
