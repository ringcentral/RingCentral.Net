using Newtonsoft.Json;

namespace RingCentral
{
    public class ExtensionFavoritesEventBody : Serializable
    {
        // Internal identifier of an extension
        public string extensionId;
        // Internal identifier of a subscription owner extension
        public string ownerId;
    }
}