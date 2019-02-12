namespace RingCentral
{
    public class AddressBookSync
    {
        public string uri;

        public PersonalContactResource[] records;

        public SyncInfo syncInfo;

        public long? nextPageId;

        public string nextPageUri;
    }
}