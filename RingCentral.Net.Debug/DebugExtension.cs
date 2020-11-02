using System;

namespace RingCentral.Net.Debug
{
    public class DebugExtension : SdkExtension
    {
        private readonly Action<string> _loggingAction;
        public DebugExtension(Action<string> loggingAction = null)
        {
            if (loggingAction == null)
            {
                loggingAction = Console.WriteLine;
            }
            this._loggingAction = loggingAction;
        }

        public override void Install(RestClient rc)
        {
            var extensibleRequest = rc.extensibleRequest;
            rc.extensibleRequest = async (httpRequestMessage, restRequestConfig) =>
            {
                var httpResponseMessage = await extensibleRequest(httpRequestMessage, restRequestConfig);
                if (enabled)
                {
                    var debugMessage = Utils.FormatHttpMessage(httpResponseMessage, httpRequestMessage);
                    _loggingAction(debugMessage);
                }

                return httpResponseMessage;
            };
        }
    }
}