namespace RingCentral
{
    public class SyncInfo
    {
        /// <summary>
        ///     Enum: FSync, ISync
        /// </summary>
        public string syncType { get; set; }

        /// <summary>
        /// </summary>
        public string syncToken { get; set; }

        /// <summary>
        ///     Format: date-time
        /// </summary>
        public string syncTime { get; set; }

        /// <summary>
        /// </summary>
        public bool? olderRecordsExist { get; set; }
    }
}