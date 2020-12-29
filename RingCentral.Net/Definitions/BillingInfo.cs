namespace RingCentral
{
    // Billing information related to the call. Returned for 'Detailed' view only
    public class BillingInfo
    {
        /// <summary>
        /// Cost per minute, paid and already included in your RingCentral Plan. For example International Calls
        /// </summary>
        public decimal? costIncluded;

        /// <summary>
        /// Cost per minute, paid and not included in your RingCentral Plan
        /// </summary>
        public decimal? costPurchased;
    }
}