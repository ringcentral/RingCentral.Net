using System;
using System.Net.Http;

namespace RingCentral
{
    public class RestException : Exception
    {
        public readonly HttpResponseMessage HttpResponseMessage;

        public RestException(HttpResponseMessage httpResponseMessage)
            : base(ExceptionMessage(httpResponseMessage))
        {
            HttpResponseMessage = httpResponseMessage;
        }

        private static string ExceptionMessage(HttpResponseMessage httpResponseMessage)
        {
            return httpResponseMessage.Content.ReadAsStringAsync().Result;
        }
    }
}