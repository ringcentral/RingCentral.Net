namespace RingCentral
{
    public class PerformanceCallsByOrigin
    {
        /// <summary>
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CallsByOrigin values { get; set; }
    }
}