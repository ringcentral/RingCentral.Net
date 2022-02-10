namespace RingCentral
{
    public class PerformanceCallsByQueueSla
    {
        /// <summary>
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CallsByQueueSla values { get; set; }
    }
}