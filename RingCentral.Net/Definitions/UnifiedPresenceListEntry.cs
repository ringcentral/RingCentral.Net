namespace RingCentral
{
    public class UnifiedPresenceListEntry
    {
        /// <summary>
        /// Internal identifier of the resource
        /// </summary>
        public string resourceId;

        /// <summary>
        /// Status code of resource retrieval
        /// </summary>
        public long? status;

        /// <summary>
        /// </summary>
        public UnifiedPresence body;
    }
}