namespace RingCentral
{
    public class CallQueueOverflowSettings
    {
        /// <summary>
        ///     Call queue overflow status
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        /// </summary>
        public CallQueueOverflowAgent[] items { get; set; }
    }
}