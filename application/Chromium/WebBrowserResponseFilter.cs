using CefSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace APIMagic.Chromium {
	public class WebBrowserResponseFilter : IResponseFilter {

		//_____________________________________________________________________
		public WebBrowserResponseFilter(bool n) : base() {

		}
		
		//_____________________________________________________________________
		public bool InitFilter() {
			return true;
		}

		//_____________________________________________________________________
		public FilterStatus Filter(Stream dataIn, out long dataInRead, Stream dataOut, out long dataOutWritten) {

			int		dataLength;
			byte[]	data;

			dataInRead = 0;
			dataOutWritten = 0;
			dataLength = (int) (dataIn?.Length ?? 0);
			if(dataLength<1) return FilterStatus.Done;

			try {
				data = new byte[dataLength];
				dataInRead = dataIn.Read(data, 0, dataLength);

				dataOut.Write(data, 0, dataLength);
				dataOutWritten = dataLength;

			} catch {
				return FilterStatus.Error;
			}

			return FilterStatus.NeedMoreData;
		}

		//_____________________________________________________________________
		public void Dispose() {
		}

	}
}
