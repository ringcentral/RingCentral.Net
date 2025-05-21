namespace RingCentral
{
    /// <summary>
    ///     Optional information to be used when account is moved to "Disabled" status
    /// </summary>
    public class AccountStatusInfo
    {
        /// <summary>
        ///     Type of suspension, voluntarily or not
        ///     Example: CancelledVoluntarily
        ///     Enum: SuspendedVoluntarily, SuspendedInvoluntarily, CancelledVoluntarily, CancelledInvoluntarily
        /// </summary>
        public string reason { get; set; }

        /// <summary>
        ///     A meaningful description of the reason to change the status
        ///     Example: By customer request. Case ABC123
        /// </summary>
        public string comment { get; set; }

        /// <summary>
        ///     Date after which the disabled account will get deleted.
        ///     Parameter can be used to overwrite default retention period
        ///     (that is 30 days after disabling the account)
        ///     Format: date-time
        ///     Example: Sun Mar 26 2023 04:30:45 GMT-0700 (Pacific Daylight Time)
        /// </summary>
        public string till { get; set; }
    }
}