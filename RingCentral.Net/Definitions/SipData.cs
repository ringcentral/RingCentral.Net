namespace RingCentral
{
    /// <summary>
    ///     SIP (Session Initiation Protocol) information.
    ///     Returned if query parameter sipData is set to 'True'
    /// </summary>
    public class SipData
    {
        /// <summary>
        ///     Recipient's data
        /// </summary>
        public string toTag { get; set; }

        /// <summary>
        ///     Sender's data
        /// </summary>
        public string fromTag { get; set; }

        /// <summary>
        ///     SIP call identifier
        /// </summary>
        public string callId { get; set; }
    }
}