namespace RingCentral
{
    /// <summary>
    ///     Data for calls with breakdown by origin (Internal, External)
    /// </summary>
    public class CallsByOrigin
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
        public CallsByOriginBreakdown values { get; set; }
    }
}