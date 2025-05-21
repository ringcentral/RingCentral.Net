namespace RingCentral
{
    public class ContactResource
    {
        /// <summary>
        ///     Contact extension identifier
        ///     Required
        ///     Example: 865706371004
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Contact type
        ///     Example: User
        ///     Enum: User, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly, ParkLocation, IvrMenu, Limited,
        ///     ApplicationExtension, Site, Bot, Room, ProxyAdmin, DelegatedLinesGroup, GroupCallPickup, External, RoomConnector,
        ///     Unknown
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Contact status
        ///     Example: Enabled
        ///     Enum: Enabled, Disabled, Frozen, NotActivated, Unassigned, Unknown
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public AccountResource account { get; set; }

        /// <summary>
        ///     Example: External
        /// </summary>
        public string department { get; set; }

        /// <summary>
        ///     Format: email
        ///     Example: john.doe@mycompany.com
        /// </summary>
        public string email { get; set; }

        /// <summary>
        ///     Example: 103
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     First name of a contact, for user extensions only
        ///     Example: John
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        ///     Last name of a contact, for user extensions only
        ///     Example: Doe
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        ///     Name of a contact, for non-user extensions
        ///     Example: Conference room ?5
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Example: Sales manager
        /// </summary>
        public string jobTitle { get; set; }

        /// <summary>
        /// </summary>
        public AdgPhoneNumberResource[] phoneNumbers { get; set; }

        /// <summary>
        /// </summary>
        public AccountDirectoryProfileImageResource profileImage { get; set; }

        /// <summary>
        /// </summary>
        public BusinessSiteResource site { get; set; }

        /// <summary>
        /// </summary>
        public bool? hidden { get; set; }

        /// <summary>
        /// </summary>
        public CustomFieldResource[] customFields { get; set; }

        /// <summary>
        /// </summary>
        public ExternalIntegrationResource integration { get; set; }
    }
}