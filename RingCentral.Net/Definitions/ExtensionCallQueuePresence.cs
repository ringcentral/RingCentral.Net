namespace RingCentral
{
    public class ExtensionCallQueuePresence
    {
        /// <summary>
        /// </summary>
        public PresenceCallQueueInfo callQueue { get; set; }

        /// <summary>
        ///     Call queue agent availability for calls of this queue
        /// </summary>
        public bool? acceptCalls { get; set; }
    }
}