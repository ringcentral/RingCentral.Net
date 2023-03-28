namespace RingCentral
{
    /// <summary>
    ///     Request body for operation createCustomUserGreeting
    /// </summary>
    public class CreateCustomUserGreetingRequest
    {
        /// <summary>
        ///     Type of a greeting, specifying the case when the greeting is played.
        ///     Required
        ///     Enum: Introductory, Announcement, ConnectingMessage, ConnectingAudio, Voicemail, Unavailable, HoldMusic,
        ///     TemplateGreeting
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Media file to upload
        ///     Required
        /// </summary>
        public Attachment binary { get; set; }

        /// <summary>
        /// </summary>
        public GreetingAnsweringRuleId answeringRule { get; set; }
    }
}