namespace RingCentral
{
    public class CostCenterBase
    {
        /// <summary>
        ///     Internal identifier of a cost center
        ///     Format: int64
        ///     Example: 981086004
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Cost Center name
        ///     Example: My Cost Center
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Billing code associated with a cost center
        ///     Example: BC 101
        /// </summary>
        public string billingCode { get; set; }
    }
}