using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ExtensionPermissionsResource : Serializable
    {
        public string uri;
        public Permission admin;
        public Permission internationalCalling;
        public Permission freeSoftPhoneDigitalLine;
    }
}