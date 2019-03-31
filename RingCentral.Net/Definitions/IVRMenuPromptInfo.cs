namespace RingCentral
{
    public class IVRMenuPromptInfo
    {
        /// <summary>
        /// Prompt mode: custom media or text
        /// Enum: Audio, TextToSpeech
        /// </summary>
        public string mode;

        /// <summary>
        /// For 'Audio' mode only. Prompt media reference
        /// </summary>
        public PromptLanguageInfo audio;

        /// <summary>
        /// For 'TextToSpeech' mode only. Prompt text
        /// </summary>
        public string text;

        /// <summary>
        /// For 'TextToSpeech' mode only. Prompt language metadata
        /// </summary>
        public AudioPromptInfo language;
    }
}