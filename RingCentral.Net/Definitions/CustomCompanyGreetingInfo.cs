namespace RingCentral
{
    public class CustomCompanyGreetingInfo
    {
        /// <summary>
        ///     Link to an extension custom greeting
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of an answering rule
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Type of a company greeting
        ///     Enum: Company, StartRecording, StopRecording, AutomaticRecording, TemplateGreeting
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Content media type
        ///     Enum: audio/mpeg, audio/wav
        /// </summary>
        public string contentType { get; set; }

        /// <summary>
        ///     Link to a greeting content (audio file)
        /// </summary>
        public string contentUri { get; set; }

        /// <summary>
        /// </summary>
        public CustomGreetingAnsweringRuleInfo answeringRule { get; set; }

        /// <summary>
        /// </summary>
        public CustomCompanyGreetingLanguageInfo language { get; set; }
    }
}