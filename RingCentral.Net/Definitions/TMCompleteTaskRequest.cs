namespace RingCentral
{
    public class TMCompleteTaskRequest
    {
        /// <summary>
        ///     Completeness status
        ///     Enum: Incomplete, Complete
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public TMCompleteTaskRequestAssignees[] assignees { get; set; }

        /// <summary>
        ///     Maximum: 100
        ///     Format: int32
        /// </summary>
        public long? completenessPercentage { get; set; }
    }
}