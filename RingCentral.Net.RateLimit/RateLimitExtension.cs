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
                    restException.httpResponseMessage.StatusCode == (HttpStatusCode) 429 &&
                    retriesAttempted < options.maxRetries,
                retryInterval = (restException, retriesAttempted) =>
                {
                    var rateLimitWindowHeader = restException.httpResponseMessage.Headers
                        .GetValues("x-rate-limit-window")
                        .FirstOrDefault();
                    if (rateLimitWindowHeader != default) options.rateLimitWindow = int.Parse(rateLimitWindowHeader);

                    return (int) (options.rateLimitWindow * 1000 *
                                  Math.Pow(2, retriesAttempted)); // exponential back off
                }
            };
        }
    }
}