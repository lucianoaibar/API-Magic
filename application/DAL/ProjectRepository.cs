using APIMagic.Constants;
using APIMagic.DTO;
using APIMagic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;


namespace APIMagic.DAL {
	internal static class ProjectRepository {

		//_____________________________________________________________________
		private readonly static string						FILE_SETTINGS_JSON;
		private readonly static string						FILE_ROUTES_TEXT_JSON;
		private readonly static string						FILE_ROUTES_FILE_JSON;
		private readonly static string						FILE_ROUTES_URL_JSON;

		private readonly static ProjectSettings				demoProjectSettings;
		private readonly static List<ProjectRouteFromText>	demoProjectRouteFromText;
		private readonly static List<ProjectRouteFromFile>	demoProjectRouteFromFile;
		private readonly static List<ProjectRouteFromURL>	demoProjectRouteFromURL;

		//_____________________________________________________________________
		static ProjectRepository() {
			FILE_SETTINGS_JSON		= "settings.json";
			FILE_ROUTES_TEXT_JSON	= "routes_text.json";
			FILE_ROUTES_FILE_JSON	= "routes_file.json";
			FILE_ROUTES_URL_JSON	= "routes_url.json";

			demoProjectSettings = new ProjectSettings() {
				URL = "https://reqres.in/",
				ApiURL = "https://reqres.in/api/"
			};

			demoProjectRouteFromText = new List<ProjectRouteFromText>() {
				new ProjectRouteFromText() {
					Method		= "GET",
					AddressType	= ProjectRouteAddressType.StartsWith,
					Address		= "users/",
					Output		= "{\"data\":\"API Magic - Example of one User\"}"
				}
			};

			demoProjectRouteFromFile = new List<ProjectRouteFromFile>() {
				new ProjectRouteFromFile() {
					Method		= "GET",
					AddressType	= ProjectRouteAddressType.Equals,
					Address		= "(I have no idea)",
					Output		= "example.json"
				}
			};

			demoProjectRouteFromURL = new List<ProjectRouteFromURL>() {
				new ProjectRouteFromURL() {
					Method		= "GET",
					AddressType	= ProjectRouteAddressType.StartsWith,
					Address		= "users",
					Output		= "https://gorest.co.in/public/v2/users?"
				}
			};
		}

		//_____________________________________________________________________
		private static void CreateProjectsDirectory() {
			if(!Directory.Exists(Shared.ProjectsPath)) {
				try {
					_ = Directory.CreateDirectory(Shared.ProjectsPath);

					string newProjectPath = Path.Combine(Shared.ProjectsPath, "Demo with ReqRes");
					_ = Directory.CreateDirectory(newProjectPath);

					JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions() { WriteIndented = true };

					File.WriteAllBytes(
						Path.Combine(newProjectPath, FILE_SETTINGS_JSON),
						JsonSerializer.SerializeToUtf8Bytes(demoProjectSettings, jsonSerializerOptions)
					);
					File.WriteAllBytes(
						Path.Combine(newProjectPath, FILE_ROUTES_TEXT_JSON),
						JsonSerializer.SerializeToUtf8Bytes(demoProjectRouteFromText, jsonSerializerOptions)
					);
					File.WriteAllBytes(
						Path.Combine(newProjectPath, FILE_ROUTES_FILE_JSON),
						JsonSerializer.SerializeToUtf8Bytes(demoProjectRouteFromFile, jsonSerializerOptions)
					);
					File.WriteAllBytes(
						Path.Combine(newProjectPath, FILE_ROUTES_URL_JSON),
						JsonSerializer.SerializeToUtf8Bytes(demoProjectRouteFromURL, jsonSerializerOptions)
					);
				} catch {}
			}
		}

		//_____________________________________________________________________
		public async static Task<IEnumerable<ProjectDTO>> GetAllAsDTO() {

			List<ProjectDTO>	projects = new List<ProjectDTO>();
			ProjectSettings		projectSettings;

			await Task.Run(() => {
				CreateProjectsDirectory();
				foreach(string path in Directory.GetDirectories(Shared.ProjectsPath)) {
					if((projectSettings = GetProjectSettings(path)) != null) {
						projects.Add(
							new ProjectDTO() {
								Name	= Path.GetFileName(path),
								URL		= projectSettings.URL,
								ApiURL	= projectSettings.ApiURL
							}
						);
					}
				}
			});
			
			return projects;
		}

		//_____________________________________________________________________
		public async static Task<IEnumerable<Project>> GetAll() {

			List<Project>	projects = new List<Project>();
			Project			project;

			await Task.Run(() => {
				CreateProjectsDirectory();
				foreach(string projectPath in Directory.GetDirectories(Shared.ProjectsPath)) {
					if((project = GetProject(projectPath)) != null) projects.Add(project);
				}
			});
			
			return projects;
		}

		//_____________________________________________________________________
		private static ProjectSettings GetProjectSettings(string path) {
			try {
				return JsonSerializer.Deserialize<ProjectSettings>(File.ReadAllText(Path.Combine(path, FILE_SETTINGS_JSON)));
			} catch { }
			return null;
		}

		//_____________________________________________________________________
		private static Project GetProject(string projectPath) {

			Project				project;
			ProjectSettings		projectSettings;

			projectSettings = GetProjectSettings(projectPath);
			if(projectSettings==null) return null;

			project = new Project() {
				Path = projectPath,
				Name = Path.GetFileName(projectPath),
				Settings = projectSettings
			};

			AddRoutes<ProjectRouteFromText>(project, projectPath, ProjectRouteType.Text, FILE_ROUTES_TEXT_JSON);
			AddRoutes<ProjectRouteFromFile>(project, projectPath, ProjectRouteType.File, FILE_ROUTES_FILE_JSON);
			AddRoutes<ProjectRouteFromURL>(project, projectPath, ProjectRouteType.URL, FILE_ROUTES_URL_JSON);

			return project;
		}

		//_____________________________________________________________________
		private static void AddRoutes<T>(Project project, string path, ProjectRouteType projectRouteType, string jsonFile) {
			try {
				project.Routes.AddRange(
					((IEnumerable<IProjectRoute>) JsonSerializer.Deserialize<IEnumerable<T>>(
						File.ReadAllText(
							Path.Combine(path, jsonFile)
						)
					))
					.Select<IProjectRoute, ProjectRouteWithType>(
						x => new ProjectRouteWithType() {
							RouteType	= projectRouteType,
							Method		= x.Method,
							AddressType	= x.AddressType,
							Address		= x.Address,
							Output		= x.Output
						}
					)
				);
			} catch { }
		}

		//_____________________________________________________________________
		public static Project GetProjectByName(string projectName) => GetProject(Path.Combine(Shared.ProjectsPath, projectName));

		//_____________________________________________________________________
		public static void Create(ProjectSettings project) {
			throw new NotImplementedException();
		}

		public static void Update(ProjectSettings project) {
			throw new NotImplementedException();
		}

		public static void Delete(long projectId) {
			throw new NotImplementedException();
		}

	}
}
