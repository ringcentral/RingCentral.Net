namespace RingCentral
{
    public class NewThreadMessageRequest
    {
        /// <summary>
        ///     Internal identifier of a message thread.
        ///     If not specified, the thread will be assigned automatically based on phone numbers.
        ///     If provided `threadId` is invalid (e.g. does not exist, already resolved, etc.), the API returns an error.
        /// </summary>
        public string threadId { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public MessagePhoneParty from { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public MessagePhoneParty[] to { get; set; }

        /// <summary>
        ///     Message or note text
        ///     Required
        ///     Example: Hello, how are you doing today?
        /// </summary>
        public string text { get; set; }
    }
}