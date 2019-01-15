using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class UpdateGlipEveryoneRequest : Serializable
    {
        // Everyone chat name. Maximum number of characters suppported is 250
        public long? name;
        // Everyone chat description. Maximum number of characters suppported is 1000
        public string description;
    }
}