namespace RingCentral
{
    // Returned if WebHook subscription is blacklisted
    public class NotificationBlacklistedData
    {
        /// <summary>
        /// Time of adding subscrition to a black list in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z*
        /// </summary>
        public string blacklistedAt;

        /// <summary>
        /// Reason for adding subscrition to a black list
        /// </summary>
        public string reason;
    }
}