using System;

namespace RingCentral.Net.Debug
{
    public class DebugExtension : SdkExtension
    {
        public override void Install(RestClient rc)
        {
            var extensibleRequest = rc.extensibleRequest;
            rc.extensibleRequest = async (httpRequestMessage, retriedTimes, cancellationToken) =>
            {
                var result = await extensibleRequest(httpRequestMessage, retriedTimes, cancellationToken);
                var debugMessage = Utils.FormatHttpMessage(result, httpRequestMessage);
                Console.WriteLine(debugMessage);
                return result;
            };
        }
    }
}