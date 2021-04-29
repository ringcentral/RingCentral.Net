namespace RingCentral
{
    public class SearchDirectoryEntriesRequest
    {
        /// <summary>
        ///     String value to filter the contacts. The value specified is searched through the following fields: `firstName`, `lastName`, `extensionNumber`, `phoneNumber`, `email`, `jobTitle`, `department`
        /// </summary>
        public string searchString { get; set; }

        /// <summary>
        ///     Enum: firstName, lastName, extensionNumber, phoneNumber, email, jobTitle, department
        /// </summary>
        public string[] searchFields { get; set; }

        /// <summary>
        ///     If 'True' then contacts of all accounts in federation are returned. If 'False' then only contacts of the current account are returned, and account section is eliminated in this case
        ///     Default: true
        /// </summary>
        public bool? showFederated { get; set; }

        /// <summary>
        ///     Type of extension to filter the contacts. Please note that legacy 'Department' extension type corresponds to 'Call Queue' extensions in modern RingCentral product terminology
        ///     Enum: User, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly, ParkLocation, IvrMenu, Limited, ApplicationExtension, Site, Bot, ProxyAdmin, DelegatedLinesGroup, GroupCallPickup
        /// </summary>
        public string extensionType { get; set; }

        /// <summary>
        ///     Sorting settings
        /// </summary>
        public OrderBy[] orderBy { get; set; }

        /// <summary>
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        /// </summary>
        public long? perPage { get; set; }
    }
}