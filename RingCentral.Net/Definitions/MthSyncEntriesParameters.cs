namespace RingCentral
{
    /// <summary>
    /// Query parameters for operation mthSyncEntries
    /// </summary>
    public class MthSyncEntriesParameters
    {
        /// <summary>
        ///     Scope of synchronization (`syncType=FSync` only):
        ///     
        ///     - `Accessible`: returns entries in threads monitored by the current user;
        ///     - `Unassigned`: returns entries in accessible unassigned threads;
        ///     - `AssignedToMe`: returns entries in threads that are assigned to the current user;
        ///     - `AssignedToMeAndUnassigned`: returns entries in threads that are assigned to the current user or unassigned;
        ///     - `Explicit`: returns entries in threads specified through the `threadIds` parameter.
        ///     Default: AssignedToMe
        ///     Enum: Accessible, Unassigned, AssignedToMe, AssignedToMeAndUnassigned, Explicit
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        ///     List of thread IDs to synchronize (`Explicit` scope only)
        /// </summary>
        public string[] threadIds { get; set; }

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