namespace RingCentral
{
    public class SearchDirectoryEntriesRequest : Serializable
    {
        // String value to filter the contacts. The value specified is searched through the following fields: `firstName`, `lastName`, `extensionNumber`, `phoneNumber`, `email`
        public string searchString;
        // If 'True' then contacts of all accounts in federation are returned. If 'False' then only contacts of the current account are returned, and account section is eliminated in this case
        public bool? showFederated;
        // Type of extension to filter the contacts
        // Enum: User, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly, ParkLocation, IvrMenu, Limited, ApplicationExtension, Site, Bot
        public string extensionType;
        // Sorting settings
        public OrderBy[] orderBy;
        public long? page;
        public long? perPage;
    }
}