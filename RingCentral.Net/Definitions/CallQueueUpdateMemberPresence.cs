namespace RingCentral
{
    public class CallQueueUpdateMemberPresence
    {
        /// <summary>
        /// </summary>
        public CallQueueMemberId member { get; set; }

        /// <summary>
        /// Call queue member availability for calls of this queue
        /// </summary>
        public bool? acceptCurrentQueueCalls { get; set; }
    }
}