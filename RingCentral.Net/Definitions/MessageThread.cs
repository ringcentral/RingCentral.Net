namespace RingCentral
{
    public class MessageThread
    {
        /// <summary>
        ///     Thread ID
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Thread human-readable label
        /// </summary>
        public string label { get; set; }

        /// <summary>
        ///     Thread status
        ///     Required
        ///     Enum: Open, Resolved
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Thread status transition reason (for threads in `Resolved` status only):
        ///     
        ///     - `Manual` - the thread was resolved manually;
        ///     - `ThreadExpired` - the thread was automatically resolved according to TTL settings;
        ///     - `OwnerDeleted` - the thread owner's extension was deleted;
        ///     - `OwnerPhoneNumberDeleted` - the thread owner's phone number this thread was created for was deleted.
        ///     Enum: Manual, ThreadExpired, OwnerDeleted, OwnerPhoneNumberDeleted
        /// </summary>
        public string statusReason { get; set; }

        /// <summary>
        ///     Thread/message availability
        ///     Required
        ///     Enum: Alive, Deleted
        /// </summary>
        public string availability { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public OwnerResource owner { get; set; }

        /// <summary>
        ///     Thread owner phone number information
        /// </summary>
        public MessageThreadOwnerParty ownerParty { get; set; }

        /// <summary>
        ///     Thread guest phone number information
        /// </summary>
        public MessageThreadGuestParty guestParty { get; set; }

        /// <summary>
        ///     Cleared automatically when the thread is resolved or deleted
        /// </summary>
        public MessageThreadAssignee assignee { get; set; }

        /// <summary>
        ///     Thread creation time
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Thread last modification time
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }
    }
}