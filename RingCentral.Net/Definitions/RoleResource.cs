namespace RingCentral
{
    public class RoleResource
    {
        /// <summary>
        ///     Link to a role resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a role
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Dispayed name of a role
        ///     Example: Super Admin
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        ///     Role description
        ///     Example: Primary company administrator role
        /// </summary>
        public string description { get; set; }

        /// <summary>
        ///     Site compatibility of a user role
        /// </summary>
        public bool? siteCompatible { get; set; }

        /// <summary>
        ///     Specifies if a user role is custom
        /// </summary>
        public bool? custom { get; set; }

        /// <summary>
        ///     Specifies resource for permission
        ///     Enum: Account, AllExtensions, Federation, NonUserExtensions, RoleBased, Self, UserExtensions
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        /// </summary>
        public bool? hidden { get; set; }

        /// <summary>
        ///     Format: date-time
        /// </summary>
        public string lastUpdated { get; set; }

        /// <summary>
        /// </summary>
        public PermissionIdResource[] permissions { get; set; }
    }
}