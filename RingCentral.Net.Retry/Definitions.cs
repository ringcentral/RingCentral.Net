using System;
using System.Net;

namespace RingCentral.Net.Retry
{
    public class RetryOptions
    {
        public static readonly RetryOptions DefaultInstance = new RetryOptions();

        public Func<RestException, int, bool> shouldRetry = ((restException, retriesAttempted) =>
            retriesAttempted < 3 &&
            Array.Exists(new[] {429, 503},
                element => (HttpStatusCode) element == restException.httpResponseMessage.StatusCode));

        public Func<RestException, int, int> retryInterval = ((restException, retriesAttempted) =>
            (int) (60 * 1000 * Math.Pow(2, retriesAttempted)));
    }
}