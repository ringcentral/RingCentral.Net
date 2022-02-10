namespace RingCentral
{
    /// <summary>
    ///     Additional call session information. Supported for Call Queues only
    /// </summary>
    public class AdditionalCQInfo
    {
        /// <summary>
        ///     Call information to be displayed as 'Line 2' for a call queue call session
        ///     Enum: PhoneNumberLabel, PhoneNumber, QueueExtension, QueueName, CallerIdName, CallerIdNumber, None
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Call information value
        /// </summary>
        public string value { get; set; }
    }
}