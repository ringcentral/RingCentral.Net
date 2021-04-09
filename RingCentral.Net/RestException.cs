using System;
using System.Net.Http;

namespace RingCentral
{
    public class RestException : Exception
    {
        public readonly HttpRequestMessage httpRequestMessage;
        public readonly HttpResponseMessage httpResponseMessage;

        public RestException(HttpResponseMessage httpResponseMessage, HttpRequestMessage httpRequestMessage)
            : base(Utils.FormatHttpMessage(httpResponseMessage, httpRequestMessage))
        {
            this.httpResponseMessage = httpResponseMessage;
            this.httpRequestMessage = httpRequestMessage;
        }
    }
}