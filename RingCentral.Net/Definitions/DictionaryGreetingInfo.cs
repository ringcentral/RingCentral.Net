namespace RingCentral
{
    public class DictionaryGreetingInfo
    {
        /// <summary>
        /// Internal identifier of a greeting
        /// </summary>
        public string id;

        /// <summary>
        /// Link to a greeting
        /// </summary>
        public string uri;

        /// <summary>
        /// Name of a greeting
        /// </summary>
        public string name;

        /// <summary>
        /// Usage type of a greeting, specifying if the greeting is applied for user extension or department extension.
        /// Enum: UserExtensionAnsweringRule, ExtensionAnsweringRule, DepartmentExtensionAnsweringRule, CompanyAnsweringRule, CompanyAfterHoursAnsweringRule, VoicemailExtensionAnsweringRule, AnnouncementExtensionAnsweringRule
        /// </summary>
        public string usageType;

        /// <summary>
        /// Text of a greeting, if any
        /// </summary>
        public string text;

        /// <summary>
        /// Link to a greeting content (audio file), if any
        /// </summary>
        public string contentUri;

        /// <summary>
        /// Type of a greeting, specifying the case when the greeting is played.
        /// Enum: Introductory, Announcement, ConnectingMessage, ConnectingAudio, Voicemail, Unavailable, InterruptPrompt, HoldMusic, Company
        /// </summary>
        public string type;

        /// <summary>
        /// Category of a greeting, specifying data form. The category value 'None' specifies that greetings of a certain type ('Introductory', 'ConnectingAudio', etc.) are switched off for an extension = ['Music', 'Message', 'RingTones', 'None']
        /// Enum: Music, Message, RingTones, None
        /// </summary>
        public string category;

        /// <summary>
        /// Information on navigation
        /// </summary>
        public CallHandlingNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// </summary>
        public CallHandlingPagingInfo paging;
    }
}