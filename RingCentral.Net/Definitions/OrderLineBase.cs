namespace RingCentral
{
    /// <summary>
    ///     Particular license or device sku to be ordered (base)
    /// </summary>
    public class OrderLineBase
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
    }
}