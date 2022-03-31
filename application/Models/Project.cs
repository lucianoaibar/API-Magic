using System;
using System.Collections.Generic;


namespace APIMagic.Models {
	public class Project {

		public string						Path;
		public string						Name;
		public ProjectSettings				Settings;
		public List<ProjectRouteWithType>	Routes;

		public Project() {
			this.Routes = new List<ProjectRouteWithType>();
		}
	}
}
