namespace RingCentral
{
    public class ListExtensionGrantsParameters
    {
        /// <summary>
        /// Type of extension to be returned. Multiple values are supported
        /// Enum: User, FaxUser, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly, IvrMenu, ApplicationExtension, ParkLocation, Limited, Bot
        /// </summary>
        public string extensionType;

        /// <summary>
        /// Default: 1
        /// </summary>
        public string page;

        /// <summary>
        /// Default: 100
        /// </summary>
        public string perPage;
    }
}