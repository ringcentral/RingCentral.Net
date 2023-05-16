namespace RingCentral
{
    public class LicenseAssignmentEntry
    {
        /// <summary>
        ///     SKU of a license
        ///     Required
        /// </summary>
        public string skuId { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? extensionId { get; set; }
    }
}