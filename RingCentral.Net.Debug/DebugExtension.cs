namespace RingCentral.Net.Debug
{
    public class DebugExtension : SdkExtension
    {
        private readonly DebugOptions _debugOptions;

        public DebugExtension(DebugOptions debugOptions = null)
        {
            _debugOptions = debugOptions ?? DebugOptions.DefaultInstance;
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
                    _debugOptions.loggingAction(debugMessage);
                }

                return httpResponseMessage;
            };
        }
    }
}