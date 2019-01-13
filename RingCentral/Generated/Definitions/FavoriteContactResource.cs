using Newtonsoft.Json;

namespace RingCentral
{
    public class FavoriteContactResource : Serializable
    {
        public string uri;
        public string id;
        public string extensionId;
        public string contactId;
    }
}