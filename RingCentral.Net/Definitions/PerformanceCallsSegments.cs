namespace RingCentral
{
    public class PerformanceCallsSegments
    {
        /// <summary>
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CallsSegments values { get; set; }
    }
}