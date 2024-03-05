namespace RingCentral
{
    /// <summary>
    ///     Participant information
    /// </summary>
    public class Participant
    {
        /// <summary>
        ///     Participant type
        ///     Required
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     id
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Account id
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        ///     Extension id
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     Display name
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        ///     Caller id
        /// </summary>
        public string callerId { get; set; }

        /// <summary>
        ///     Pass-thru parameter in join url
        /// </summary>
        public string correlationId { get; set; }
    }
}