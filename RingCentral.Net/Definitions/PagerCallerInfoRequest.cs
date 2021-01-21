namespace RingCentral
{
    // Sender of a pager message.
    public class PagerCallerInfoRequest
    {
        /// <summary>
        /// Extension identifier
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        /// Extension number
        /// </summary>
        public string extensionNumber { get; set; }
    }
}