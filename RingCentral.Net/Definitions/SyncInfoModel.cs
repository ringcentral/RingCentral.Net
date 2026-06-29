namespace RingCentral
{
    public class SyncInfoModel
    {
        /// <summary>
        ///     Type of message synchronization request:
        ///       - FSync -- full sync
        ///       - ISync -- incremental sync
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
        ///     Last synchronization date/time
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string syncTime { get; set; }
    }
}