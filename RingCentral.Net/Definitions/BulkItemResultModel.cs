namespace RingCentral
{
    public class BulkItemResultModel
    {
        /// <summary>
        ///     Indicates if this item was processed successfully during bulk operation.
        ///     If false, `bulkItemErrors` attribute contains the list of errors
        ///     Required
        ///     Example: true
        /// </summary>
        public bool? bulkItemSuccessful { get; set; }

        /// <summary>
        ///     The list of errors occurred during processing of particular item of bulk operation.
        ///     Returned only if `bulkItemSuccessful` is false
        /// </summary>
        public ApiError[] bulkItemErrors { get; set; }
    }
}