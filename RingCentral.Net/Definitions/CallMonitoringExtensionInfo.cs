namespace RingCentral
{
    public class CallMonitoringExtensionInfo
    {
        /// <summary>
        ///     Internal identifier of an extension. Only the following extension types are allowed: User, DigitalUser,
        ///     VirtualUser, FaxUser, Limited
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Set of call monitoring group permissions granted to the specified extension. In order to remove the specified
        ///     extension from a call monitoring group use an empty value
        ///     Enum: Monitoring, Monitored
        /// </summary>
        public string[] permissions { get; set; }
    }
}