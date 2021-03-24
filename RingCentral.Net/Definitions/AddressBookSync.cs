namespace RingCentral
{
    public class AddressBookSync
    {
        /// <summary>
        /// Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public PersonalContactResource[] records { get; set; }

        /// <summary>
        /// </summary>
        public SyncInfo syncInfo { get; set; }

        /// <summary>
        /// Format: int64
        /// </summary>
        public long? nextPageId { get; set; }

        /// <summary>
        /// Format: uri
        /// </summary>
        public string nextPageUri { get; set; }
    }
}