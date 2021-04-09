namespace RingCentral
{
    // Task detailed result. Returned for failed and completed tasks
    public class TaskResultInfo
    {
        /// <summary>
        ///     Detailed task results by elements from initial request
        /// </summary>
        public TaskResultRecord[] records { get; set; }
    }
}