namespace RingCentral
{
    public class CreateCustomUserGreetingRequest
    {
        /// <summary>
        /// Type of a greeting, specifying the case when the greeting is played.
        /// Enum: Introductory, Announcement, ConnectingMessage, ConnectingAudio, Voicemail, Unavailable, HoldMusic
        /// </summary>
        public string type;

        /// <summary>
        /// Internal identifier of an answering rule
        /// </summary>
        public string answeringRuleId;

        /// <summary>
        /// Meida file to upload
        /// </summary>
        public Attachment binary;
    }
}