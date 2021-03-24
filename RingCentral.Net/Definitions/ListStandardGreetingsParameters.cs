namespace RingCentral
{
    // Query parameters for operation listStandardGreetings
    public class ListStandardGreetingsParameters
    {
        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are accepted.
        /// Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        /// Indicates the page size (number of items).
        /// Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        /// Type of a greeting, specifying the case when the greeting is played
        /// Enum: Introductory, Announcement, ConnectingMessage, ConnectingAudio, Voicemail, Unavailable, HoldMusic, Company
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Usage type of a greeting, specifying if the greeting is applied for user extension or department (call queue) extension
        /// Enum: UserExtensionAnsweringRule, ExtensionAnsweringRule, DepartmentExtensionAnsweringRule, CompanyAnsweringRule, CompanyAfterHoursAnsweringRule, VoicemailExtensionAnsweringRule, AnnouncementExtensionAnsweringRule, SharedLinesGroupAnsweringRule
        /// </summary>
        public string usageType { get; set; }
    }
}