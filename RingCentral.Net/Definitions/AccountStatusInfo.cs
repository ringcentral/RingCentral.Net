namespace RingCentral
{
    // Status information (reason, comment, lifetime). Returned for 'Disabled' status only
    public class AccountStatusInfo
    {
        /// <summary>
        /// A free-form user comment, describing the status change reason
        /// </summary>
        public string comment { get; set; }

        /// <summary>
        /// Type of suspension
        /// Enum: SuspendedVoluntarily, SuspendedInvoluntarily, UserResumed
        /// </summary>
        public string reason { get; set; }

        /// <summary>
        /// Date until which the account will get deleted. The default value is 30 days since current date
        /// </summary>
        public string till { get; set; }
    }
}