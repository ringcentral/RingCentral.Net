namespace RingCentral
{
    // Prompt metadata
    public class IVRMenuPromptInfo
    {
        /// <summary>
        /// Prompt mode: custom media or text
        /// Enum: Audio, TextToSpeech
        /// </summary>
        public string mode;

        /// <summary>
        /// </summary>
        public AudioPromptInfo audio;

        /// <summary>
        /// For 'TextToSpeech' mode only. Prompt text
        /// </summary>
        public string text;

        /// <summary>
        /// </summary>
        public PromptLanguageInfo language;
    }
}