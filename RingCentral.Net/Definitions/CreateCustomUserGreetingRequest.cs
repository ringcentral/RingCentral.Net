namespace RingCentral
{
    /// <summary>
    /// Request body for operation createCustomUserGreeting
    /// </summary>
    public class CreateCustomUserGreetingRequest
    {
        /// <summary>
        ///     Type of greeting, specifying the case when the greeting is played.
        ///     Required
        ///     Enum: Introductory, Announcement, ConnectingMessage, ConnectingAudio, Voicemail, Unavailable, HoldMusic, TemplateGreeting
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Text to be used for speech transcription
        ///     Example: Welcome to RingCentral
        /// </summary>
        public string text { get; set; }

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