namespace RingCentral
{
    public class GreetingInfo
    {
        /// <summary>
        ///     Type of greeting, specifying the case when the greeting is played.
        ///     Enum: Introductory, Announcement, AutomaticRecording, BlockedCallersAll, BlockedCallersSpecific, BlockedNoCallerId,
        ///     BlockedPayPhones, ConnectingMessage, ConnectingAudio, StartRecording, StopRecording, Voicemail, Unavailable,
        ///     InterruptPrompt, HoldMusic, Company
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