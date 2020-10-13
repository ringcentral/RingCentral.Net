using System.Threading;

namespace RingCentral
{
    public class RestRequestConfig
    {
        public CancellationToken? cancellationToken = null;

        // for Retry extension
        public int retriesAttempted = 0;

        public static readonly RestRequestConfig DefaultInstance = new RestRequestConfig();
    }
}