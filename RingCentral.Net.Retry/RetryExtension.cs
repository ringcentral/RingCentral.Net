using System.Threading.Tasks;

namespace RingCentral.Net.Retry
{
    public class RetryExtension : SdkExtension
    {
        private readonly RetryOptions _options;

        public RetryExtension(RetryOptions options = null)
        {
            _options = options ?? RetryOptions.DefaultInstance;
        }

        public override Task Install(RestClient rc)
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
                    if (enabled && _options.shouldRetry(re, restRequestConfig.retriesAttempted))
                    {
                        await Task.Delay(_options.retryInterval(re, restRequestConfig.retriesAttempted));
                        restRequestConfig.retriesAttempted += 1;
                        return await rc.extensibleRequest(httpRequestMessage, restRequestConfig);
                    }

                    throw;
                }
            };
            return Task.CompletedTask;
        }
    }
}