namespace RingCentral
{
    public class CallQueueMemberPresence
    {
        /// <summary>
        /// Call queue member information
        /// </summary>
        public CallQueueMember member;

        /// <summary>
        /// Private member telephony availability status applied to calls of all queues
        /// </summary>
        public bool? acceptQueueCalls;

        /// <summary>
        /// Call queue member availability in this particular queue
        /// </summary>
        public bool? acceptCurrentQueueCalls;
    }
}