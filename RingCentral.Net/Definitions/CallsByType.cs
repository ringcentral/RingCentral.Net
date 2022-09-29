namespace RingCentral
{
    /// <summary>
    ///     Data for calls with breakdown by type (Direct, FromQueue, ParkRetrieval, Transferred, Outbound)
    /// </summary>
    public class CallsByType
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
        public CallsByTypeBreakdown values { get; set; }
    }
}