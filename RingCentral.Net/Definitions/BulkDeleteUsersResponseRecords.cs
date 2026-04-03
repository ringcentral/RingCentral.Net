namespace RingCentral
{
    public class BulkDeleteUsersResponseRecords
    {
        /// <summary>
        ///     Internal identifier of an extension
        ///     Example: 1162820004
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Indicates if this item was processed successfully during bulk operation.
        ///     If false, `bulkItemErrors` attribute contains the list of errors
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