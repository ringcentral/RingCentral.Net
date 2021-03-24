namespace RingCentral
{
    // Sender of a pager message.
    public class PagerCallerInfoRequest
    {
        /// <summary>
        /// Extension identifier
        /// Example: 123456789
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        /// Extension number
        /// Example: 105
        /// </summary>
        public string extensionNumber { get; set; }
    }
}