using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace RingCentral.Net.Events
{
    public class HttpMessages
    {
        public HttpResponseMessage httpResponseMessage;
        public HttpRequestMessage httpRequestMessage;

        public override string ToString()
        {
            return Utils.FormatHttpMessage(httpResponseMessage, httpRequestMessage);
        }
    }

    public class EventsExtension : SdkExtension
    {
        public event EventHandler<HttpRequestMessage> BeforeRequest;
        public event EventHandler<HttpMessages> RequestSuccess;
        public event EventHandler<RestException> RequestError;

        public override Task Install(RestClient rc)
        {
            var extensibleRequest = rc.extensibleRequest;
            rc.extensibleRequest = async (httpRequestMessage, restRequestConfig) =>
            {
                if (!enabled)
                {
                    return await extensibleRequest(httpRequestMessage, restRequestConfig);
                }

                BeforeRequest?.Invoke(this, httpRequestMessage);
                try
                {
                    var httpResponseMessage = await extensibleRequest(httpRequestMessage, restRequestConfig);
                    RequestSuccess?.Invoke(this, new HttpMessages
                    {
                        httpResponseMessage = httpResponseMessage,
                        httpRequestMessage = httpRequestMessage
                    });
                    return httpResponseMessage;
                }
                catch (RestException re)
                {
                    RequestError?.Invoke(this, re);
                    throw;
                }
            };
            return Task.CompletedTask;
        }
    }
}