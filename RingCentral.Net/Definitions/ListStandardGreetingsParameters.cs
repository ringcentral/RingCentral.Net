namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listStandardGreetings
    /// </summary>
    public class ListStandardGreetingsParameters
    {
        /// <summary>
        ///     The result set page number (1-indexed) to return
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 1
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     The number of items per page. If provided value in the request
        ///     is greater than a maximum, the maximum value is applied
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 100
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Type of greeting, specifying the case when the greeting is played
        ///     Enum: Introductory, Announcement, ConnectingMessage, ConnectingAudio, Voicemail, Unavailable, HoldMusic, Company
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Usage type of greeting, specifying if the greeting is applied for user extension or department (call queue)
        ///     extension
        ///     Enum: UserExtensionAnsweringRule, ExtensionAnsweringRule, DepartmentExtensionAnsweringRule, CompanyAnsweringRule,
        ///     CompanyAfterHoursAnsweringRule, VoicemailExtensionAnsweringRule, AnnouncementExtensionAnsweringRule,
        ///     SharedLinesGroupAnsweringRule
        /// </summary>
        public string usageType { get; set; }
    }
}