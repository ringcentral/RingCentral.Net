namespace RingCentral
{
    public class PerformanceCallsByDirection
    {
        /// <summary>
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CallsByDirection values { get; set; }
    }
}