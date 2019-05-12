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
        /// Meida file to upload
        /// </summary>
        public Attachment binary;

        /// <summary>
        /// </summary>
        public CustomGreetingAnsweringRuleInfoRequest answeringRule;
    }
}