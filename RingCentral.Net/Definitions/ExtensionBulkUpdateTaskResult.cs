namespace RingCentral
{
    /// <summary>
    ///     Resulting record of a task on multiple extensions update
    /// </summary>
    public class ExtensionBulkUpdateTaskResult
    {
        /// <summary>
        /// </summary>
        public ExtensionBulkUpdateTaskResultAffectedItems affectedItems { get; set; }

        /// <summary>
        /// </summary>
        public ErrorEntity[] errors { get; set; }
    }
}