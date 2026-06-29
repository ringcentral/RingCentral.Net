namespace RingCentral
{
    /// <summary>
    /// Assignee extension information (can be `null` to unassign the thread)
    /// 
    /// </summary>
    public class AssignMessageThreadRequest
    {
        /// <summary>
        ///     Required
        /// </summary>
        public AssignMessageThreadRequestAssignee assignee { get; set; }
    }
}