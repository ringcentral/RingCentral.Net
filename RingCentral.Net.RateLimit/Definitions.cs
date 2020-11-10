namespace RingCentral.Net.RateLimit
{
    public class RateLimitOptions
    {
        public static readonly RateLimitOptions DefaultInstance = new RateLimitOptions();
        public int maxRetries = 3;
        public int rateLimitWindow = 60;
    }
}