using System;
using System.Linq;
using System.Net;
using RingCentral.Net.Retry;

namespace RingCentral.Net.RateLimit
{
    public class RateLimitExtension : RetryExtension
    {
        public RateLimitExtension(RateLimitOptions options = null) : base(DefaultOptions(options))
        {
        }

        private static RetryOptions DefaultOptions(RateLimitOptions options)
        {
            options = options ?? RateLimitOptions.DefaultInstance;
            return new RetryOptions
            {
                shouldRetry = (restException, retriesAttempted) =>
                    restException.httpResponseMessage.StatusCode == (HttpStatusCode)429 &&
                    retriesAttempted < options.maxRetries,
                retryInterval = (restException, retriesAttempted) =>
                {
                    string rateLimitWindowHeader = default;
                    if (restException.httpResponseMessage.Headers
                        .TryGetValues("x-rate-limit-window", out var values))
                        rateLimitWindowHeader = values.FirstOrDefault();
                    var rateLimitWindow = rateLimitWindowHeader == default
                        ? options.rateLimitWindow
                        : int.Parse(rateLimitWindowHeader);
                    return (int)(rateLimitWindow * 1000 *
                                 Math.Pow(2, retriesAttempted)); // exponential back off
                }
            };
        }
    }
}