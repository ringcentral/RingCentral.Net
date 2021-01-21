namespace RingCentral
{
    public class ExtensionCallQueuePresence
    {
        /// <summary>
        /// </summary>
        public CallQueueInfo callQueue { get; set; }

        /// <summary>
        /// Call queue agent availability for calls of this queue
        /// </summary>
        public bool? acceptCalls { get; set; }
    }
}