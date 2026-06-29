namespace RingCentral
{
    public class MthSyncAssignedHint
    {
        /// <summary>
        ///     Required
        ///     Enum: ThreadCreatedHint, ThreadResolvedHint, ThreadDeletedHint, ThreadAssignedHint
        /// </summary>
        public string recordType { get; set; }

        /// <summary>
        ///     Internal identifier of a system message
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Internal identifier of a message thread
        ///     Required
        /// </summary>
        public string threadId { get; set; }

        /// <summary>
        ///     Last modification date/time (always the same as a creation time since the system hints are immutable)
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Initiator of the action.
        ///     Can be missing if the action was initiated by the system.
        /// </summary>
        public MthSyncAssignedHintInitiator initiator { get; set; }

        /// <summary>
        /// </summary>
        public ThreadUserModel assignee { get; set; }

        /// <summary>
        /// </summary>
        public ThreadUserModel previousAssignee { get; set; }
    }
}