using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class AddressBookSync : Serializable
    {
        public string uri;
        public PersonalContactResource[] records;
        public SyncInfo syncInfo;
        public long? nextPageId;
        public string nextPageUri;
    }
}