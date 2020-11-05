namespace RingCentral.Net.AutoRefresh
{
    public class AutoRefreshOptions
    {
        public static readonly AutoRefreshOptions DefaultInstance = new AutoRefreshOptions();
        public int interval = 1000 * 60 * 30;
    }
}