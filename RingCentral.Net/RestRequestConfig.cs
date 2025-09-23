using System.Collections.Generic;
using System.Threading;

namespace RingCentral
{
    public class RestRequestConfig
    {
        public static readonly RestRequestConfig DefaultInstance = new RestRequestConfig();

        // So that you can cancel an HTTP request
        public CancellationToken cancellationToken = CancellationToken.None;

        public Dictionary<string, string> customHeaders = new Dictionary<string, string>();

        // for Retry extension
        public int retriesAttempted = 0;
    }
}