using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIMagic.Chromium {
	public class WebBrowserByteArrayResourceHandler : ByteArrayResourceHandler {
		public WebBrowserByteArrayResourceHandler(string mimeType, byte[] data) : base(mimeType, data) {
		}

		public void GetResponseHeaders(IResponse response, out long responseLength, out string redirectUrl) {
			responseLength = 0;
			redirectUrl = null;
		}
	}
}
