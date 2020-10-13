using System;
using System.Linq;
using System.Net;
using RingCentral.Net.Retry;

namespace RingCentral.Net.RateLimit
{
    public class RateLimitExtension : RetryExtension
    {
        public RateLimitExtension(int maxRetries = 3, int rateLimitWindow = 60) : base(
            (restException, retriesAttempted) => restException.httpResponseMessage.StatusCode == (HttpStatusCode) 429 &&
                                                 retriesAttempted < maxRetries,
            (restException, retriesAttempted) =>
            {
                var rateLimitWindowHeader = restException.httpResponseMessage.Headers.GetValues("x-rate-limit-window")
                    .FirstOrDefault();
                if (rateLimitWindowHeader != default)
                {
                    rateLimitWindow = int.Parse(rateLimitWindowHeader);
                }

                return (int) (rateLimitWindow * 1000 * Math.Pow(2, retriesAttempted)); // exponential back off
            })
        {
        }
    }
}