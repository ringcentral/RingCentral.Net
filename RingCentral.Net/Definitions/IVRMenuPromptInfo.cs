namespace RingCentral
{
    /// <summary>
    ///     Prompt metadata
    /// </summary>
    public class IVRMenuPromptInfo
    {
        /// <summary>
        ///     Prompt mode: custom media or text
        ///     Enum: Audio, TextToSpeech
        /// </summary>
        public string mode { get; set; }

        /// <summary>
        /// </summary>
        public AudioPromptInfo audio { get; set; }

        /// <summary>
        ///     For 'TextToSpeech' mode only. Prompt text
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// </summary>
        public PromptLanguageInfo language { get; set; }
    }
}