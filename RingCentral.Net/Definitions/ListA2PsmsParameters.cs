namespace RingCentral
{
    // Query parameters for operation listA2PSMS
    public class ListA2PSMSParameters
    {
        /// <summary>
        ///     Internal identifier of a message batch used for filtering records
        ///     Example: 1234
        /// </summary>
        public string batchId { get; set; }

        /// <summary>
        ///     Direction of a message to filter the message list result. By default there is no filter applied - both Inbound and Outbound messages are returned
        ///     Example: Outbound
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        ///     Indicates if the response has to be detailed, includes text in the response if detailed
        ///     Default: Simple
        ///     Enum: Simple, Detailed
        /// </summary>
        public string view { get; set; }

        /// <summary>
        ///     Date to filter message list result. Messages with `creationTime` later than or equal to `dateFrom` value are returned. The default value is 1 day before the current datetime
        ///     Example: 2020-11-09T16:07:52.597Z
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        ///     Date to filter message list result. Messages with `creationTime` earlier than `dateTo` value are returned. The default is the current datetime
        ///     Example: 2020-11-25T16:07:52.597Z
        /// </summary>
        public string dateTo { get; set; }

        /// <summary>
        ///     List of phone numbers (specified in 'to' or 'from' fields of a message) to filter the results. Maximum number of phone numbers allowed to be specified as filters is 15
        ///     Example: phoneNumber=15551234455&phoneNumber=15551235577
        /// </summary>
        public string[] phoneNumber { get; set; }

        /// <summary>
        ///     Token of a page to be retrieved
        ///     Example: pgt1
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        ///     Number of messages to be returned per request
        ///     Format: int64
        ///     Example: 1
        ///     Default: 1000
        /// </summary>
        public long? perPage { get; set; }
    }
}