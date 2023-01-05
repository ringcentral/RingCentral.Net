namespace RingCentral
{
    /// <summary>
    ///     Status information (reason, comment, lifetime). Returned for 'Disabled'
    ///     status only
    /// </summary>
    public class AccountStatusInfo
    {
        /// <summary>
        ///     A free-form user comment, describing the status change reason
        /// </summary>
        public string comment { get; set; }

        /// <summary>
        ///     Type of suspension
        ///     Enum: SuspendedVoluntarily, SuspendedInvoluntarily, UserResumed
        /// </summary>
        public string reason { get; set; }

        /// <summary>
        ///     Date until which an account will get deleted. The default
        ///     value is 30 days since the current date
        /// </summary>
        public string till { get; set; }
    }
}