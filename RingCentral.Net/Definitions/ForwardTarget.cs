namespace RingCentral
{
    // Identifier of a call party the call will be forwarded to. Only **one of** these parameters: `phoneNumber`, `voicemail` or `extensionNumber` must be specified, otherwise an error is returned.
    public class ForwardTarget
    {
        /// <summary>
        /// Phone number
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// Voicemail owner extension identifier
        /// </summary>
        public string voicemail { get; set; }

        /// <summary>
        /// Number of an extension
        /// </summary>
        public string extensionNumber { get; set; }
    }
}