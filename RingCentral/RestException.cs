using System;
using System.Net.Http;

namespace RingCentral
{
    public class RestException : Exception
    {
        public HttpResponseMessage HttpResponseMessage;

        public RestException(HttpResponseMessage httpResponseMessage)
            : base(ExceptionMessage(httpResponseMessage))
        {
            this.HttpResponseMessage = httpResponseMessage;
        }

        private static string ExceptionMessage(HttpResponseMessage httpResponseMessage)
        {
            return httpResponseMessage.Content.ReadAsStringAsync().Result;
        }
    }
}