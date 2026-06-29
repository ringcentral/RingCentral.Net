namespace RingCentral
{
    public class ThreadNoteCreateRequest
    {
        /// <summary>
        ///     Internal identifier of a message thread
        ///     Required
        /// </summary>
        public string threadId { get; set; }

        /// <summary>
        ///     Message or note text
        ///     Required
        ///     Example: Hello, how are you doing today?
        /// </summary>
        public string text { get; set; }
    }
}