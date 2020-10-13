using System;
using System.Net.Http;

namespace RingCentral
{
    public class RestException : Exception
    {
        public readonly HttpResponseMessage httpResponseMessage;
        public readonly HttpRequestMessage httpRequestMessage;

        public RestException(HttpResponseMessage httpResponseMessage, HttpRequestMessage httpRequestMessage)
            : base(Utils.FormatHttpMessage(httpResponseMessage, httpRequestMessage))
        {
            this.httpResponseMessage = httpResponseMessage;
            this.httpRequestMessage = httpRequestMessage;
        }
    }
}