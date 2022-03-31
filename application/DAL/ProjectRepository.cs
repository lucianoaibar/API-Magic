using APIMagic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using APIMagic.Constants;


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
					AddressType	= ProjectRouteAddressType.Equals,
					Address		= "users?page=2",
					Output		= "{\"data\":\"API Magic - Users list (page 2) using Text\"}"
				}
			};

			demoProjectRouteFromFile = new List<ProjectRouteFromFile>() {
				new ProjectRouteFromFile() {
					Method		= "GET",
					AddressType	= ProjectRouteAddressType.Equals,
					Address		= "",
					Output		= ""
				}
			};

			demoProjectRouteFromURL = new List<ProjectRouteFromURL>() {
				new ProjectRouteFromURL() {
					Method		= "POST",
					AddressType	= ProjectRouteAddressType.StartsWith,
					Address		= "",
					Output		= ""
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

					string xxx = JsonSerializer.Serialize(demoProjectSettings, jsonSerializerOptions);
					
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
						projectSettings = JsonSerializer.Deserialize<ProjectSettings>(
							File.ReadAllText(Path.Combine(directory, FILE_SETTINGS_JSON))
						);
					} catch {
						continue;
					}

					project = new Project() {
						Path = directory,
						Name = Path.GetFileName(directory),
						Settings = projectSettings
					};

					AddRoutes<ProjectRouteFromText>(project, directory, ProjectRouteType.Text, FILE_ROUTES_TEXT_JSON);
					AddRoutes<ProjectRouteFromFile>(project, directory, ProjectRouteType.File, FILE_ROUTES_FILE_JSON);
					AddRoutes<ProjectRouteFromURL>(project, directory, ProjectRouteType.URL, FILE_ROUTES_URL_JSON);

					projects.Add(project);
				}
			});
			
			return projects;
		}

		//_____________________________________________________________________
		private static void AddRoutes<T>(Project project, string directory, ProjectRouteType projectRouteType, string jsonFile) {
			try {
				project.Routes.AddRange(
					((IEnumerable<IProjectRoute>) JsonSerializer.Deserialize<IEnumerable<T>>(
						File.ReadAllText(
							Path.Combine(directory, jsonFile)
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

	}
}
