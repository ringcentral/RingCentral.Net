namespace RingCentral
{
    /// <summary>
    ///     Data for calls with breakdown by queue hours (BusinessHours, AfterHours)
    /// </summary>
    public class CallsByQueueHours
    {
        /// <summary>
        ///     Unit of the result value
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CallsByQueueHoursBreakdown values { get; set; }
    }
}