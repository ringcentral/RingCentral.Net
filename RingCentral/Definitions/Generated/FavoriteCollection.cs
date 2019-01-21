using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class FavoriteCollection : Serializable
    {
        public string uri;
        public FavoriteContactResource[] records;
    }
}