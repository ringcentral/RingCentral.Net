namespace RingCentral
{
    public class InternalDeliveryMode
    {
        /// <summary>
        ///     The transport type for this subscription
        ///     Required
        ///     Enum: Internal
        /// </summary>
        public string transportType { get; set; }

        /// <summary>
        ///     (Only for an `Internal` transport)
        ///     The name of internal channel (defined in the backend service configuration) to deliver notifications through.
        ///     Required
        ///     Example: my-server-channel
        /// </summary>
        public string configName { get; set; }
    }
}