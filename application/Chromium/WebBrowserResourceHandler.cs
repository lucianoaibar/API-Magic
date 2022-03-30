using CefSharp;
using CefSharp.Callback;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIMagic.Chromium {
	public class WebBrowserResourceHandler : ResourceHandler {

		public void GetResponseHeaders(IResponse response, out long responseLength, out string redirectUrl) {
			responseLength = -1;
			redirectUrl = null;
		}

		/*public bool Open(IRequest request, out bool handleRequest, ICallback callback) {
			handleRequest = false;
			callback.Continue();
			return false;
		}

		public bool ProcessRequest(IRequest request, ICallback callback) {
			callback.Continue();
			return false;
		}

		public bool Read(Stream dataOut, out int bytesRead, IResourceReadCallback callback) {
			callback.Continue(-1);
			bytesRead = -1;
			return false;
		}

		public bool ReadResponse(Stream dataOut, out int bytesRead, ICallback callback) {
			callback.Continue();
			bytesRead = -1;
			return false;
		}*/

		/*public bool Skip(long bytesToSkip, out long bytesSkipped, IResourceSkipCallback callback) {
			bytesSkipped = -1;
			return false;
		}*/

		//public void Cancel() {}

		//public void Dispose() {}

	}
}
