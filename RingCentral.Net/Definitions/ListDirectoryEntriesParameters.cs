namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listDirectoryEntries
    /// </summary>
    public class ListDirectoryEntriesParameters
    {
        /// <summary>
        ///     If 'True' then contacts of all accounts in federation are returned. If 'False' then only contacts of the current
        ///     account are returned, and account section is eliminated in this case
        ///     Default: true
        /// </summary>
        public bool? showFederated { get; set; }

        /// <summary>
        ///     Type of an extension. Please note that legacy 'Department' extension type corresponds to 'Call Queue' extensions in
        ///     modern RingCentral product terminology
        ///     Enum: User, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly, IvrMenu, ParkLocation, Limited,
        ///     External
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Page number
        ///     Format: int32
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Records count to be returned per one page. The default value is 1000. Specific keyword values: `all` - all records
        ///     are returned in one page; `max` - maximum count of records that can be returned in one page
        ///     Maximum: 2000
        ///     Format: int32
        ///     Default: 1000
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Internal identifier of the business site to which extensions belong
        /// </summary>
        public string siteId { get; set; }
    }
}