namespace RingCentral
{
    public class CustomCompanyGreetingInfo
    {
        /// <summary>
        /// Link to an extension custom greeting
        /// </summary>
        public string uri;

        /// <summary>
        /// Internal identifier of an answering rule
        /// </summary>
        public string id;

        /// <summary>
        /// Type of a company greeting
        /// Enum: Company, StartRecording, StopRecording, AutomaticRecording
        /// </summary>
        public string type;

        /// <summary>
        /// Content media type in WAV/MP3 format
        /// Enum: WAV, MP3
        /// </summary>
        public string contentType;

        /// <summary>
        /// Link to a greeting content (audio file)
        /// </summary>
        public string contentUri;

        /// <summary>
        /// Information on an answering rule that the greeting is applied to
        /// </summary>
        public CustomGreetingAnsweringRuleInfo answeringRule;

        /// <summary>
        /// Information on a greeting language. Supported for types 'StopRecording', 'StartRecording', 'AutomaticRecording'
        /// </summary>
        public CustomCompanyGreetingLanguageInfo language;
    }
}