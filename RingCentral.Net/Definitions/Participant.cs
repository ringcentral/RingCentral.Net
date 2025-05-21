namespace RingCentral
{
    /// <summary>
    ///     Basic participant information
    /// </summary>
    public class Participant
    {
        /// <summary>
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        ///     Non empty if user joined by phone
        /// </summary>
        public string callerId { get; set; }

        /// <summary>
        ///     Participant type
        ///     Required
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Pass-thru parameter in join url
        /// </summary>
        public string correlationId { get; set; }
    }
}