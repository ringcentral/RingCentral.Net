using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class AuthProfileResource : Serializable
    {
        public string uri;
        public ActivePermissionResource[] permissions;
    }
}