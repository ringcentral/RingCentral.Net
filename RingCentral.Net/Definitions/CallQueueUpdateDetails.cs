namespace RingCentral
{
    public class CallQueueUpdateDetails
    {
        /// <summary>
        /// </summary>
        public CallQueueServiceLevelSettings serviceLevelSettings { get; set; }

        /// <summary>
        /// Allows members to change their queue status
        /// </summary>
        public bool? editableMemberStatus { get; set; }
    }
}