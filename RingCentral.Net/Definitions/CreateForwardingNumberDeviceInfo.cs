namespace RingCentral
{
    /// <summary>
    ///     Forwarding device information. Applicable for 'PhoneLine' type only. Cannot be specified together with
    ///     'phoneNumber' parameter
    /// </summary>
    public class CreateForwardingNumberDeviceInfo
    {
        /// <summary>
        ///     Internal identifier of the other extension device
        /// </summary>
        public string id { get; set; }
    }
}