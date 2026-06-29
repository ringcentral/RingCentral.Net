namespace RingCentral
{
    /// <summary>
    /// Query parameters for operation mthSyncThreads
    /// </summary>
    public class MthSyncThreadsParameters
    {
        /// <summary>
        ///     Type of message synchronization request:
        ///       - FSync -- full sync
        ///       - ISync -- incremental sync
        ///     Default: FSync
        ///     Enum: FSync, ISync
        /// </summary>
        public string syncType { get; set; }

        /// <summary>
        ///     Sync token (for "ISync" only)
        /// </summary>
        public string syncToken { get; set; }
    }
}