namespace RingCentral
{
    public class CallQueueUpdateDetails
    {
        /// <summary>
        /// Call queue service level settings
        /// </summary>
        public CallQueueServiceLevelSettings serviceLevelSettings;

        /// <summary>
        /// Allows members to change their queue status
        /// </summary>
        public bool? editableMemberStatus;
    }
}