namespace RingCentral
{
    public class AssignedRoleResource
    {
        /// <summary>
        ///     Internal identifier of a role
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Specifies if a role can be auto assigned
        /// </summary>
        public bool? autoAssigned { get; set; }

        /// <summary>
        ///     Name of a default role
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        ///     Site compatibility flag
        /// </summary>
        public bool? siteCompatible { get; set; }

        /// <summary>
        ///     Site restricted flag
        /// </summary>
        public bool? siteRestricted { get; set; }
    }
}