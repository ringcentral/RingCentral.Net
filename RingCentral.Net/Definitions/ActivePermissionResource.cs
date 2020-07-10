namespace RingCentral
{
    public class ActivePermissionResource
    {
        /// <summary>
        /// </summary>
        public PermissionIdResource permission;

        /// <summary>
        /// </summary>
        public RoleIdResource effectiveRole;

        /// <summary>
        /// Enum: Account, AllExtensions, Federation, NonUserExtensions, RoleBased, Self, UserExtensions
        /// </summary>
        public string[] scopes;
    }
}