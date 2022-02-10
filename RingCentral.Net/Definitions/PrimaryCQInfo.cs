namespace RingCentral
{
    /// <summary>
    ///     Primary call session information. Supported for Call Queues only
    /// </summary>
    public class PrimaryCQInfo
    {
        /// <summary>
        ///     Call information to be displayed as 'Line 1' for a call queue call session
        ///     Enum: PhoneNumberLabel, PhoneNumber, QueueExtension, QueueName, CallerIdName, CallerIdNumber, None
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Call information value
        /// </summary>
        public string value { get; set; }
    }
}