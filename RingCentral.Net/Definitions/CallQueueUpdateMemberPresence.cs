namespace RingCentral
{
    public class CallQueueUpdateMemberPresence
    {
        /// <summary>
        /// Call queue member information
        /// </summary>
        public CallQueueMemberId member;

        /// <summary>
        /// Call queue member availability for calls of this queue
        /// </summary>
        public bool? acceptCurrentQueueCalls;
    }
}