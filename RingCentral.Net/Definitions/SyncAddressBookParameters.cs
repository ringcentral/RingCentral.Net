namespace RingCentral
{
    public class SyncAddressBookParameters
    {
        /// <summary>
        /// Type of synchronization
        /// Enum: FSync, ISync
        /// </summary>
        public string[] syncType;

        /// <summary>
        /// Value of syncToken property of the last sync request response
        /// </summary>
        public string syncToken;

        /// <summary>
        /// Number of records per page to be returned. The max number of records is 250, which is also the default. For 'FSync' if the number of records exceeds the parameter value (either specified or default), all of the pages can be retrieved in several requests. For 'ISync' if the number of records exceeds the page size, the number of incoming changes to this number is limited
        /// </summary>
        public long? perPage;

        /// <summary>
        /// Internal identifier of a page. It can be obtained from the 'nextPageId' parameter passed in response body
        /// </summary>
        public long? pageId;
    }
}