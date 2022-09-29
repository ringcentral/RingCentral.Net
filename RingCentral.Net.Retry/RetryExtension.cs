using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace RingCentral.Net.Retry
{
    // Ref: https://stackoverflow.com/a/46026230/862862
    public static class Utils
    {
        public static async Task<HttpRequestMessage> CloneAsync(this HttpRequestMessage request)
        {
            var clone = new HttpRequestMessage(request.Method, request.RequestUri)
            {
                Content = await request.Content.CloneAsync().ConfigureAwait(false),
                Version = request.Version
            };
            foreach (var prop in request.Properties) clone.Properties.Add(prop);
            foreach (var header in request.Headers) clone.Headers.TryAddWithoutValidation(header.Key, header.Value);

            return clone;
        }

        public static async Task<HttpContent> CloneAsync(this HttpContent content)
        {
            if (content == null) return null;

            var ms = new MemoryStream();
            await content.CopyToAsync(ms).ConfigureAwait(false);
            ms.Position = 0;

            var clone = new StreamContent(ms);
            foreach (var header in content.Headers) clone.Headers.Add(header.Key, header.Value);
            return clone;
        }
    }

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
                    return await extensibleRequest(await httpRequestMessage.CloneAsync(), restRequestConfig);
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