namespace RingCentral
{
    /// <summary>
    ///     Result breakdown by segments
    /// </summary>
    public class CallsBySegmentsBreakdown
    {
        /// <summary>
        ///     Value for Ringing segment
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? ringing { get; set; }

        /// <summary>
        ///     Value for LiveTalk segment
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? liveTalk { get; set; }

        /// <summary>
        ///     Value for Hold segment
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? hold { get; set; }

        /// <summary>
        ///     Value for Park segment
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? park { get; set; }

        /// <summary>
        ///     Value for Transfer segment
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? transfer { get; set; }

        /// <summary>
        ///     Value for IVRPrompt segment
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? ivrPrompt { get; set; }

        /// <summary>
        ///     Value for Voicemail segment
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? voicemail { get; set; }

        /// <summary>
        ///     Value for VMGreeting segment
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? vmGreeting { get; set; }

        /// <summary>
        ///     Value for Setup segment
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? setup { get; set; }

        /// <summary>
        ///     Value for Forwarding segment
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? forwarding { get; set; }
    }
}