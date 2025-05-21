namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation aggregateA2PSMSStatuses
    /// </summary>
    public class AggregateA2PSMSStatusesParameters
    {
        /// <summary>
        ///     Internal identifier of a message batch to filter the response
        ///     Example: 55577
        /// </summary>
        public string batchId { get; set; }

        /// <summary>
        ///     Direction of a message to filter the message list result.
        ///     By default, there is no filter applied - both Inbound and Outbound messages are returned
        ///     Example: Inbound
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string[] direction { get; set; }

        /// <summary>
        ///     The end of the time range to filter the results in ISO 8601 format including timezone. Default is the 'dateTo'
        ///     minus 24 hours
        ///     Format: date-time
        ///     Example: Mon Nov 09 2020 08:07:52 GMT-0800 (Pacific Standard Time)
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        ///     The end of the time range to filter the results in ISO 8601 format including timezone. Default is the current time
        ///     Format: date-time
        ///     Example: Wed Nov 25 2020 08:07:52 GMT-0800 (Pacific Standard Time)
        /// </summary>
        public string dateTo { get; set; }

        /// <summary>
        ///     List of phone numbers (specified in 'to' or 'from' fields of a message) to filter the results. Maximum number of
        ///     phone numbers allowed to be specified as filters is 15
        ///     Example: 15551234455,15551235577
        /// </summary>
        public string[] phoneNumber { get; set; }
    }
}