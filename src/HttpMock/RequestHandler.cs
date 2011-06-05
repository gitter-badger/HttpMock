﻿using System.Net;
using Kayak;

namespace HttpMock
{
	public class RequestHandler
	{
		private readonly WebAppResponseBuilder _webResponseBuilder = new WebAppResponseBuilder();
		private HttpStatusCode _responseStatusCode;

		public RequestHandler(string path, RequestProcessor requestProcessor) {
			Path = path;
			RequestProcessor = requestProcessor;
		}

		public string Path { get; set; }
		public RequestProcessor RequestProcessor { get; set; }
		public KayakScheduler Scheduler { get; set; }

		public HttpStatusCode ResponseStatusCode {
			get { return _responseStatusCode; }
		}

		public WebAppResponseBuilder ResponseBuilder {
			get { return _webResponseBuilder; }
		}


		public void SetStatusCode(HttpStatusCode httpStatusCode) {
			_responseStatusCode = httpStatusCode;
		}
	}
}