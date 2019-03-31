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
        /// Enum: Introductory, Announcement, ConnectingAudio, ConnectingMessage, Voicemail, Unavailable, HoldMusic
        /// </summary>
        public string type;

        /// <summary>
        /// Content media type in WAV/MP3 format
        /// Enum: WAV, MP3
        /// </summary>
        public string contentType;

        /// <summary>
        /// Link to a greeting content (audio file)
        /// </summary>
        public string contentUri;

        /// <summary>
        /// Information on an answering rule that the greeting is applied to
        /// </summary>
        public CustomGreetingAnsweringRuleInfo answeringRule;
    }
}