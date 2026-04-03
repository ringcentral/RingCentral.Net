namespace RingCentral
{
    /// <summary>
    /// Settings about automatic reply message sending to collect consent.
    /// </summary>
    public class AutomaticConsentCollecting
    {
        /// <summary>
        ///     Necessity of automatic reply message sending to collect consent.
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Reply message which will contain instructions how to grant opt-in or opt-out consent.
        /// </summary>
        public string replyMessageBody { get; set; }
    }
}