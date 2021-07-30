namespace RingCentral
{
    public class RoleResource
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
        ///     Site compatibility of a user role
        /// </summary>
        public bool? siteCompatible { get; set; }

        /// <summary>
        /// </summary>
        public bool? custom { get; set; }

        /// <summary>
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