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
        /// Content media type
        /// Enum: audio/mpeg, audio/wav
        /// </summary>
        public string contentType;

        /// <summary>
        /// Link to a greeting content (audio file)
        /// </summary>
        public string contentUri;

        /// <summary>
        /// </summary>
        public CustomGreetingAnsweringRuleInfo answeringRule;

        /// <summary>
        /// </summary>
        public CustomCompanyGreetingLanguageInfo language;
    }
}