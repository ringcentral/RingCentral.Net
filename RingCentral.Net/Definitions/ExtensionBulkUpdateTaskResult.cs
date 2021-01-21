namespace RingCentral
{
    // Result record on multiple extension update task
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