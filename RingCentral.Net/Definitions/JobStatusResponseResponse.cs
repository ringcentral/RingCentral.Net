namespace RingCentral
{
    public class JobStatusResponseResponse
    {
        /// <summary>
        ///     The number of speakers detected. Field is set only when enableSpeakerDiarization is true.
        ///     Format: int32
        ///     Example: 2
        /// </summary>
        public long? speakerCount { get; set; }

        /// <summary>
        ///     Speaker wise utterances. Field is set only when enableSpeakerDiarization is true.
        /// </summary>
        public UtteranceObject[] utterances { get; set; }

        /// <summary>
        /// </summary>
        public WordSegment[] words { get; set; }

        /// <summary>
        ///     Overall transcription confidence.
        ///     Format: float
        /// </summary>
        public decimal? confidence { get; set; }

        /// <summary>
        ///     The entire transcript with/without punctuations according to the input.
        /// </summary>
        public string transcript { get; set; }

        /// <summary>
        /// </summary>
        public UtteranceInsightsObject[] utteranceInsights { get; set; }

        /// <summary>
        /// </summary>
        public SpeakerInsightsObject speakerInsights { get; set; }

        /// <summary>
        /// </summary>
        public ConversationalInsightsUnit[] conversationalInsights { get; set; }
    }
}