using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class RecordsCollectionResourceSubscriptionResponse : Serializable
    {
        public string uri;
        public SubscriptionInfo[] records;
    }
}