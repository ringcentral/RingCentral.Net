namespace RingCentral
{
    public class ThreadEntrySyncItem
    {
        /// <summary>
        ///     Required
        ///     Enum: AliveMessage, DeletedMessage, AliveNote, DeletedNote, ThreadCreatedHint, ThreadResolvedHint, ThreadDeletedHint, ThreadAssignedHint
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
        ///     Thread/message availability
        ///     Required
        ///     Enum: Alive, Deleted
        /// </summary>
        public string availability { get; set; }

        /// <summary>
        ///     Note creation date/time
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Message direction (inbound or outbound)
        ///     Required
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        ///     Last modification date/time (always the same as a creation time since the system hints are immutable)
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Message status. Different message types may have different
        ///     allowed status values. For outbound faxes the aggregated message status
        ///     is returned. If, for multi-recipient outbound message, a status for
        ///     at least one recipient is `Queued`, then the `Queued` value is returned.
        ///     If a status for at least one recipient is `SendingFailed`,
        ///     then the 'SendingFailed' value is returned. In other cases,
        ///     the `Sent` status is returned
        ///     Enum: Queued, Sent, Delivered, DeliveryFailed, SendingFailed, Received
        /// </summary>
        public string messageStatus { get; set; }

        /// <summary>
        ///     Message or note text
        ///     Example: Hello, how are you doing today?
        /// </summary>
        public string text { get; set; }

        /// <summary>
        ///     Message attachments (if any)
        /// </summary>
        public MessageAttachmentResponseEntry[] attachments { get; set; }

        /// <summary>
        ///     Thread note author
        /// </summary>
        public ThreadEntrySyncItemAuthor author { get; set; }

        /// <summary>
        ///     Initiator of the action.
        ///     Can be missing if the action was initiated by the system.
        /// </summary>
        public ThreadEntrySyncItemInitiator initiator { get; set; }

        /// <summary>
        /// </summary>
        public ThreadUserModel assignee { get; set; }

        /// <summary>
        /// </summary>
        public ThreadUserModel previousAssignee { get; set; }
    }
}