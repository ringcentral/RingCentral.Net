namespace RingCentral
{
    /// <summary>
    ///     Optional information to be used when account is moved to "Disabled" status
    /// </summary>
    public class StatusInfo
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
        ///     Date after which the account will get deleted. Parameter can be used to overwrite default retention period
        ///     Format: date-time
        ///     Example: 2023-03-26T11:30:45.940Z
        /// </summary>
        public string till { get; set; }
    }
}