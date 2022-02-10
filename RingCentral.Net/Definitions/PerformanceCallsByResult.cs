namespace RingCentral
{
    public class PerformanceCallsByResult
    {
        /// <summary>
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CallsByResult values { get; set; }
    }
}