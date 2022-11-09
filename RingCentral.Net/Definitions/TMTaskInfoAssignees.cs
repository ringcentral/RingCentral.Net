namespace RingCentral
{
    public class TMTaskInfoAssignees
    {
        /// <summary>
        ///     Assignee Id
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Task execution status by assignee
        ///     Enum: Pending, Completed
        /// </summary>
        public string status { get; set; }
    }
}