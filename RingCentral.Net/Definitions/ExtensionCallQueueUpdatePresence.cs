namespace RingCentral
{
    public class ExtensionCallQueueUpdatePresence
    {
        /// <summary>
        /// Call queue information
        /// </summary>
        public CallQueueId callQueue;

        /// <summary>
        /// Call queue agent availability for calls of this queue
        /// </summary>
        public bool? acceptCalls;
    }
}