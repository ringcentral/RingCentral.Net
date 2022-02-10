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
        ///     Enum: Introductory, Announcement, ConnectingMessage, ConnectingAudio, Voicemail, Unavailable, HoldMusic
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Internal identifier of an answering rule
        /// </summary>
        public string answeringRuleId { get; set; }

        /// <summary>
        ///     Media file to upload
        ///     Required
        /// </summary>
        public Attachment binary { get; set; }
    }
}