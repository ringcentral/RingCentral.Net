namespace RingCentral
{
    public class CallQueueOverflowSettingsRequestResource
    {
        /// <summary>
        ///     Call queue overflow status
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        /// </summary>
        public CallQueueIdResource[] items { get; set; }
    }
}