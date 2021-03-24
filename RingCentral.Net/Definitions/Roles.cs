namespace RingCentral
{
    public class Roles
    {
        /// <summary>
        /// Link to a role
        /// Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Internal identifier of a role
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public bool? autoAssigned { get; set; }

        /// <summary>
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        /// </summary>
        public bool? siteCompatible { get; set; }

        /// <summary>
        /// </summary>
        public bool? siteRestricted { get; set; }
    }
}