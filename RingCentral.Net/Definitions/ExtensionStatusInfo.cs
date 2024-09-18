namespace RingCentral
{
    /// <summary>
    ///     Status information (reason, comment). Returned for `Disabled` extensions only
    /// </summary>
    public class ExtensionStatusInfo
    {
        /// <summary>
        ///     A free-form user comment, describing the status change reason
        /// </summary>
        public string comment { get; set; }

        /// <summary>
        ///     Type of suspension
        ///     Enum: Voluntarily, Involuntarily
        /// </summary>
        public string reason { get; set; }
    }
}