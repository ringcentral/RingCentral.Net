namespace RingCentral
{
    /// <summary>
    ///     Call session information
    /// </summary>
    public class CallSessionObject
    {
        /// <summary>
        ///     Internal identifier of a call session
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public OriginInfo origin { get; set; }

        /// <summary>
        ///     For calls of 'Conference' type only
        /// </summary>
        public string voiceCallToken { get; set; }

        /// <summary>
        /// </summary>
        public CallParty[] parties { get; set; }

        /// <summary>
        ///     Date and time of the latest session update represented in Unix time format
        /// </summary>
        public string creationTime { get; set; }
    }
}