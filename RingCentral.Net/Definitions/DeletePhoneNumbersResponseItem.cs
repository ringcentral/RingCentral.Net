namespace RingCentral
{
    public class DeletePhoneNumbersResponseItem
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
        ///     Internal unique identifier of a phone number
        ///     Example: 1162820004
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Phone number in e.164 format (with '+' prefix)
        ///     Example: +16501234567
        /// </summary>
        public string phoneNumber { get; set; }
    }
}