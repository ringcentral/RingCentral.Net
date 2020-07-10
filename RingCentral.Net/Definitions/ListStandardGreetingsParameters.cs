namespace RingCentral
{
    public class ListStandardGreetingsParameters
    {
        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are accepted.
        /// Default: 1
        /// </summary>
        public long? page;

        /// <summary>
        /// Indicates the page size (number of items).
        /// Default: 100
        /// </summary>
        public long? perPage;

        /// <summary>
        /// Type of a greeting, specifying the case when the greeting is played
        /// Enum: Introductory, Announcement, ConnectingMessage, ConnectingAudio, Voicemail, Unavailable, HoldMusic, Company
        /// </summary>
        public string type;

        /// <summary>
        /// Usage type of a greeting, specifying if the greeting is applied for user extension or department extension
        /// Enum: UserExtensionAnsweringRule, ExtensionAnsweringRule, DepartmentExtensionAnsweringRule, CompanyAnsweringRule, CompanyAfterHoursAnsweringRule, VoicemailExtensionAnsweringRule, AnnouncementExtensionAnsweringRule, SharedLinesGroupAnsweringRule
        /// </summary>
        public string usageType;
    }
}