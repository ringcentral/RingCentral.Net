namespace RingCentral
{
    // Information on extension, for which this presence data is returned
    public class GetPresenceExtensionInfo
    {
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public long? id;

        /// <summary>
        /// Canonical URI of an extension
        /// </summary>
        public string uri;

        /// <summary>
        /// Extension number (usually 3 or 4 digits)
        /// </summary>
        public string extensionNumber;
    }
}