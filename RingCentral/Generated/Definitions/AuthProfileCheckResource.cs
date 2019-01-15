using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class AuthProfileCheckResource : Serializable
    {
        public string uri;
        public bool? successful;
        public ActivePermissionResource details;
    }
}