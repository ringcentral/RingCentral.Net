namespace RingCentral
{
    public class SubscriptionListResource
    {
        /// <summary>
        ///     Canonical URI of a resource
        ///     Required
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public SubscriptionInfo[] records { get; set; }
    }
}