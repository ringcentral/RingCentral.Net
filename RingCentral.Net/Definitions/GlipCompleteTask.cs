namespace RingCentral
{
    public class GlipCompleteTask
    {
        /// <summary>
        /// Completeness status. 'Mandatory' if `completenessCondition` is set to `Simple`, otherwise 'Optional'
        /// Enum: Incomplete, Complete
        /// </summary>
        public string status;

        /// <summary>
        /// </summary>
        public AssigneeInfo[] assignees;

        /// <summary>
        /// Current completeness percentage of a task with the 'Percentage' completeness condition. 'Mandatory' if `completenessCondition` is set to `Percentage`, otherwise 'Optional'
        /// Maximum: 100
        /// </summary>
        public long? completenessPercentage;
    }
}