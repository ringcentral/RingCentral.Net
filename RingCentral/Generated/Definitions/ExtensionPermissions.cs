using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ExtensionPermissions : Serializable
    {
        // Admin permission
        public PermissionInfo admin;
        // International Calling permission
        public PermissionInfo internationalCalling;
    }
}