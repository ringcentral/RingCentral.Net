namespace RingCentral
{
    public class SearchDirectoryEntriesRequest
    {
        /// <summary>
        ///     String value to filter the contacts. The value specified is searched through the following fields: `firstName`,
        ///     `lastName`, `extensionNumber`, `phoneNumber`, `email`, `jobTitle`, `department`, `customFieldValue`
        /// </summary>
        public string searchString { get; set; }

        /// <summary>
        ///     The list of field to be searched for
        ///     Enum: firstName, lastName, extensionNumber, phoneNumber, email, jobTitle, department, customFieldValue
        /// </summary>
        public string[] searchFields { get; set; }

        /// <summary>
        ///     If 'True' then contacts of all accounts in federation are returned, if it is in federation, account section will be
        ///     returned. If 'False' then only contacts of the current account are returned, and account section is eliminated in
        ///     this case
        /// </summary>
        public bool? showFederated { get; set; }

        /// <summary>
        ///     Should show AdminOnly Contacts
        /// </summary>
        public bool? showAdminOnlyContacts { get; set; }

        /// <summary>
        ///     Type of extension to filter the contacts
        ///     Example: FaxUser
        ///     Enum: User, Department, Announcement, Voicemail, DigitalUser, VirtualUser, FaxUser, PagingOnly, SharedLinesGroup,
        ///     IvrMenu, ApplicationExtension, ParkLocation, Limited, Site, DelegatedLinesGroup, FlexibleUser
        /// </summary>
        public string extensionType { get; set; }

        /// <summary>
        ///     Internal identifier of the business site to which extensions belong
        ///     Example: 872781797006
        /// </summary>
        public string siteId { get; set; }

        /// <summary>
        ///     Allows to control whether External (Hybrid) contacts should be returned in the response or not
        ///     Example: true
        /// </summary>
        public bool? showExternalContacts { get; set; }

        /// <summary>
        ///     The list of Internal identifiers of an accounts
        ///     Example: 854874047006,422456828004,854874151006
        /// </summary>
        public string[] accountIds { get; set; }

        /// <summary>
        ///     Department
        /// </summary>
        public string department { get; set; }

        /// <summary>
        ///     The list of Internal identifiers of the business sites to which extensions belong
        /// </summary>
        public string[] siteIds { get; set; }

        /// <summary>
        ///     Extension current state.
        ///     Enum: Enabled, Disabled, NotActivated
        /// </summary>
        public string[] extensionStatuses { get; set; }

        /// <summary>
        ///     Types of extension to filter the contacts.
        ///     Enum: User, Department, Announcement, Voicemail, DigitalUser, VirtualUser, FaxUser, PagingOnly, SharedLinesGroup,
        ///     IvrMenu, ApplicationExtension, ParkLocation, Limited, Site, DelegatedLinesGroup, FlexibleUser
        /// </summary>
        public string[] extensionTypes { get; set; }

        /// <summary>
        ///     Sorting settings
        /// </summary>
        public OrderBy[] orderBy { get; set; }

        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? perPage { get; set; }
    }
}