using Newtonsoft.Json;

namespace RingCentral
{
    public class ActivePermissionResource : Serializable
    {
        public PermissionIdResource permission;
        public RoleIdResource effectiveRole;
        public string[] scopes;
    }
}