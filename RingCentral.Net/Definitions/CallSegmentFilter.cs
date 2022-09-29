namespace RingCentral
{
    public class CallSegmentFilter
    {
        /// <summary>
        ///     Call segment for filtering
        ///     Required
        ///     Enum: Ringing, LiveTalk, Hold, Park, Transfer, IvrPrompt, Voicemail, VmGreeting, Setup
        /// </summary>
        public string segment { get; set; }

        /// <summary>
        /// </summary>
        public CallSegmentLengthFilter length { get; set; }
    }
}