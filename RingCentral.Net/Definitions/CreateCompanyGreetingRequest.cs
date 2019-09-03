namespace RingCentral
{
    public class CreateCompanyGreetingRequest
    {
        /// <summary>
        /// Type of a greeting, specifying the case when the greeting is played.
        /// Enum: Company, StartRecording, StopRecording, AutomaticRecording
        /// </summary>
        public string type;

        /// <summary>
        /// Internal identifier of a language. See Get Language List
        /// </summary>
        public string languageId;

        /// <summary>
        /// Meida file to upload
        /// </summary>
        public Attachment binary;

        /// <summary>
        /// </summary>
        public CustomCompanyGreetingAnsweringRuleInfo answeringRule;
    }
}