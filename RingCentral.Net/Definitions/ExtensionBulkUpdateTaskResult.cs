namespace RingCentral
{
    /// <summary>
    ///     Result record on multiple extension update task
    /// </summary>
    public class ExtensionBulkUpdateTaskResult
    {
        /// <summary>
        /// </summary>
        public ExtensionUpdateShortResult[] affectedItems { get; set; }

        /// <summary>
        /// </summary>
        public ErrorEntity[] errors { get; set; }
    }
}