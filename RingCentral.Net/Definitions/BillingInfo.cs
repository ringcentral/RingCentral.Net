namespace RingCentral
{
    public class BillingInfo
    {
        /// <summary>
        /// Cost per minute, paid and already included in your RingCentral Plan. For example International Calls
        /// </summary>
        public long? costIncluded;

        /// <summary>
        /// Cost per minute, paid and not included in your RingCentral Plan
        /// </summary>
        public long? costPurchased;
    }
}