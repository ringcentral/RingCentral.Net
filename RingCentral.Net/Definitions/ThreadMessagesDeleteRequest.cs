namespace RingCentral
{
    public class ThreadMessagesDeleteRequest
    {
        /// <summary>
        ///     IDs of messages to be deleted
        ///     Required
        ///     Example: 2268298947,2268300303
        /// </summary>
        public string[] ids { get; set; }
    }
}