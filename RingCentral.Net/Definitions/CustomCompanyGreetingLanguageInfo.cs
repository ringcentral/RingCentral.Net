namespace RingCentral
{
    // Information on a greeting language. Supported for types 'StopRecording', 'StartRecording', 'AutomaticRecording'
    public class CustomCompanyGreetingLanguageInfo
    {
        /// <summary>
        /// Internal identifier of a greeting language
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Link to a greeting language
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Name of a greeting language
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Locale code of a greeting language
        /// </summary>
        public string localeCode { get; set; }
    }
}