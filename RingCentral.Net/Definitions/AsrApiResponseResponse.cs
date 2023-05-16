namespace RingCentral
{
    public class AsrApiResponseResponse
    {
        /// <summary>
        ///     The number of speakers detected. Field is set only when enableSpeakerDiarization is true.
        ///     Format: int32
        ///     Example: 2
        /// </summary>
        public long? speakerCount { get; set; }

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
    }
}