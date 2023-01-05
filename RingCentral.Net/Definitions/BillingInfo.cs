namespace RingCentral
{
    /// <summary>
    ///     Billing information related to the call. Returned for 'Detailed' view only
    /// </summary>
    public class BillingInfo
    {
        /// <summary>
        ///     Cost per minute, paid and already included in your RingCentral service plan.
        ///     For example International Calls
        ///     Format: double
        /// </summary>
        public decimal? costIncluded { get; set; }

        /// <summary>
        ///     Cost per minute, paid and not included in your RingCentral service plan
        ///     Format: double
        /// </summary>
        public decimal? costPurchased { get; set; }
    }
}