namespace RingCentral
{
    public class DictionaryGreetingInfo
    {
        /// <summary>
        /// Internal identifier of a greeting
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Link to a greeting
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Name of a greeting
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Usage type of a greeting, specifying if the greeting is applied for user extension or department extension.
        /// Enum: UserExtensionAnsweringRule, ExtensionAnsweringRule, DepartmentExtensionAnsweringRule, BlockedCalls, CallRecording, CompanyAnsweringRule, CompanyAfterHoursAnsweringRule, LimitedExtensionAnsweringRule, VoicemailExtensionAnsweringRule, AnnouncementExtensionAnsweringRule, SharedLinesGroupAnsweringRule
        /// </summary>
        public string usageType { get; set; }

        /// <summary>
        /// Text of a greeting, if any
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Link to a greeting content (audio file), if any
        /// </summary>
        public string contentUri { get; set; }

        /// <summary>
        /// Type of a greeting, specifying the case when the greeting is played.
        /// Enum: Introductory, Announcement, AutomaticRecording, BlockedCallersAll, BlockedCallersSpecific, BlockedNoCallerId, BlockedPayPhones, ConnectingMessage, ConnectingAudio, StartRecording, StopRecording, Voicemail, Unavailable, InterruptPrompt, HoldMusic, Company
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Category of a greeting, specifying data form. The category value 'None' specifies that greetings of a certain type ('Introductory', 'ConnectingAudio', etc.) are switched off for an extension = ['Music', 'Message', 'RingTones', 'None']
        /// Enum: Music, Message, RingTones, None
        /// </summary>
        public string category { get; set; }

        /// <summary>
        /// </summary>
        public CallHandlingNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public CallHandlingPagingInfo paging { get; set; }
    }
}