namespace RingCentral
{
    /// <summary>
    ///     Status information (reason, comment). Returned for 'Disabled'
    ///     status only
    /// </summary>
    public class ExtensionStatusInfo
    {
        /// <summary>
        ///     A free-form user comment, describing the status change reason
        /// </summary>
        public string comment { get; set; }

        /// <summary>
        ///     Type of suspension
        ///     Enum: SuspendedVoluntarily, SuspendedInvoluntarily, CancelledVoluntarily, CancelledInvoluntarily
        /// </summary>
        public string reason { get; set; }

        /// <summary>
        ///     Date until which an account will get deleted. The default
        ///     value is 30 days since the current date
        ///     Format: date-time
        /// </summary>
        public string till { get; set; }
    }
}