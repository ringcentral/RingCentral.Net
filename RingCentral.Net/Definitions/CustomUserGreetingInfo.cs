namespace RingCentral
{
    public class CustomUserGreetingInfo
    {
        /// <summary>
        /// Link to a custom user greeting
        /// </summary>
        public string uri;

        /// <summary>
        /// Internal identifier of a custom user greeting
        /// </summary>
        public string id;

        /// <summary>
        /// Type of a custom user greeting
        /// Enum: Introductory, Announcement, InterruptPrompt, ConnectingAudio, ConnectingMessage, Voicemail, Unavailable, HoldMusic, PronouncedName
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
    }
}