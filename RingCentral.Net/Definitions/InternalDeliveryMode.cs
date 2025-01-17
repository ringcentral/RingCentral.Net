namespace RingCentral
{
    public class InternalDeliveryMode
    {
        /// <summary>
        ///     The transport type for this subscription, or the channel by which an app should be notified of an event
        ///     Required
        ///     Enum: Internal
        /// </summary>
        public string transportType { get; set; }

        /// <summary>
        ///     The name of internal channel (defined in the backend service configuration) to deliver notifications through.
        ///     Required
        ///     Example: my-server-channel
        /// </summary>
        public string configName { get; set; }
    }
}