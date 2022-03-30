﻿using System;
using System.Collections.Generic;
using APIMagic.Constants;


namespace APIMagic.Models {
	public interface IProjectRoute {
		ProjectRouteType			RouteType		{ get; set; }
		string						Method			{ get; set; }
		ProjectRouteAddressType		AddressType		{ get; set; }
		string						Address			{ get; set; }
		string						Output			{ get; set; }
	}
}
