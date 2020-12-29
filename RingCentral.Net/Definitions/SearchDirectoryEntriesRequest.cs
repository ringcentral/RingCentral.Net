namespace RingCentral
{
    public class SearchDirectoryEntriesRequest
    {
        /// <summary>
        /// String value to filter the contacts. The value specified is searched through the following fields: `firstName`, `lastName`, `extensionNumber`, `phoneNumber`, `email`, `jobTitle`, `department`
        /// </summary>
        public string searchString;

        /// <summary>
        /// Enum: firstName, lastName, extensionNumber, phoneNumber, email, jobTitle, department
        /// </summary>
        public string[] searchFields;

        /// <summary>
        /// If 'True' then contacts of all accounts in federation are returned. If 'False' then only contacts of the current account are returned, and account section is eliminated in this case
        /// Default: true
        /// </summary>
        public bool? showFederated;

        /// <summary>
        /// Type of extension to filter the contacts
        /// Enum: User, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly, ParkLocation, IvrMenu, Limited, ApplicationExtension, Site, Bot, ProxyAdmin, DelegatedLinesGroup
        /// </summary>
        public string extensionType;

        /// <summary>
        /// Sorting settings
        /// </summary>
        public OrderBy[] orderBy;

        /// <summary>
        /// </summary>
        public long? page;

        /// <summary>
        /// </summary>
        public long? perPage;
    }
}