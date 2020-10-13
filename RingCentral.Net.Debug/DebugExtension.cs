using System;

namespace RingCentral.Net.Debug
{
    // todo: let user specify logging method (provide default value)
    // rename to Logging extension
    public class DebugExtension : SdkExtension
    {
        public override void Install(RestClient rc)
        {
            var extensibleRequest = rc.extensibleRequest;
            rc.extensibleRequest = async (httpRequestMessage, restRequestConfig) =>
            {
                var httpResponseMessage = await extensibleRequest(httpRequestMessage, restRequestConfig);
                if (enabled)
                {
                    var debugMessage = Utils.FormatHttpMessage(httpResponseMessage, httpRequestMessage);
                    Console.WriteLine(debugMessage);
                }

                return httpResponseMessage;
            };
        }
    }
}