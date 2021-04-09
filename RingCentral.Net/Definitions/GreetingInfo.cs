namespace RingCentral
{
    public class GreetingInfo
    {
        /// <summary>
        ///     Type of a greeting, specifying the case when the greeting is played.
        ///     Enum: Introductory, Announcement, ConnectingMessage, ConnectingAudio, Voicemail, Unavailable, InterruptPrompt,
        ///     HoldMusic, Custom, Company, BlockedCallersSpecific, BlockedCallersAll, BlockedNoCallerId, BlockedPayPhones,
        ///     StartRecording, StopRecording, AutomaticRecording
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public PresetInfo preset { get; set; }

        /// <summary>
        /// </summary>
        public CustomGreetingInfoRequest custom { get; set; }
    }
}