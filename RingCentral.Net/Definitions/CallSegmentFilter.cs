namespace RingCentral
{
    // Filtering calls by segment
    public class CallSegmentFilter
    {
        /// <summary>
        ///     Required
        ///     Enum: Ringing, LiveTalk, Hold, Park, Transfer, IvrPrompt, VoiceMailing, VmGreeting
        /// </summary>
        public string callSegment { get; set; }
    }
}