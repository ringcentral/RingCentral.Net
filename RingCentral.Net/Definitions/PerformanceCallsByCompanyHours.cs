namespace RingCentral
{
    public class PerformanceCallsByCompanyHours
    {
        /// <summary>
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CallsByCompanyHours values { get; set; }
    }
}