namespace RingCentral
{
    public class AddForwardedNumberResponseItem
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

        /// <summary>
        ///     Forwarded phone number ID. Returned only for successfully added numbers
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Phone number in e.164 format (with '+' prefix)
        ///     Required
        ///     Example: +16501234567
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// </summary>
        public BulkOperationExtensionReference extension { get; set; }
    }
}