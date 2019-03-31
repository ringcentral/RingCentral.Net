namespace RingCentral
{
    public class ListDirectoryEntriesParameters
    {
        /* If 'True' then contacts of all accounts in federation are returned. If 'False' then only contacts of the current account are returned, and account section is eliminated in this case */
        // Default: true
        public string showFederated;

        /* Type of an extension */
        // Enum: User, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly, IvrMenu, ParkLocation, Limited
        public string type;

        /* Page number */
        // Default: 1
        public string page;

        /* Records count to be returned per one page. The default value is 1000. Specific keyword values: `all` - all records are returned in one page; `max` - maximum count of records that can be returned in one page */
        // Maximum: 2000
        // Default: 1000
        public string perPage;

        /* Internal identifier of the business site to which extensions belong */
        public string siteId;
    }
}