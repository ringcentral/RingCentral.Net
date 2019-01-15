using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ActivePermissionResource : Serializable
    {
        public PermissionIdResource permission;
        public RoleIdResource effectiveRole;
        public string[] scopes;
    }
}