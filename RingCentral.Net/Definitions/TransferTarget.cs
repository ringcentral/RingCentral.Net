namespace RingCentral
{
    // Identifier of a call party the call will be transfered to. Only **one of** these parameters: `phoneNumber`, `voicemail`, `extensionNumber` or `parkOrbit` must be specified, otherwise an error is returned.
    public class TransferTarget
    {
        /// <summary>
        ///     Phone number
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Voicemail owner extension identifier
        /// </summary>
        public string voicemail { get; set; }

        /// <summary>
        ///     Park orbit identifier
        /// </summary>
        public string parkOrbit { get; set; }

        /// <summary>
        ///     Number of extension
        /// </summary>
        public string extensionNumber { get; set; }
    }
}