namespace RingCentral
{
    public class CostCenterItem
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

        /// <summary>
        ///     Required
        /// </summary>
        public TaxLocation taxLocation { get; set; }

        /// <summary>
        ///     Internal identifier of a parent cost center
        ///     Format: int64
        ///     Example: 45878
        /// </summary>
        public long? parentId { get; set; }
    }
}