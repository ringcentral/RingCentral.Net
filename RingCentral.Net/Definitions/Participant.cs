namespace RingCentral
{
    /// <summary>
    ///     Participant information
    /// </summary>
    public class Participant
    {
        /// <summary>
        ///     id
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     account id
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        ///     extension id
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     displayName
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        ///     caller id
        /// </summary>
        public string callerId { get; set; }
    }
}