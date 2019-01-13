using Newtonsoft.Json;

namespace RingCentral
{
    public class ExtensionPermissions : Serializable
    {
        // Admin permission
        public PermissionInfo admin;
        // International Calling permission
        public PermissionInfo internationalCalling;
    }
}