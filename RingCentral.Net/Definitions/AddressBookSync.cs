namespace RingCentral
{
    public class AddressBookSync
    {
        /// <summary>
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public PersonalContactResource[] records { get; set; }

        /// <summary>
        /// </summary>
        public SyncInfo syncInfo { get; set; }

        /// <summary>
        /// </summary>
        public long? nextPageId { get; set; }

        /// <summary>
        /// </summary>
        public string nextPageUri { get; set; }
    }
}