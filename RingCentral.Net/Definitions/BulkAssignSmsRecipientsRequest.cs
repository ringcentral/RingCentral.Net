namespace RingCentral
{
    /// <summary>
    /// One of the parameters ('addedExtensionIds', 'removedExtensionIds') must be specified and not empty.
    /// </summary>
    public class BulkAssignSmsRecipientsRequest
    {
        /// <summary>
        ///     List of added extensions.
        ///     maxItems values depends on MessageThreads feature.
        ///     If the feature is disabled maxItems=1, otherwise 50.
        /// </summary>
        public string[] addedExtensionIds { get; set; }

        /// <summary>
        ///     List of removed extensions.
        ///     maxItems values depends on MessageThreads feature.
        ///     If the feature is disabled maxItems=1, otherwise 50.
        /// </summary>
        public string[] removedExtensionIds { get; set; }
    }
}