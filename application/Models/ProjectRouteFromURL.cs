using System;
using System.Collections.Generic;
using APIMagic.Constants;
using System.Linq;


namespace APIMagic.Models {
	public class ProjectRouteFromURL : IProjectRoute {
		public string						Method			{ get; set; }
		public ProjectRouteAddressType		AddressType		{ get; set; }
		public string						Address			{ get; set; }
		public string						Output			{ get; set; }
	}
}
