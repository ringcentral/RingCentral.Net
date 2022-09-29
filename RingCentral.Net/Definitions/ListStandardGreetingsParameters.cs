namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listStandardGreetings
    /// </summary>
    public class ListStandardGreetingsParameters
    {
        /// <summary>
        ///     Type of a greeting, specifying the case when the greeting is played
        ///     Enum: Introductory, Announcement, ConnectingMessage, ConnectingAudio, Voicemail, Unavailable, HoldMusic, Company
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Usage type of a greeting, specifying if the greeting is applied for user extension or department (call queue)
        ///     extension
        ///     Enum: UserExtensionAnsweringRule, ExtensionAnsweringRule, DepartmentExtensionAnsweringRule, CompanyAnsweringRule,
        ///     CompanyAfterHoursAnsweringRule, VoicemailExtensionAnsweringRule, AnnouncementExtensionAnsweringRule,
        ///     SharedLinesGroupAnsweringRule
        /// </summary>
        public string usageType { get; set; }
    }
}