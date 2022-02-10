namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation updateMessage
    /// </summary>
    public class UpdateMessageParameters
    {
        /// <summary>
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        ///     Enum: Fax, SMS, VoiceMail, Pager, Text, All
        /// </summary>
        public string type { get; set; }
    }
}