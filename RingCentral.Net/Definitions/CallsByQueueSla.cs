namespace RingCentral
{
    /// <summary>
    ///     Data for calls with breakdown by queue SLA (InSLA, OutSLA). This counter is only applicable to Queues grouping
    /// </summary>
    public class CallsByQueueSla
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
        public CallsByQueueSlaBreakdown values { get; set; }
    }
}