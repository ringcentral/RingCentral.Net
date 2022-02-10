namespace RingCentral
{
    /// <summary>
    ///     Information on extension, for which this presence data is returned
    /// </summary>
    public class GetPresenceExtensionInfo
    {
        /// <summary>
        ///     Internal identifier of an extension
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Canonical URI of an extension
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Extension number (usually 3 or 4 digits)
        /// </summary>
        public string extensionNumber { get; set; }
    }
}