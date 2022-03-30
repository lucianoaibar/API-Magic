using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using APIMagic.Models;
using APIMagic.Constants;
using RestSharp;


namespace APIMagic.Chromium {
	public class WebBrowserResourceRequestHandler : IResourceRequestHandler {

		public ICookieAccessFilter GetCookieAccessFilter(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request) => null;
		
		public CefReturnValue OnBeforeResourceLoad(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IRequestCallback callback) {
			return CefReturnValue.Continue;
		}

		public IResourceHandler GetResourceHandler(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request) {

			string	urlRoute = request.Url.Substring(Shared.CurrentProject.Settings.ApiURL.Length);
			bool	matching;

			foreach(IProjectRoute route in Shared.CurrentProject.Routes) {
				if(string.Compare(request.Method, route.Method, StringComparison.OrdinalIgnoreCase) == 0) {
					switch(route.AddressType) {
						case ProjectRouteAddressType.Equals:
							matching = string.Compare(urlRoute, route.Address, StringComparison.OrdinalIgnoreCase) == 0;
							break;

						case ProjectRouteAddressType.StartsWith:
							matching = urlRoute.StartsWith(route.Address);
							break;

						case ProjectRouteAddressType.Contains:
							matching = urlRoute.Contains(route.Address);
							break;

						default:
							matching = false;
							break;
					}
					if(matching) {
						switch(route.RouteType) {
							case ProjectRouteType.Text:
								//ByteArrayResourceHandler x = (ByteArrayResourceHandler) ResourceHandler.FromString(route.Output, Encoding.UTF8, false, "application/json");
								return ResourceHandler.FromString(route.Output, Encoding.UTF8, false, "application/json");

							case ProjectRouteType.File:
								try {
									string fileContent = System.IO.File.ReadAllText( System.IO.Path.Combine(Shared.CurrentProject.Path, "files", route.Output) );
									return ResourceHandler.FromString(fileContent, Encoding.UTF8, false, "application/json");
								} catch { }
								break;

							case ProjectRouteType.URL:
								using(RestClient restClient = new RestClient()) {
									try {
										RestRequest restRequest = new RestRequest(
											(route.Address.EndsWith("?") && route.Output.EndsWith("?")) ? (route.Output + request.Url.Substring(1 + request.Url.IndexOf('?'))) : route.Output,
											RestSharpHttpMethod.FromString(route.Method)
										) {
											Timeout = 10000
										};

										if(request.PostData != null) restRequest.AddBody(request.PostData);

										/*if(request.Headers.Count > 0) {
											ICollection<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
											foreach(KeyValuePair<string, string> header in request.Headers) headers.Add(new KeyValuePair<string, string>(header.Key, header.Value));
											restRequest.AddHeaders(headers);
										}*/

										RestResponse response = restClient.ExecuteAsync(restRequest).Result;
										//Task<RestResponse> responseTask = restClient.ExecuteAsync(restRequest);
										//RestResponse response = responseTask.Result;

										string output = null;
										int sc = (int)response.StatusCode;
										if (sc != 0) {

											output = Encoding.UTF8.GetString(response.RawBytes);

											/*try {
												output = System.Text.Json.JsonSerializer.Deserialize<dynamic>(response.RawBytes);
											} catch {
												output = null;
											}*/

											//remoteResponse.Headers = response.Headers;
										}
										return ResourceHandler.FromString(output, Encoding.UTF8, false, "application/json");
									} catch { }
								}
								break;
						}
					}
				}
			}
			
			return null;
		}

		public bool OnResourceResponse(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IResponse response) => false;
		public IResponseFilter GetResourceResponseFilter(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IResponse response) => null;
		public bool OnProtocolExecution(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request) => false;
		public void OnResourceLoadComplete(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IResponse response, UrlRequestStatus status, long receivedContentLength) {}
		public void OnResourceRedirect(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IResponse response, ref string newUrl) {}
		public void Dispose() {}

	}
}
