namespace RingCentral
{
    public class PermissionResource
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// </summary>
        public bool? assignable { get; set; }

        /// <summary>
        /// </summary>
        public bool? readOnly { get; set; }

        /// <summary>
        ///     Site compatibility flag set for permission
        ///     Enum: Incompatible, Compatible, Independent
        /// </summary>
        public string siteCompatible { get; set; }

        /// <summary>
        /// </summary>
        public PermissionCategoryIdResource category { get; set; }

        /// <summary>
        /// </summary>
        public PermissionIdResource[] includedPermissions { get; set; }
    }
}