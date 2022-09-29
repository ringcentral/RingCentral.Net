namespace RingCentral
{
    /// <summary>
    ///     Data for calls with breakdown by response (Answered, NotAnswered, Connected, NotConnected)
    /// </summary>
    public class CallsByResponse
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
        public CallsByResponseBreakdown values { get; set; }
    }
}