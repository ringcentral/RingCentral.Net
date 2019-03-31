namespace RingCentral
{
    public class SyncAddressBookParameters
    {
        /* Type of synchronization */
        public string[] syncType;

        /* Value of syncToken property of the last sync request response */
        public string syncToken;

        /* Number of records per page to be returned. The max number of records is 250, which is also the default. For 'FSync' if the number of records exceeds the parameter value (either specified or default), all of the pages can be retrieved in several requests. For 'ISync' if the number of records exceeds the page size, the number of incoming changes to this number is limited */
        public long? perPage;

        /* Internal identifier of a page. It can be obtained from the 'nextPageId' parameter passed in response body */
        public long? pageId;
    }
}