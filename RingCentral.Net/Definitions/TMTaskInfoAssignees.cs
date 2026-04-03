namespace RingCentral
{
    public class TMTaskInfoAssignees
    {
        /// <summary>
        ///     Internal identifier of an assignee
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Task execution status by assignee
        ///     Enum: Pending, Completed
        /// </summary>
        public string status { get; set; }
    }
}