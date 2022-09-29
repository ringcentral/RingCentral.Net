namespace RingCentral
{
    /// <summary>
    ///     Data for calls with breakdown by direction (Inbound, Outbound)
    /// </summary>
    public class CallsByDirection
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
        public CallsByDirectionBreakdown values { get; set; }
    }
}