namespace RingCentral
{
    // For 'TextToSpeech' mode only. Prompt language metadata
    public class PromptLanguageInfo
    {
        /// <summary>
        /// Link to a prompt language
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Internal identifier of a language
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Language name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Language locale code
        /// </summary>
        public string localeCode { get; set; }
    }
}