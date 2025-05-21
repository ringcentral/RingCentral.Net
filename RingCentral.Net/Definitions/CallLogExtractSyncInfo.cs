namespace RingCentral
{
    public class CallLogExtractSyncInfo
    {
        /// <summary>
        ///     Type of call log synchronization request: full or incremental sync
        ///     Required
        ///     Enum: FSync, ISync
        /// </summary>
        public string syncType { get; set; }

        /// <summary>
        ///     Synchronization token
        ///     Required
        /// </summary>
        public string syncToken { get; set; }

        /// <summary>
        ///     Time of the last synchronization in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601] format including timezone,
        ///     for example *2016-03-10T18:07:52.534Z*
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string syncTime { get; set; }

        /// <summary>
        ///     Identifies if there are more calls data can be returned in the next API call (with 'ISync' sync type)
        ///     Required
        /// </summary>
        public bool? newerRecordsExist { get; set; }
    }
}