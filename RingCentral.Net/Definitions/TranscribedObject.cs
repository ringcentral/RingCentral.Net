namespace RingCentral
{
    public class TranscribedObject
    {
        /// <summary>
        ///     The number of speakers detected. Field is set only when enableSpeakerDiarization is true.
        ///     Format: int32
        ///     Example: 2
        /// </summary>
        public long? speakerCount { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public WordSegment[] words { get; set; }

        /// <summary>
        ///     Overall transcription confidence.
        ///     Format: float
        /// </summary>
        public decimal? confidence { get; set; }

        /// <summary>
        ///     The entire transcript with/without punctuations according to the input.
        ///     Required
        /// </summary>
        public string transcript { get; set; }
    }
}