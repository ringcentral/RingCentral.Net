namespace RingCentral
{
    public class CustomUserGreetingInfo
    {
        /// <summary>
        ///     Link to a custom user greeting
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a custom user greeting
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Type of a custom user greeting
        ///     Enum: Introductory, Announcement, InterruptPrompt, ConnectingAudio, ConnectingMessage, Voicemail, Unavailable, HoldMusic, PronouncedName
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Content media type
        ///     Enum: audio/mpeg, audio/wav
        /// </summary>
        public string contentType { get; set; }

        /// <summary>
        ///     Link to a greeting content (audio file)
        /// </summary>
        public string contentUri { get; set; }

        /// <summary>
        /// </summary>
        public CustomGreetingAnsweringRuleInfo answeringRule { get; set; }
    }
}