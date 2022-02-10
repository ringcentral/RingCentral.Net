namespace RingCentral
{
    /// <summary>
    ///     Sync type, token and time
    /// </summary>
    public class SyncInfoMessages
    {
        /// <summary>
        ///     Type of synchronization
        ///     Enum: FSync, ISync
        /// </summary>
        public string syncType { get; set; }

        /// <summary>
        ///     Synchronization token
        /// </summary>
        public string syncToken { get; set; }

        /// <summary>
        ///     Last synchronization datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string syncTime { get; set; }

        /// <summary>
        /// </summary>
        public bool? olderRecordsExist { get; set; }
    }
}