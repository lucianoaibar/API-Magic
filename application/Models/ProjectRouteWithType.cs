using APIMagic.Constants;


namespace APIMagic.Models {
	public class ProjectRouteWithType : IProjectRoute {
		public ProjectRouteType				RouteType		{ get; set; }
		public string						Method			{ get; set; }
		public ProjectRouteAddressType		AddressType		{ get; set; }
		public string						Address			{ get; set; }
		public string						Output			{ get; set; }
	}
}
