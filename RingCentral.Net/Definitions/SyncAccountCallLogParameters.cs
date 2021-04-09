namespace RingCentral
{
    // Query parameters for operation syncAccountCallLog
    public class SyncAccountCallLogParameters
    {
        /// <summary>
        ///     Type of synchronization.
        ///     Default: FSync
        ///     Enum: FSync, ISync
        /// </summary>
        public string syncType { get; set; }

        /// <summary>
        ///     Value of syncToken property of last sync request response
        /// </summary>
        public string syncToken { get; set; }

        /// <summary>
        ///     The start datetime for resulting records in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601]  format including
        ///     timezone, for example 2016-03-10T18:07:52.534Z. The default value is the current moment
        ///     Format: date-time
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        ///     For 'FSync' the parameter is mandatory, it limits the number of records to be returned in response. For 'ISync' it
        ///     specifies with how many records to extend sync frame to the past, the maximum number of records is 250
        /// </summary>
        public long? recordCount { get; set; }

        /// <summary>
        ///     Type of calls to be returned.
        ///     Enum: Missed, All
        /// </summary>
        public string[] statusGroup { get; set; }

        /// <summary>
        ///     View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be
        ///     changed for ISync
        ///     Default: Simple
        ///     Enum: Simple, Detailed
        /// </summary>
        public string view { get; set; }

        /// <summary>
        ///     Supported for ISync. If 'True' then deleted call records are returned
        /// </summary>
        public bool? showDeleted { get; set; }
    }
}