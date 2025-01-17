namespace RingCentral
{
    /// <summary>
    ///     One utterance of a call. Each utterance is a speakerId, text, start and end time
    /// </summary>
    public class TranscriptInsightUnit
    {
        /// <summary>
        ///     Participant ID
        ///     Required
        ///     Example: p-32423
        /// </summary>
        public string speakerId { get; set; }

        /// <summary>
        ///     Text of the utterance
        ///     Required
        ///     Example: Hello user!
        /// </summary>
        public string text { get; set; }

        /// <summary>
        ///     Start time of the utterance (in sec)
        ///     Required
        ///     Format: float
        ///     Example: 1.2
        /// </summary>
        public decimal? start { get; set; }

        /// <summary>
        ///     End time of the utterance (in sec)
        ///     Required
        ///     Format: float
        ///     Example: 4.2
        /// </summary>
        public decimal? end { get; set; }
    }
}