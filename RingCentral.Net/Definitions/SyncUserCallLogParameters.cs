namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation syncUserCallLog
    /// </summary>
    public class SyncUserCallLogParameters
    {
        /// <summary>
        ///     Type of call log synchronization request: full or incremental sync
        ///     Enum: FSync, ISync
        /// </summary>
        public string syncType { get; set; }

        /// <summary>
        ///     Value of syncToken property of last sync request response
        /// </summary>
        public string syncToken { get; set; }

        /// <summary>
        ///     The start datetime for resulting records in ISO 8601 format including timezone, for example
        ///     2016-03-10T18:07:52.534Z. The default value is the current moment
        ///     Format: date-time
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        ///     For 'FSync' the parameter is mandatory, it limits the number of records to be returned in response. For 'ISync' it
        ///     specifies with how many records to extend sync Frame to the past, the maximum number of records is 250
        ///     Format: int32
        /// </summary>
        public long? recordCount { get; set; }

        /// <summary>
        ///     Type of calls to be returned. The default value is 'All'
        ///     Enum: Missed, All
        /// </summary>
        public string[] statusGroup { get; set; }

        /// <summary>
        ///     Defines the level of details for returned call records
        ///     Default: Simple
        ///     Enum: Simple, Detailed
        /// </summary>
        public string view { get; set; }

        /// <summary>
        ///     Supported for `ISync` mode. Indicates that deleted call records should be returned
        /// </summary>
        public bool? showDeleted { get; set; }
    }
}