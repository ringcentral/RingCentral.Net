namespace RingCentral
{
    public class BulkRoleAssignResource
    {
        /// <summary>
        ///     Example: true
        /// </summary>
        public bool? siteRestricted { get; set; }

        /// <summary>
        /// </summary>
        public bool? siteCompatible { get; set; }

        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public string[] addedExtensionIds { get; set; }

        /// <summary>
        /// </summary>
        public string[] removedExtensionIds { get; set; }
    }
}