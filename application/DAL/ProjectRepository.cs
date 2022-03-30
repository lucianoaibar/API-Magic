using APIMagic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Json.Net;
using APIMagic.Constants;


namespace APIMagic.DAL {
	internal static class ProjectRepository {

		//_____________________________________________________________________
		public async static Task<IEnumerable<Project>> GetAll() {

			string[]			directories;
			ProjectSettings		projectSettings;
			Project				project;
			List<Project>		projects;

			projects = new List<Project>();

			await Task.Run(() => {
				CreateProjectsDirectory();
			
				directories = Directory.GetDirectories(Shared.ProjectsPath);

				foreach(string directory in directories) {

					try {
						projectSettings = JsonNet.Deserialize<ProjectSettings>(
							File.ReadAllText(Path.Combine(directory, "settings.json"))
						);
					} catch {
						continue;
					}

					project = new Project() {
						Path = directory,
						Name = Path.GetFileName(directory),
						Settings = projectSettings
					};

					AddRoutes<ProjectRouteFromText>(project, directory, ProjectRouteType.Text, "routes_text.json");
					AddRoutes<ProjectRouteFromFile>(project, directory, ProjectRouteType.File, "routes_files.json");
					AddRoutes<ProjectRouteFromURL>(project, directory, ProjectRouteType.URL, "routes_url.json");

					projects.Add(project);
				}
			});
			
			return projects;
		}

		//_____________________________________________________________________
		private static void AddRoutes<T>(Project project, string directory, ProjectRouteType projectRouteType, string jsonFile) {
			try {
				IEnumerable<IProjectRoute> routes = (IEnumerable<IProjectRoute>) JsonNet.Deserialize<IEnumerable<T>>(
					File.ReadAllText(
						Path.Combine(directory, jsonFile)
					)
				);
				foreach(IProjectRoute route in routes) {
					route.RouteType = projectRouteType;
				}
				project.Routes.AddRange(routes);
			} catch { }
		}

		//_____________________________________________________________________
		public static ProjectSettings Get(long projectId) {
			throw new NotImplementedException();
		}

		public static void Create(ProjectSettings project) {
			throw new NotImplementedException();
		}

		public static void Update(ProjectSettings project) {
			throw new NotImplementedException();
		}

		public static void Delete(long projectId) {
			throw new NotImplementedException();
		}

		private static void CreateProjectsDirectory() {
			if(!Directory.Exists(Shared.ProjectsPath)) {
				Directory.CreateDirectory(Shared.ProjectsPath);
			}
		}

		private static List<string> GetAllFileNames() {
			List<string> fileNames = new List<string>();



			return fileNames;
		}

	}
}
