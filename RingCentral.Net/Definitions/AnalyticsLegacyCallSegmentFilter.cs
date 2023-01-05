namespace RingCentral
{
    public class AnalyticsLegacyCallSegmentFilter
    {
        /// <summary>
        ///     Required
        ///     Enum: Ringing, LiveTalk, Hold, Park, Transfer, IvrPrompt, Voicemail, VmGreeting, Setup
        /// </summary>
        public string callSegment { get; set; }

        /// <summary>
        /// </summary>
        public AnalyticsLegacyPerformanceCallsCallSegmentLengthFilter callSegmentLength { get; set; }
    }
}