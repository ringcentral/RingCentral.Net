namespace RingCentral
{
    public class SiteMembersBulkUpdate
    {
        /// <summary>
        ///     List of removed extensions
        /// </summary>
        public string[] removedExtensionIds { get; set; }

        /// <summary>
        ///     List of added extensions
        /// </summary>
        public string[] addedExtensionIds { get; set; }
    }
}