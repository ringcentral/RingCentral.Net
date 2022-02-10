namespace RingCentral
{
    public class PerformanceCallsActions
    {
        /// <summary>
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CallsActions values { get; set; }
    }
}