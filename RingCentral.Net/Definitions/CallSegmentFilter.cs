namespace RingCentral
{
    public class CallSegmentFilter
    {
        /// <summary>
        ///     Enum: Ringing, LiveTalk, Hold, Park, Transfer, IvrPrompt, Voicemail, VmGreeting
        /// </summary>
        public string callSegment { get; set; }

        /// <summary>
        /// </summary>
        public PerformanceCallsCallSegmentLengthFilter callSegmentLength { get; set; }
    }
}