namespace RingCentral
{
    public class GreetingInfo
    {
        /// <summary>
        /// Type of a greeting, specifying the case when the greeting is played.
        /// Enum: Introductory, Announcement, ConnectingMessage, ConnectingAudio, Voicemail, Unavailable, InterruptPrompt, HoldMusic, Custom, Company, BlockedCallersSpecific, BlockedCallersAll, BlockedNoCallerId, BlockedPayPhones, StartRecording, StopRecording, AutomaticRecording
        /// </summary>
        public string type;

        /// <summary>
        /// Usage type of a greeting, specifying if the greeting is applied to user extension or department extension.
        /// Enum: UserExtensionAnsweringRule, ExtensionAnsweringRule, DepartmentExtensionAnsweringRule, CompanyAnsweringRule, CompanyAfterHoursAnsweringRule, VoicemailExtensionAnsweringRule, AnnouncementExtensionAnsweringRule
        /// </summary>
        public string usageType;

        /// <summary>
        /// </summary>
        public PresetInfo preset;

        /// <summary>
        /// </summary>
        public CustomGreetingInfoRequest custom;
    }
}