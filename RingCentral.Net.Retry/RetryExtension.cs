using System;
using System.Net;
using System.Threading.Tasks;

namespace RingCentral.Net.Retry
{
    public class RetryExtension : SdkExtension
    {
        private readonly Func<RestException, int, bool> _shouldRetry;
        private readonly Func<RestException, int, int> _retryInterval;

        public RetryExtension(Func<RestException, int, bool> shouldRetry = null,
            Func<RestException, int, int> retryInterval = null)
        {
            this._shouldRetry = shouldRetry ?? ((restException, retriesAttempted) => retriesAttempted < 3 &&
                Array.Exists(new[] {429, 503},
                    element => (HttpStatusCode) element == restException.HttpResponseMessage.StatusCode));
            this._retryInterval = retryInterval ?? ((restException, retriesAttempted) =>
                (int) (60 * 1000 * Math.Pow(2, retriesAttempted))); // exponential back off
        }

        public override void Install(RestClient rc)
        {
            var extensibleRequest = rc.extensibleRequest;
            rc.extensibleRequest = async (httpRequestMessage, restRequestConfig) =>
            {
                try
                {
                    return await extensibleRequest(httpRequestMessage, restRequestConfig);
                }
                catch (RestException re)
                {
                    if (this.enabled && this._shouldRetry(re, restRequestConfig.retriesAttempted))
                    {
                        await Task.Delay(this._retryInterval(re, restRequestConfig.retriesAttempted));
                        restRequestConfig.retriesAttempted += 1;
                        return await rc.extensibleRequest(httpRequestMessage, restRequestConfig);
                    }

                    throw;
                }
            };
        }
    }
}