namespace RingCentral
{
    public class AddressBookSync
    {
        /// <summary>
        /// </summary>
        public string uri;

        /// <summary>
        /// </summary>
        public PersonalContactResource[] records;

        /// <summary>
        /// </summary>
        public SyncInfo syncInfo;

        /// <summary>
        /// </summary>
        public long? nextPageId;

        /// <summary>
        /// </summary>
        public string nextPageUri;
    }
}