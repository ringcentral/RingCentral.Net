using Newtonsoft.Json;

namespace RingCentral
{
    public class AuthProfileCheckResource : Serializable
    {
        public string uri;
        public bool? successful;
        public ActivePermissionResource details;
    }
}