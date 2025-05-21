namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation extractSyncAccountCallLog
    /// </summary>
    public class ExtractSyncAccountCallLogParameters
    {
        /// <summary>
        ///     Type of call log synchronization request - full or incremental sync
        ///     Default: FSync
        ///     Enum: FSync, ISync
        /// </summary>
        public string syncType { get; set; }

        /// <summary>
        ///     Value of `syncToken` property of the last extract-sync request response. Mandatory for 'ISync' type
        /// </summary>
        public string syncToken { get; set; }

        /// <summary>
        ///     Starting datetime for resulting records in ISO 8601 format including timezone, for example
        ///     2016-03-10T18:07:52.534Z. The default value is one hour before the current moment
        ///     Format: date-time
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        ///     Allowed for `FSync` mode only. It limits the number of records to be returned in response
        ///     (the maximum number of records is 1000, the default value is 250).
        ///     Actual number of calls could extend the limit in case there are several calls at borderline
        ///     modification time (millisecond precision).
        ///     Minimum: 1
        ///     Format: int32
        ///     Default: 250
        /// </summary>
        public long? recordCount { get; set; }

        /// <summary>
        ///     Defines the level of details for returned call records
        ///     Default: Simple
        ///     Enum: Simple, Detailed
        /// </summary>
        public string view { get; set; }

        /// <summary>
        ///     Category of metadata to be returned. If omitted, all call records are returned.
        ///     Multiple values are supported
        /// </summary>
        public string[] metadataCategory { get; set; }
    }
}