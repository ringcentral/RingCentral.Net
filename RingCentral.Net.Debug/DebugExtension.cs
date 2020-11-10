namespace RingCentral.Net.Debug
{
    public class DebugExtension : SdkExtension
    {
        private readonly DebugOptions _options;

        public DebugExtension(DebugOptions debugOptions = null)
        {
            _options = debugOptions ?? DebugOptions.DefaultInstance;
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
                    _options.loggingAction(debugMessage);
                }

                return httpResponseMessage;
            };
        }
    }
}