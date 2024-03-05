namespace RingCentral
{
    public class ActivePermissionResource
    {
        /// <summary>
        /// </summary>
        public PermissionIdResource permission { get; set; }

        /// <summary>
        /// </summary>
        public RoleIdResource effectiveRole { get; set; }

        /// <summary>
        ///     Enum: Account, AllExtensions, Federation, NonUserExtensions, RoleBased, Self, UserExtensions
        /// </summary>
        public string[] scope { get; set; }
    }
}