namespace RingCentral
{
    public class UpdateMessageRequest
    {
        /// <summary>
        ///     Message read status
        ///     Required
        ///     Enum: Read, Unread
        /// </summary>
        public string readStatus { get; set; }
    }
}