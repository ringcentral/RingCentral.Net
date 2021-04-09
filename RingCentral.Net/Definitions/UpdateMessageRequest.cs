namespace RingCentral
{
    public class UpdateMessageRequest
    {
        /// <summary>
        ///     Read status of a message to be changed. Multiple values are accepted
        ///     Enum: Read, Unread
        /// </summary>
        public string readStatus { get; set; }
    }
}