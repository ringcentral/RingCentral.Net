namespace RingCentral
{
    public class CallQueueDetails
    {
        /// <summary>
        /// Internal identifier of a call queue
        /// </summary>
        public string id;

        /// <summary>
        /// Call queue name
        /// </summary>
        public string name;

        /// <summary>
        /// Call queue extension number
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// Call queue status
        /// Enum: Enabled, Disabled, NotActivated
        /// </summary>
        public string status;

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