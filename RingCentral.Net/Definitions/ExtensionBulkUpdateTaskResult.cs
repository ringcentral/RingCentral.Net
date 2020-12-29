namespace RingCentral
{
    // Result record on multiple extension update task
    public class ExtensionBulkUpdateTaskResult
    {
        /// <summary>
        /// </summary>
        public ExtensionUpdateShortResult[] affectedItems;

        /// <summary>
        /// </summary>
        public ErrorEntity[] errors;
    }
}