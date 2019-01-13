using Newtonsoft.Json;

namespace RingCentral
{
    public class AddressBookSync : Serializable
    {
        public string uri;
        public PersonalContactResource[] records;
        public SyncInfo syncInfo;
        public int? nextPageId;
        public string nextPageUri;
    }
}