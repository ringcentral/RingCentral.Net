using System;
using System.Net.Http;

namespace RingCentral
{
    public class HttpCallEventArgs : EventArgs
    {
        public HttpResponseMessage httpResponseMessage;
        public HttpRequestMessage httpRequestMessage;

        public HttpCallEventArgs(HttpResponseMessage httpResponseMessage, HttpRequestMessage httpRequestMessage)
        {
            this.httpResponseMessage = httpResponseMessage;
            this.httpRequestMessage = httpRequestMessage;
        }

        public override string ToString()
        {
            return Utils.FormatHttpMessage(httpResponseMessage, httpRequestMessage);
        }
    }

    public partial class RestClient
    {
        public event EventHandler<HttpCallEventArgs> AfterHttpCall;
    }
}