namespace RingCentral
{
    /// <summary>
    ///     Identifier of a call party the call will be transferred to. Only **one of** these parameters: `phoneNumber`,
    ///     `voicemail`, `extensionNumber`, `parkOrbit` or `extensionId` must be specified, otherwise an error is returned.
    /// </summary>
    public class TransferTarget
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
        ///     Park orbit identifier
        ///     Required
        /// </summary>
        public string parkOrbit { get; set; }

        /// <summary>
        ///     Extension mailbox identifier
        ///     Required
        /// </summary>
        public string extensionId { get; set; }
    }
}