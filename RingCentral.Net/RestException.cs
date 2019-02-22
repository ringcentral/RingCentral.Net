using System;
using System.Net.Http;

namespace RingCentral
{
    public class RestException : Exception
    {
        public readonly HttpResponseMessage HttpResponseMessage;

        public RestException(HttpResponseMessage httpResponseMessage, HttpRequestMessage httpRequestMessage)
            : base(ExceptionMessage(httpResponseMessage, httpRequestMessage))
        {
            HttpResponseMessage = httpResponseMessage;
        }

        private static string ExceptionMessage(HttpResponseMessage httpResponseMessage,
            HttpRequestMessage httpRequestMessage)
        {
            var message = $"Response:\n{httpResponseMessage.ToString()}";
            if (httpResponseMessage.Content != null)
            {
                message += $"\nContent: {httpResponseMessage.Content.ReadAsStringAsync().Result}";
            }

            message += $"\n\nRequest:\n{httpRequestMessage.ToString()}";
            if (httpRequestMessage.Content != null)
            {
                message += $"\nContent: {httpRequestMessage.Content.ReadAsStringAsync().Result}";
            }

            return message;
        }
    }
}