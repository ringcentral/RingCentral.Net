using System;
using System.Net.Http;

namespace RingCentral
{
    public class RestException : Exception
    {
        public readonly HttpResponseMessage HttpResponseMessage;

        public RestException(HttpResponseMessage httpResponseMessage, HttpRequestMessage httpRequestMessage)
            : base(Utils.FormatRequest(httpResponseMessage, httpRequestMessage))
        {
            HttpResponseMessage = httpResponseMessage;
        }
    }
}