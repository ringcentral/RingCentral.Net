namespace RingCentral
{
    public class CallQueueInfo
    {
        /// <summary>
        /// Internal identifier of a call queue
        /// </summary>
        public string id;

        /// <summary>
        /// Name of a call queue
        /// </summary>
        public string name;

        /// <summary>
        /// Extension number of a call queue
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// Flag allow members to change their queue status
        /// </summary>
        public bool? editableMemberStatus;
    }
}