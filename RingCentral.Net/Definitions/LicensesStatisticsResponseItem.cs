namespace RingCentral
{
    /// <summary>
    ///     Particular license or device sku to be ordered (base)
    /// </summary>
    public class LicensesStatisticsResponseItem
    {
        /// <summary>
        ///     The number of items of this kind
        ///     Required
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 15
        /// </summary>
        public long? quantity { get; set; }

        /// <summary>
        ///     Required
        ///     Example: LC_HD_529
        /// </summary>
        public string skuId { get; set; }

        /// <summary>
        ///     The cost center ID if necessary
        ///     Example: 224149
        /// </summary>
        public string costCenterId { get; set; }

        /// <summary>
        ///     Indicates if this license is assigned
        ///     Required
        /// </summary>
        public bool? assigned { get; set; }
    }
}