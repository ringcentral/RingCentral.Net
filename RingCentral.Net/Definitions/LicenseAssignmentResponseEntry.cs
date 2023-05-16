namespace RingCentral
{
    public class LicenseAssignmentResponseEntry
    {
        /// <summary>
        ///     Indicates if an assignment operation was successful for this item
        ///     Required
        /// </summary>
        public bool? bulkItemSuccess { get; set; }

        /// <summary>
        ///     SKU of a license
        ///     Required
        /// </summary>
        public string skuId { get; set; }

        /// <summary>
        ///     Format: int64
        /// </summary>
        public long? extensionId { get; set; }

        /// <summary>
        ///     The list of errors occurred during processing of particular item of bulk operation.
        ///     Returned only if `bulkItemSuccess` is false
        /// </summary>
        public ApiError[] bulkItemErrors { get; set; }
    }
}