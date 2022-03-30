using System;
using System.Collections.Generic;
using System.Linq;


namespace APIMagic.Constants {
	public static class RestSharpHttpMethod {

		//_____________________________________________________________________
		private readonly static Dictionary<string, RestSharp.Method> _method;

		//_____________________________________________________________________
		static RestSharpHttpMethod() {
			_method = new Dictionary<string, RestSharp.Method>(StringComparer.OrdinalIgnoreCase) {
				{ "GET",		RestSharp.Method.Get },
				{ "POST",		RestSharp.Method.Post },
				{ "PUT",		RestSharp.Method.Put },
				{ "DELETE",		RestSharp.Method.Delete },
				{ "HEAD",		RestSharp.Method.Head },
				{ "OPTIONS",	RestSharp.Method.Options },
				{ "PATCH",		RestSharp.Method.Patch },
				{ "MERGE",		RestSharp.Method.Merge },
				{ "COPY",		RestSharp.Method.Copy },
				{ "SEARCH",		RestSharp.Method.Search }
			};
		}

		//_____________________________________________________________________
		public static RestSharp.Method FromString(string methodName) {
			var result = _method.First(x => x.Key==methodName).Value;
			return result;
		}

	}
}
