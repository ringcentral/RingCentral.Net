namespace RingCentral
{
    /// <summary>
    ///     Data for calls with breakdown by segments (Ringing, LiveTalk, Hold, Park, Transfer, IvrPrompt, Voicemail,
    ///     VmGreeting, Setup)
    /// </summary>
    public class CallsBySegments
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
        public CallsBySegmentsBreakdown values { get; set; }
    }
}