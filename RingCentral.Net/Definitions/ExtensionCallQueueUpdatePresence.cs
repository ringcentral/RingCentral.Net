namespace RingCentral
{
    public class ExtensionCallQueueUpdatePresence
    {
        /// <summary>
        /// </summary>
        public CallQueueId callQueue { get; set; }

        /// <summary>
        /// Call queue agent availability for calls of this queue
        /// </summary>
        public bool? acceptCalls { get; set; }
    }
}