namespace RingCentral
{
    /// <summary>
    ///     Data for calls with breakdown by result (Completed, Abandoned, Voicemail, Unknown, Missed, Accepted)
    /// </summary>
    public class CallsByResult
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
        public CallsByResultBreakdown values { get; set; }
    }
}