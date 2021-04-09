namespace RingCentral
{
    public class RecordsCollectionResourceSubscriptionResponse
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public SubscriptionInfo[] records { get; set; }
    }
}