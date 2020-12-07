namespace RingCentral
{
    // Extension information
    public class ExtensionInfoGrants
    {
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public string id;

        /// <summary>
        /// Canonical URI of an extension
        /// </summary>
        public string uri;

        /// <summary>
        /// Extension short number (usually 3 or 4 digits)
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// Name of extension
        /// </summary>
        public string name;

        /// <summary>
        /// Extension type
        /// Enum: User, Fax User, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly, IvrMenu, ApplicationExtension, ParkLocation
        /// </summary>
        public string type;
    }
}