namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listA2PSMS
    /// </summary>
    public class ListA2PSMSParameters
    {
        /// <summary>
        ///     Indicates if the response has to be detailed, includes text in the response if detailed
        ///     Default: Simple
        ///     Enum: Simple, Detailed
        /// </summary>
        public string view { get; set; }

        /// <summary>
        ///     List of phone numbers (specified in 'to' or 'from' fields of a message) to filter the results. Maximum number of
        ///     phone numbers allowed to be specified as filters is 15
        ///     Example: 15551234455,15551235577
        /// </summary>
        public string[] phoneNumber { get; set; }

        /// <summary>
        ///     The page token of the page to be retrieved.
        ///     Example: pgt1
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        ///     The number of messages to be returned per request
        ///     Format: int32
        ///     Example: 1
        ///     Default: 1000
        /// </summary>
        public long? perPage { get; set; }
    }
}