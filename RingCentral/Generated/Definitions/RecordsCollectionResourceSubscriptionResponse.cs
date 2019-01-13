using Newtonsoft.Json;

namespace RingCentral
{
    public class RecordsCollectionResourceSubscriptionResponse : Serializable
    {
        public string uri;
        public SubscriptionInfo[] records;
    }
}