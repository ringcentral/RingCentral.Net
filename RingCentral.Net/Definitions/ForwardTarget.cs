namespace RingCentral
{
    /// <summary>
    ///     Identifier of a call party the call will be forwarded to. Only **one of** these parameters: `phoneNumber`,
    ///     `voicemail`, `extensionNumber` or `extensionId` must be specified, otherwise an error is returned.
    /// </summary>
    public class ForwardTarget
    {
        /// <summary>
        ///     Phone number
        ///     Required
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Voicemail owner extension identifier
        ///     Required
        /// </summary>
        public string voicemail { get; set; }

        /// <summary>
        ///     Extension short number
        ///     Required
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Extension mailbox identifier
        ///     Required
        /// </summary>
        public string extensionId { get; set; }
    }
}