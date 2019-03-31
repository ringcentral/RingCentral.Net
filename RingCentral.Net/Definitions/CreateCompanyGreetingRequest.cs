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
        /// Meida file to upload
        /// </summary>
        public Attachment binary;

        /// <summary>
        /// </summary>
        public CustomCompanyGreetingAnsweringRuleInfo answeringRule;
    }
}