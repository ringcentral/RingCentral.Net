namespace RingCentral
{
    public class PerformanceCallsByResponse
    {
        /// <summary>
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CallsByResponse values { get; set; }
    }
}