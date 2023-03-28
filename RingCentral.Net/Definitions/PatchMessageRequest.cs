namespace RingCentral
{
    /// <summary>
    ///     Either `readStatus` or `availability` or both are required
    /// </summary>
    public class PatchMessageRequest
    {
        /// <summary>
        ///     Message read status
        ///     Enum: Read, Unread
        /// </summary>
        public string readStatus { get; set; }

        /// <summary>
        ///     Message availability status. Message in 'Deleted' state is still
        ///     preserved with all its attachments and can be restored. 'Purged' means
        ///     that all attachments are already deleted and the message itself is about
        ///     to be physically deleted shortly
        ///     Enum: Alive, Deleted, Purged
        /// </summary>
        public string availability { get; set; }
    }
}