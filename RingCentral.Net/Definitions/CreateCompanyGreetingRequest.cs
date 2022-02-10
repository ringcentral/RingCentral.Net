namespace RingCentral
{
    /// <summary>
    ///     Request body for operation createCompanyGreeting
    /// </summary>
    public class CreateCompanyGreetingRequest
    {
        /// <summary>
        ///     Type of a greeting, specifying the case when the greeting is played.
        ///     Required
        ///     Enum: Company, StartRecording, StopRecording, AutomaticRecording
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Internal identifier of an answering rule
        /// </summary>
        public string answeringRuleId { get; set; }

        /// <summary>
        ///     Internal identifier of a language. See Get Language List
        /// </summary>
        public string languageId { get; set; }

        /// <summary>
        ///     Media file to upload
        ///     Required
        /// </summary>
        public Attachment binary { get; set; }
    }
}