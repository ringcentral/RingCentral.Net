using Newtonsoft.Json;

namespace RingCentral.Net
{
    // [Deprecated] Extension permissions, corresponding to the Service Web permissions 'Admin' and 'InternationalCalling'
    public class ExtensionPermissions : Serializable
    {
        // Admin permission
        public PermissionInfo admin;
        // International Calling permission
        public PermissionInfo internationalCalling;
    }
}