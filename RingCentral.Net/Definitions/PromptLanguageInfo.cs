namespace RingCentral
{
    // For 'TextToSpeech' mode only. Prompt language metadata
    public class PromptLanguageInfo
    {
        /// <summary>
        /// Link to a prompt language
        /// </summary>
        public string uri;

        /// <summary>
        /// Internal identifier of a language
        /// </summary>
        public string id;

        /// <summary>
        /// Language name
        /// </summary>
        public string name;

        /// <summary>
        /// Language locale code
        /// </summary>
        public string localeCode;
    }
}