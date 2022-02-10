namespace RingCentral
{
    /// <summary>
    ///     List of extensions to be updated
    /// </summary>
    public class ExtensionBulkUpdateRequest
    {
        /// <summary>
        ///     Required
        /// </summary>
        public ExtensionBulkUpdateInfo[] records { get; set; }
    }
}